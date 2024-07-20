using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using SharpGram.Core.Cryptography;
using SharpGram.Core.Mtproto;
using SharpGram.Tl.Constructors.ConfigNs;
using SharpGram.Tl.Mtproto;

namespace EasyTg.Client;

public sealed class TelegramSession
{
    //json ignore is set bc serializers cant serialize or deserialize complex Enumerable types such as ConcurrentBag which is we are using in Connection session
    //so we are manually converting it from ConnectionSessionPoco to the OG type
    [JsonIgnore]
    public ConnectionSession ConnectionSession { get; private set; } = new();

    public string ApiHash { get; set; } = "";
    public int ApiId { get; set; }
    public string Phone { get; set; } = "-";
    public ushort MaxConnectionRetries { get; set; } = 3;
    public Config Config { get; internal set; } = new() { DcOptions = [], DcTxtDomainName = "", MeUrlPrefix = "" };
    public ClientOptions ClientOptions { get; set; } = new();

    private static readonly JsonTypeInfo<TelegramSession> DefOption = SessionSerializerContext.Default.TelegramSession;
    [JsonInclude, JsonRequired] internal ConnectionSessionPoco ConnSessionPoco = default!;
    public static TelegramSession LoadOrCreate(byte[] sessionData)
    {
        try
        {
            if (sessionData.Length < 100) return new();
            var result = JsonSerializer.Deserialize(sessionData, DefOption) ?? new();
            result.ConnectionSession = result.ConnSessionPoco.Into();
            return result;
        }
        catch
        {
            return new TelegramSession();
        }
    }
    //this should not fail in any way
    public byte[] Save()
    {
        ConnSessionPoco = ConnectionSession.Into();
        return Encoding.UTF8.GetBytes(JsonSerializer.Serialize(this, DefOption));
    }
}

[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(TelegramSession))]
internal partial class SessionSerializerContext : JsonSerializerContext;

internal sealed record ConnectionSessionPoco(
    long SessionId,
    int TimeOffsetSeconds,
    List<FutureSalt> FutureSalts,
    int Sequence,
    long LastMsgId,
    List<long> PendingAcknowledges,
    uint MsgCount,
    long PingId,
    bool IgnoreUpdates,
    AuthKey AuthKey);