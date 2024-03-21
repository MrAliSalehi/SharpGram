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

//todo save in file is hard coded here
//TODO this is not secure
public sealed class Session
{
    private static readonly JsonTypeInfo<Session> DefOption = SessionSerializerContext.Default.Session;
    private static readonly string SessionPath = Path.Combine(Environment.CurrentDirectory, "SgSession.txt");

    public AuthKey AuthKey { get; set; } = AuthKey.Empty;
    public long SessionId { get; init; } = BinaryPrimitives.ReadInt64LittleEndian(Helpers.GenRandomBytes(8));
    public int TimeOffsetSeconds { get; set; }
    public ConcurrentBag<FutureSalt> FutureSalts { get; set; } = [];
    public int Sequence { get; set; }
    public long LastMsgId { get; set; }
    public ConcurrentBag<long> PendingAcknowledges = [];
    public uint MsgCount { get; set; }
    public long PingId { get; set; }
    public Task SaveAsync()
    {
        var data = Convert.ToBase64String(Encoding.UTF8.GetBytes(JsonSerializer.Serialize(this, DefOption)));
        return File.WriteAllTextAsync(SessionPath, data);
    }
    public static async Task<Session> LoadOrCreateAsync()
    {
        if (!File.Exists(SessionPath))
        {
            var s = new Session();
            await s.SaveAsync();
            return s;
        }

        var txt = await File.ReadAllTextAsync(SessionPath);
        return Deserialize(Convert.FromBase64String(txt)) ?? new();
    }
    private static Session? Deserialize(byte[] d)
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
[JsonSerializable(typeof(Session))]
internal partial class SessionSerializerContext : JsonSerializerContext;