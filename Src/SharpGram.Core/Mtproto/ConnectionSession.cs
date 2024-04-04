using System.Buffers.Binary;
using System.Buffers.Text;
using System.Collections.Concurrent;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using SharpGram.Core.Common;
using SharpGram.Core.Cryptography;
using SharpGram.Tl.Mtproto;

namespace SharpGram.Core.Mtproto;

//TODO this is not secure
public sealed class ConnectionSession
{
    private static readonly JsonTypeInfo<ConnectionSession> DefOption = SessionSerializerContext.Default.ConnectionSession;

    public AuthKey AuthKey { get; set; } = AuthKey.Empty;
    public long SessionId { get; init; } = BinaryPrimitives.ReadInt64LittleEndian(Helpers.GenRandomBytes(8));
    public int TimeOffsetSeconds { get; set; }
    public ConcurrentBag<FutureSalt> FutureSalts { get; set; } = [];
    public int Sequence { get; set; }
    public long LastMsgId { get; set; }
    public ConcurrentBag<long> PendingAcknowledges = [];
    public uint MsgCount { get; set; }
    public long PingId { get; set; }
    public bool IgnoreUpdates { get; set; } = false;
    private ConnectionSession() { }
    public byte[] Save() => Encoding.UTF8.GetBytes(Convert.ToBase64String(Encoding.UTF8.GetBytes(JsonSerializer.Serialize(this, DefOption))));
    public bool IsAuthorized() => AuthKey.AuthKeyData.Length != 0;
    public static ConnectionSession LoadOrCreate(byte[]? data = null)
    {
        try
        {
            if (data is null) return new();
            var bs = Convert.FromBase64String(Encoding.UTF8.GetString(data));
            return Deserialize(bs) ?? new();
        }
        catch (Exception)
        {
            return new();
        }
    }
    private static ConnectionSession? Deserialize(byte[] d)
    {
        try
        {
            return JsonSerializer.Deserialize(Encoding.UTF8.GetString(d), DefOption);
        }
        catch
        {
            return null;
        }
    }
}

[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(ConnectionSession))]
internal partial class SessionSerializerContext : JsonSerializerContext;