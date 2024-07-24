using System.Buffers.Binary;
using System.Collections.Concurrent;
using SharpGram.Core.Common;
using SharpGram.Core.Cryptography;
using SharpGram.Tl.Mtproto;

namespace SharpGram.Core.Mtproto;

//TODO this is not secure
public sealed class ConnectionSession
{
    public AuthKey AuthKey { get; set; } = AuthKey.Empty;
    public long SessionId { get; internal set; } = BinaryPrimitives.ReadInt64LittleEndian(Helpers.GenRandomBytes(8));
    public int TimeOffsetSeconds { get; set; }
    public ConcurrentBag<FutureSalt> FutureSalts { get; set; } = [];
    public int Sequence { get; set; }
    public long LastMsgId { get; set; }
    public ConcurrentBag<long> PendingAcknowledges { get; set; } = [];
    public uint MsgCount { get; set; }
    public long PingId { get; set; }
    public bool IgnoreUpdates { get; set; } = false;

    public bool IsAuthorized() => AuthKey.AuthKeyData.Length != 0;
    public void Reset()
    {
        AuthKey = AuthKey.Empty;
        SessionId = BinaryPrimitives.ReadInt64LittleEndian(Helpers.GenRandomBytes(8));
        TimeOffsetSeconds = 0;
        FutureSalts.Clear();;
        Sequence = 0;
        LastMsgId = 0;
        PendingAcknowledges.Clear();
        MsgCount = 0;
        PingId = 0;
    }
}