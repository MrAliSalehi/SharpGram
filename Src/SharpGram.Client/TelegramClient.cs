using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Channels;
using OneOf;
using OneOf.Types;
using SharpGram.Client.Models;
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
using SharpGram.Tl.Constructors.DcOptionNs;
using SharpGram.Tl.Constructors.InputUserNs;
using SharpGram.Tl.Constructors.UserNs;
using SharpGram.Tl.Functions.Account;
using SharpGram.Tl.Functions.Auth;
using SharpGram.Tl.Functions.Help;
using SharpGram.Tl.Functions.Users;
using SharpGram.Tl.Mtproto;
using SharpGram.Tl.Types;
using RpcError = SharpGram.Core.Models.Errors.RpcError;

namespace SharpGram.Client;

//TODO proper logging
//TODO handle updates

public sealed class TelegramClient(TelegramSession ts, CancellationToken ct = default) : IDisposable
{
    public TelegramSession Session { get; } = ts;
    private NetworkManager<Intermediate> _requestManager = default!;
    private ChannelReader<LoginCode>? _codeReader;

    public async Task<OneOf<Success, ErrorBase>> ConnectAsync()
    {
        var tryCreateAuthKey = await CreateAuthKeyAsync();
        if (tryCreateAuthKey.TryPickT1(out var ea, out var con))
            return ea;

        _requestManager = new NetworkManager<Intermediate>(con);

        await _requestManager.RunAsync(ct);
        await _requestManager.GetSaltsAsync(ct);
        if (Session.User is not null)
            return StaticData.Success;

        //first time
        var initConn = await InvokeAsync(new InvokeWithLayer<ConfigBase>
        {
            Query = new InitConnection<ConfigBase>
            {
                ApiId = Session.ApiId,
                DeviceModel = Session.ClientOptions.DeviceModel,
                SystemVersion = Session.ClientOptions.SystemVersion,
                AppVersion = Session.ClientOptions.AppVersion,
                SystemLangCode = Session.ClientOptions.SystemLangCode,
                LangCode = Session.ClientOptions.LangCode,
                LangPack = Session.ClientOptions.LangPack,
                Query = new HelpGetConfig()
            }
        });

        if (initConn.TryPickT1(out var er, out var init))
            return er;

        Session.Config = (Config)init; //the only possibility

        var tryGetMe = await InvokeAsync(new UsersGetUsers { Id = [new InputUserSelf()] });
        if (tryGetMe.TryPickT0(out var me, out _))
            Session.User = me.InnerList.OfType<User>().First();


        return StaticData.Success;
    }

    public bool IsAuthorized([MaybeNullWhen(true)] out ChannelWriter<LoginCode> writer)
    {
        if (Session.User is null)
        {
            var channel = Channel.CreateBounded<LoginCode>(StaticData.DefaultChannelOptions);
            _codeReader = channel.Reader;
            writer = channel.Writer;
            return false;
        }

        writer = null;
        return true;
    }
    public async Task<OneOf<Success, ErrorBase>> AuthorizeAsync(bool force = false)
    {
        if (Session.User != null && !force) return new LoginError(LoginErrorType.UserAlreadyLoggedIn);
        var isTestEnv = Session.ClientOptions.IsLocalServer || Session.ClientOptions.IsTest;
        if (isTestEnv)
            Session.Phone = "999662" + Random.Shared.Next(1000, 9999); //99966 + DC 2 + 4 random numbers

        var attempts = 1;
        resendCode:
        attempts++;


        var send = await InvokeAsync(new AuthSendCode
        {
            Settings = new CodeSettings
            {
                AllowFlashcall = false, AllowFirebase = false, AllowAppHash = false, AppSandbox = false, AllowMissedCall = false, CurrentNumber = true,
                UnknownNumber = false
            },
            ApiHash = Session.ApiHash,
            ApiId = Session.ApiId,
            PhoneNumber = Session.Phone
        });

        if (send.TryPickT1(out var sendErr, out var sentCodeBase))
        {
            //TODO handle err
            Console.WriteLine($"{sendErr}");
            return sendErr;
        }

        if (sentCodeBase is not AuthSentCode sentCode)
            throw new FatalException("AuthSentCodeSuccess is not handled at the moment!");


        var cts = new CancellationTokenSource();
        cts.CancelAfter(TimeSpan.FromSeconds(sentCode.Timeout is null or 0 ? 300 : sentCode.Timeout.Value)); //not sure why this would be null, or why 300? IDK

        try
        {
            if (_codeReader is null)
                return new LoginError(LoginErrorType.ChannelIsNotCreated);

            var code = LoginCode.TestCode;
            if (!isTestEnv) // if this is not test env ask the user for code
            {
                await _codeReader.WaitToReadAsync(cts.Token);
                code = await _codeReader.ReadAsync(ct);
            }

            var trySignin = await InvokeAsync(new AuthSignIn
            {
                PhoneCode = code,
                PhoneNumber = Session.Phone,
                PhoneCodeHash = sentCode.PhoneCodeHash,
            });

            if (trySignin.TryPickT1(out var err, out var signIn))
            {
                switch (err)
                {
                    case RpcError { Msg: RpcErrorTypes.SessionPasswordNeeded }: //2fa is enabled
                        if (Session.TwoFactorPassword is null)
                            return new LoginError(LoginErrorType.TwoFactorPasswordMissing);

                        await Task.Delay(TimeSpan.FromSeconds(1), cts.Token);


                        var tryToken = await InvokeAsync(new AccountGetPassword());
                        if (tryToken.TryPickT1(out var e, out var token))
                            return e;

                        var trySrp = PasswordAuth.GenerateSrp(token, Encoding.UTF8.GetBytes(Session.TwoFactorPassword));
                        if (trySrp.TryPickT1(out var srpErr, out var srp))
                            return srpErr;

                        var tryCheckPwd = await InvokeAsync(new AuthCheckPassword { Password = srp });
                        if (tryCheckPwd.TryPickT1(out var checkErr, out var authBase))
                            return checkErr;

                        if (authBase is AuthAuthorizationSignUpRequired)
                            return new LoginError(LoginErrorType.SignupRequired);

                        //safe to hard cast since it's the only constructor
                        Session.User = (User)((AuthAuthorization)authBase).User;
                        Console.WriteLine($"logged in as ({Session.User.Id})[{Session.User.Phone}].");
                        return StaticData.Success;
                    default:
                        return err;
                }
            }

            switch (signIn)
            {
                case AuthAuthorization auth:
                    //TODO handle auth.FutureAuthToken ? maybe?
                    Session.User = (User)auth.User;
                    Console.WriteLine($"logged in as ({Session.User.Id})[{Session.User.Phone}].");
                    return StaticData.Success;
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
            if (attempts <= Session.MaxConnectionRetries)
                goto resendCode;
            return new LoginError(LoginErrorType.Timeout);
        }


        return StaticData.Success;
    }
    public async Task<OneOf<TRet, ErrorBase>> InvokeAsync<TRet>(TlFunction<TRet> request) where TRet : ITlDeserializable<TRet>
    {
        var func = request;

        if (Session.ConnectionSession.IgnoreUpdates && request is not InvokeWithLayer<TRet>)
            func = new InvokeWithoutUpdates<TRet> { Query = request };

        //TODO reconnection policy
        retry:

        var reader = _requestManager.Push(func.TlSerialize().ToArray());

        var cts = new CancellationTokenSource();
        cts.CancelAfter(TimeSpan.FromSeconds(5));
        try
        {
            await reader.WaitToReadAsync(cts.Token);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine($"timeout for request with response of [{typeof(TRet)}]");
            return ConnectionError.New(ConnectionErrType.Timeout);
        }

        var response = await reader.ReadAsync(ct);

        if (response.TryPickT0(out var data, out var err))
            return func.DeserializeResponse(Deserializer.New(data));

        Console.WriteLine($"err : {err}");

        //TODO handle errors
        if (err.Is(TransportErrType.RetryRequest))
        {
            Console.WriteLine("retrying the request");
            if (ct.IsCancellationRequested)
                return err;
            goto retry; //TODO perhaps there is no need of this
        }

        if (err.Is(RpcErrorTypes.Migrate))
        {
            Console.WriteLine("migration requested...changing the dc");
            var rpcErr = (RpcError)err;
            var dcToMigrate = rpcErr.Value;
            if (Session.Config.ThisDc == dcToMigrate)
                throw new FatalException("the requested dc and currentDc are the same, this should not happen");
            var targetDc = Session.Config.DcOptions.OfType<DcOption>().FirstOrDefault(p => p.Id == dcToMigrate && !p.Ipv6);
            Session.ConnectionSession.Reset();
            Session.CurrentDc = targetDc;

            _requestManager.Dispose();

            await ConnectAsync();

            goto retry;
        }

        return err;
    }
    private async ValueTask<OneOf<TcpConnection<AuthConnection, Intermediate>, ErrorBase>> CreateAuthKeyAsync()
    {
        var dc = Session.GetDc();
        TcpConnection<AuthConnection, Intermediate> con;
        var authConnection = new AuthConnection { ConnectionSession = Session.ConnectionSession };
        if (Session.ConnectionSession.IsAuthorized())
        {
            var tryConnect = TcpConnection<AuthConnection, Intermediate>.New<AuthConnection, Intermediate>(dc, conn: authConnection);
            if (tryConnect.TryPickT1(out var e, out con))
                return e;
        }
        else
        {
            var tryAuth = await Authentication.NewAsync(dc);

            if (tryAuth.TryPickT1(out var e, out var auth))
                return e;

            var result = await auth.AuthorizeAsync();
            var authKey = AuthKey.FromBytes(result.AuthKey);
            var unAuthCon = auth.GetConnection();
            con = unAuthCon.IntoAuthenticated(authConnection, dc);
            Session.ConnectionSession.AuthKey = authKey;
            Session.ConnectionSession.FutureSalts = [FutureSalt.New(result.Salt)];
            Session.ConnectionSession.TimeOffsetSeconds = result.Offset;
        }

        return con;
    }

    public void Dispose()
    {
        _requestManager.Dispose();
    }
}