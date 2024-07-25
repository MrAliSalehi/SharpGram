using Newtonsoft.Json.Linq;
using SharpGram.Client;

var cts = new CancellationTokenSource();
var secrets = (dynamic)JObject.Parse(await File.ReadAllTextAsync("devSecrets.json"));
var apiId = int.Parse((string)secrets.api_id);
var apiHash = (string)secrets.api_hash;
var phone = (string)secrets.phone;
var tfa = (string)secrets.two_factor;
byte[] d = [];
if (File.Exists("testSession"))
    d = await File.ReadAllBytesAsync("testSession");


var tlSession = TelegramSession.LoadOrCreate(d);
tlSession.ClientOptions.IsLocalServer = false;
tlSession.ClientOptions.IsTest = true;
tlSession.ConnectionSession.IgnoreUpdates = true;

tlSession.ApiId = apiId;
tlSession.ApiHash = apiHash;
tlSession.Phone = phone;
tlSession.TwoFactorPassword = tfa;
var client = new TelegramClient(tlSession, cts.Token);
var result = await client.ConnectAsync();
if (result.TryPickT1(out var err, out _))
{
    Console.WriteLine($"err while trying to connect {err}");
    return;
}

if (client.IsAuthorized(out var writer))
{
    Console.WriteLine("we are authorized");
    return;
}


Task.Run(async () =>
{
    Console.WriteLine("enter the code whenever you received it:");
    var code = Console.ReadLine()!;
    await writer.WriteAsync(code);
});

var authResult = await client.AuthorizeAsync();
if (authResult.TryPickT1(out var authErr, out _))
{
    Console.WriteLine($"err on auth: {authErr}");
    return;
}

Console.WriteLine("press any key");
Console.ReadKey();

var data = client.Session.Save();

await File.WriteAllBytesAsync("testSession", data);

await cts.CancelAsync();
cts.Dispose();