using SharpGram.Core.Mtproto;

namespace EasyTg.Client;

internal static class Extensions
{
    //this is stupid
    public static ConnectionSession Into(this ConnectionSessionPoco p) => new()
    {
        AuthKey = p.AuthKey,
        FutureSalts = new(p.FutureSalts),
        MsgCount = p.MsgCount,
        IgnoreUpdates = p.IgnoreUpdates,
        PendingAcknowledges = new(p.PendingAcknowledges),
        SessionId = p.SessionId,
        LastMsgId = p.LastMsgId,
        TimeOffsetSeconds = p.TimeOffsetSeconds,
        PingId = p.PingId,
        Sequence = p.Sequence
    };
    public static ConnectionSessionPoco Into(this ConnectionSession p) => new(
        p.SessionId,
        p.TimeOffsetSeconds,
        p.FutureSalts.ToList(),
        p.Sequence,
        p.LastMsgId,
        p.PendingAcknowledges.ToList(),
        p.MsgCount,
        p.PingId,
        p.IgnoreUpdates,
        p.AuthKey
    );
}