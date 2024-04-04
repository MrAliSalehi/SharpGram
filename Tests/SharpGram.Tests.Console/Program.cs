
using EasyTg.Client;
using Newtonsoft.Json.Linq;


var secrets = (dynamic)JObject.Parse(await File.ReadAllTextAsync("devSecrets.json"));
var apiId = int.Parse((string)secrets.api_id);

var cts = new CancellationTokenSource();

//var session = ConnectionSession.LoadOrCreate([]);

/*
var auth = (await Authentication.NewAsync(6)).AsT0;

var result = await auth.AuthorizeAsync();
var authKey = AuthKey.FromBytes(result.AuthKey);
var con = auth.GetConnection();

session.AuthKey = authKey;
session.FutureSalts = [FutureSalt.New(result.Salt)];
session.TimeOffsetSeconds = result.Offset;
//await session.SaveAsync();

var enc = new AuthConnection { ConnectionSession = session };

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
*/

var tlSession = TelegramSession.New("", apiId);
tlSession.ClientOptions.IsLocalServer = true;

var client = new TelegramClient(tlSession, cts.Token);

var result = await client.ConnectAsync();

if (result.TryPickT1(out var err, out _))
{
    Console.WriteLine($"err while trying to connect {err}");
}

var conf = client.Session.Config;

Console.ReadKey();
await cts.CancelAsync();
return;

/*
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
            continue;#1#

        return err;
    }
    return func.DeserializeResponse(Deserializer.New(data));
}

Task<OneOf<TRet, ErrorBase>> InvokeWithLayer<TF, TRet>(TF func) where TRet : ITlDeserializable<TRet> where TF : TlFunction<TRet>
    => InvokeAsync(new InvokeWithLayer<TF, TRet>
    {
        Query = func,
        Layer = 172
    });*/