
using EasyTg.Client;
using Newtonsoft.Json.Linq;
using SharpGram.Tl.Constructors.DcOptionNs;

var cts = new CancellationTokenSource();
var secrets = (dynamic)JObject.Parse(await File.ReadAllTextAsync("devSecrets.json"));
var apiId = int.Parse((string)secrets.api_id);

byte[] d = [];
if (File.Exists("testSession"))
 d = await File.ReadAllBytesAsync("testSession");


var tlSession = TelegramSession.LoadOrCreate(d);
tlSession.ClientOptions.IsLocalServer = true;
tlSession.ApiId = apiId;

var client = new TelegramClient(tlSession, cts.Token);

var result = await client.ConnectAsync();

if (result.TryPickT1(out var err, out _))
{
    Console.WriteLine($"err while trying to connect {err}");
}

var conf = client.Session.Config;

Console.WriteLine($"ready: {((DcOption)conf.DcOptions[0]).IpAddress}");
Console.ReadKey();

var data = client.Session.Save();

await File.WriteAllBytesAsync("testSession",data);

await cts.CancelAsync();
cts.Dispose();