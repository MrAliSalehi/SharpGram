using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OneOf;
using SharpGram.Core.Auth;
using SharpGram.Core.Contracts;
using SharpGram.Core.Conversions;
using SharpGram.Core.Cryptography;
using SharpGram.Core.Models.Errors;
using SharpGram.Core.Mtproto;
using SharpGram.Core.Mtproto.Connections;
using Tel = SharpGram.Tl;
using SharpGram.Core.Mtproto.Transport;
using SharpGram.Core.Network;
using SharpGram.Tl.Functions.Help;
using SharpGram.Tl.Mtproto;
using SharpGram.Tl.Types;

var secrets = (dynamic)JObject.Parse(await File.ReadAllTextAsync("devSecrets.json"));
var cts = new CancellationTokenSource();
var session = await Session.LoadOrCreateAsync();
using var auth = (await Authentication.NewAsync(6)).AsT0;

var result = await auth.AuthorizeAsync();
var authKey = AuthKey.FromBytes(result.AuthKey);
var con = auth.GetConnection();

session.AuthKey = authKey;
session.FutureSalts = [FutureSalt.New(result.Salt)];
session.TimeOffsetSeconds = result.Offset;
//await session.SaveAsync();
var getConfig = new Tel.Functions.Help.HelpGetConfig();
var request = getConfig.TlSerialize().ToList();

var enc = new AuthConnection { Session = session };

using var requestManager = new NetworkManager<Intermediate>(enc, con);
await requestManager.RunAsync(cts.Token);

requestManager.UpdateEvent += async (sender, ofs) =>
{
    await Task.Delay(TimeSpan.FromSeconds(10));
    Console.WriteLine("process finished");
};

var _config = await InvokeAsync(new InvokeWithLayer<InitConnection<HelpGetConfig, ConfigBase>, ConfigBase>
{
    Layer = 172,
    Query = new InitConnection<HelpGetConfig, ConfigBase>
    {
        ApiId = secrets.api_id,
        DeviceModel = "pc",
        SystemVersion = "1",
        AppVersion = "1",
        SystemLangCode = "en",
        LangCode = "en",
        LangPack = "",
        Query = new HelpGetConfig()
    }
});

var config = await InvokeAsync(new InvokeWithLayer<HelpGetConfig, ConfigBase>
{
    Layer = 172,
    Query = new HelpGetConfig(),
});

var config2 = await InvokeWithLayer<HelpGetConfig, ConfigBase>(new HelpGetConfig());

Console.WriteLine($"success : {_config.IsT0 && config2.IsT0}");

Console.ReadKey();
await cts.CancelAsync();
return;

async Task<OneOf<TRet, ErrorBase>> InvokeAsync<TRet>(TlFunction<TRet> func) where TRet : ITlDeserializable<TRet>
{
    retry:
    var reader = requestManager.Push(func.TlSerialize().ToArray());
    await reader.WaitToReadAsync(cts.Token);
    var response = await reader.ReadAsync(cts.Token);
    if (response.TryPickT1(out var err, out var data))
    {
        Console.WriteLine($"err : {err}");
        if (err.Is(TransportErrType.RetryRequest))
        {
            Console.WriteLine("retrying the request");
            goto retry;
        }

        /*if (err.Is(TransportErrType.AckWithoutResult))
            continue;*/

        return err;
    }
    return func.DeserializeResponse(Deserializer.New(data));
}

Task<OneOf<TRet, ErrorBase>> InvokeWithLayer<TF, TRet>(TF func) where TRet : ITlDeserializable<TRet> where TF : TlFunction<TRet>
    => InvokeAsync(new InvokeWithLayer<TF, TRet>
    {
        Query = func,
        Layer = 172
    });