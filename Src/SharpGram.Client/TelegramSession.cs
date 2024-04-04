using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using SharpGram.Core.Mtproto;
using SharpGram.Tl.Constructors.ConfigNs;

namespace EasyTg.Client;

public sealed class TelegramSession
{
    internal ConnectionSession ConnectionSession { get; set; }
    public string ApiHash { get; init; }
    public int ApiId { get; init; }
    public Config Config { get; internal set; } = new();
    public ClientOptions ClientOptions { get; set; } = new();

    private static readonly JsonTypeInfo<TelegramSession> DefOption = TelegramSessionSerializerContext.Default.TelegramSession;
    private TelegramSession(string apiHash, int apiId, ConnectionSession cs)
    {
        ApiHash = apiHash;
        ApiId = apiId;
        ConnectionSession = cs;
    }

    public static TelegramSession? LoadUnsafe(byte[] sessionData) => JsonSerializer.Deserialize(sessionData, DefOption);


    public static TelegramSession New(string apiHash, int apiId) => new(apiHash, apiId, ConnectionSession.LoadOrCreate());
}

[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(TelegramSession))]
internal partial class TelegramSessionSerializerContext : JsonSerializerContext;