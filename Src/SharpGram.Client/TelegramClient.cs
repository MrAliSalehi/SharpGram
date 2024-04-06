using OneOf;
using SharpGram.Core.Contracts;
using SharpGram.Core.Conversions;
using SharpGram.Core.Cryptography;
using SharpGram.Core.Models.Errors;
using SharpGram.Core.Mtproto.Connections;
using SharpGram.Core.Mtproto.Transport;
using SharpGram.Core.Network;
using SharpGram.Tl.Constructors.ConfigNs;
using SharpGram.Tl.Functions.Help;
using SharpGram.Tl.Mtproto;
using SharpGram.Tl.Types;

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