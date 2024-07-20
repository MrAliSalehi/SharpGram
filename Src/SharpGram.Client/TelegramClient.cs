using System.Threading.Channels;
using EasyTg.Client.Models;
using OneOf;
using OneOf.Types;
using SharpGram.Core.Common;
using SharpGram.Core.Contracts;
using SharpGram.Core.Conversions;
using SharpGram.Core.Cryptography;
using SharpGram.Core.Models.Errors;
using SharpGram.Core.Mtproto.Connections;
using SharpGram.Core.Mtproto.Transport;
using SharpGram.Core.Network;
using SharpGram.Tl.Constructors.AuthAuthorizationNs;
using SharpGram.Tl.Constructors.AuthSentCodeNs;
using SharpGram.Tl.Constructors.CodeSettingsNs;
using SharpGram.Tl.Constructors.ConfigNs;
using SharpGram.Tl.Functions.Auth;
using SharpGram.Tl.Functions.Help;
using SharpGram.Tl.Mtproto;
using SharpGram.Tl.Types;
using RpcError = SharpGram.Core.Models.Errors.RpcError;

namespace EasyTg.Client;

public sealed class TelegramClient(TelegramSession ts, CancellationToken ct = default) : IDisposable
{
    public TelegramSession Session { get; set; } = ts;
    private NetworkManager<Intermediate> _requestManager = default!;

    public async Task<OneOf<bool, ErrorBase>> ConnectAsync()
    {
        //todo handle the dc ips properly
        var dcId = Session.ClientOptions.IsLocalServer ? 7 : Session.ClientOptions.IsTest ? 6 : 2;
        TcpConnection<UnAuthConnection, Intermediate> con;
        if (Session.ConnectionSession.IsAuthorized())
        {
            // we created the authKey through AuthKey Generation Process. we can now begin an authorized connection. https://core.telegram.org/mtproto/auth_key
            var tryConnect = TcpConnection<UnAuthConnection, Intermediate>.New<UnAuthConnection, Intermediate>(dcId);
            if (tryConnect.IsT1) return tryConnect.AsT1;
            con = tryConnect.AsT0;
        }
        else
        {
            var tryAuth = await Authentication.NewAsync(dcId);

            if (tryAuth.IsT1) return tryAuth.AsT1;

            var auth = tryAuth.AsT0; //failure is already checked

            var result = await auth.AuthorizeAsync();
            var authKey = AuthKey.FromBytes(result.AuthKey);
            con = auth.GetConnection();

            Session.ConnectionSession.AuthKey = authKey;
            Session.ConnectionSession.FutureSalts = [FutureSalt.New(result.Salt)];
            Session.ConnectionSession.TimeOffsetSeconds = result.Offset;
        }

        var authorizedConnection = new AuthConnection { ConnectionSession = Session.ConnectionSession };

        _requestManager = new NetworkManager<Intermediate>(authorizedConnection, con);

        await _requestManager.RunAsync(ct);

        //TODO handle updates

        var initConn = await InvokeWithLayerAsync<InitConnection<HelpGetConfig, ConfigBase>, ConfigBase>(new()
        {
            ApiId = Session.ApiId,
            DeviceModel = Session.ClientOptions.DeviceModel,
            SystemVersion = Session.ClientOptions.SystemVersion,
            AppVersion = Session.ClientOptions.AppVersion,
            SystemLangCode = Session.ClientOptions.SystemLangCode,
            LangCode = Session.ClientOptions.LangCode,
            LangPack = Session.ClientOptions.LangPack,
            Query = new()
        });

        if (initConn.IsT1) return initConn.AsT1;

        Session.Config = (Config)initConn.AsT0; //the only possibility

        return true; //might be a "false" case in the future ?
    }
    public Channel<LoginCode> NewAuthChannel() => Channel.CreateBounded<LoginCode>(StaticData.DefaultChannelOptions);
    public async Task<OneOf<Success, ErrorBase>> AuthorizeAsync(ChannelReader<LoginCode> reader)
    {
        if (Session.ClientOptions.IsLocalServer)
            Session.Phone = "9996621234"; //DC 2 with 4 random numbers (1234)

        var attempts = 1;
        //TODO login
        resendCode:
        attempts++;
        var send = await InvokeWithLayerAsync<AuthSendCode, AuthSentCodeBase>(new AuthSendCode
        {
            Settings = new CodeSettings(),
            ApiHash = Session.ApiHash,
            ApiId = Session.ApiId,
            PhoneNumber = Session.Phone
        });

        if (send.TryPickT1(out var sendErr, out var sentCodeBase))
        {
            //TODO handle err
            Console.WriteLine($"{sendErr}");
        }

        if (sentCodeBase is not AuthSentCode sentCode)
            throw new FatalException("AuthSentCodeSuccess is not handled at the moment!");


        var cts = new CancellationTokenSource();
        cts.CancelAfter(TimeSpan.FromSeconds(sentCode.Timeout ?? 300)); //not sure why this would be null, or why 300? idk

        try
        {
            await reader.WaitToReadAsync(cts.Token);
            var code = await reader.ReadAsync(ct);

            var trySignin = await InvokeWithLayerAsync<AuthSignIn, AuthAuthorizationBase>(new AuthSignIn
            {
                PhoneCode = code,
                PhoneNumber = Session.Phone,
                PhoneCodeHash = sentCode.PhoneCodeHash,
            });

            if (trySignin.TryPickT1(out var err, out var signIn))
            {
                switch (err)
                {
                    case RpcError { Msg: RpcErrors.SessionPasswordNeeded }: //2fa is enabled
                        //TODO handle 2FA
                        break;
                    default:
                        return err;
                }
            }

            switch (signIn)
            {
                case AuthAuthorization auth:
                    //TODO handle auth.FutureAuthToken ? maybe?
                    Console.WriteLine($"logged in as {auth.User.Id}.");
                    //TODO complete the login
                    return new Success();
                case AuthAuthorizationSignUpRequired:
                    //Third party libraries no longer have permissions to create new accounts
                    return new LoginError(LoginErrorType.SignupRequired);
            }
        }
        catch (OperationCanceledException)
        {
            //TODO have custom and dynamic policies for retrying
            Console.WriteLine("your code is now invalid, trying again...");
            await Task.Delay(TimeSpan.FromSeconds(1), ct);
            if (attempts <= ts.MaxConnectionRetries)
                goto resendCode;
            return new LoginError(LoginErrorType.Timeout);
        }
        return new Success();
    }
    public Task<OneOf<TRet, ErrorBase>> InvokeWithLayerAsync<TF, TRet>(TF func) where TRet : ITlDeserializable<TRet> where TF : TlFunction<TRet>
        => InvokeAsync(new InvokeWithLayer<TF, TRet>
        {
            Query = func,
            Layer = 172 //TODO handle layers
        });
    private async Task<OneOf<TRet, ErrorBase>> InvokeAsync<TRet>(TlFunction<TRet> func) where TRet : ITlDeserializable<TRet>
    {
        retry:
        var reader = _requestManager.Push(func.TlSerialize().ToArray());
        await reader.WaitToReadAsync(ct);
        var response = await reader.ReadAsync(ct);
        //TODO handle errors
        if (response.TryPickT1(out var err, out var data))
        {
            Console.WriteLine($"err : {err}");
            if (err.Is(TransportErrType.RetryRequest))
            {
                Console.WriteLine("retrying the request");
                if (ct.IsCancellationRequested)
                    return err;
                goto retry; //TODO perhaps there is no need of this
            }

            return err;
        }

        return func.DeserializeResponse(Deserializer.New(data));
    }
    public void Dispose()
    {
        _requestManager.Dispose();
    }
}