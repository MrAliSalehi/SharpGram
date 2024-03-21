// warning
// this file should not be modified or be replaced by any other auto generated code
// because it was manually modified to *NOT* call `.TlSerialize()` on some properties.


using System.Buffers.Binary;
using System.IO.Compression;
using System.Text;
using Int256 = SharpGram.Core.Models.Types.Int256;
using Int128 = SharpGram.Core.Models.Types.Int128;
using SharpGram.Core.Conversions;
using SharpGram.Core.Contracts;

// ReSharper disable IdentifierTypo PartialTypeWithSinglePart InconsistentNaming CheckNamespace MemberCanBePrivate.Global ClassNeverInstantiated.Global PropertyCanBeMadeInitOnly.Global UnusedAutoPropertyAccessor.Global CollectionNeverUpdated.Global AutoPropertyCanBeMadeGetOnly.Global

namespace SharpGram.Tl.Mtproto;

public abstract partial class ResPQBase;

public sealed partial class ResPq : ResPQBase, ITlSerializable
{
    public static readonly byte[] Identifier = [99, 36, 22, 5,];
    public Int128 Nonce { get; set; } = default!;
    public Int128 ServerNonce { get; set; } = default!;
    public byte[] Pq { get; set; } = default!;
    public List<long> ServerPublicKeyFingerprints { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(Nonce.TlSerialize());
        bytes.AddRange(ServerNonce.TlSerialize());
        bytes.AddRange(Pq);
        bytes.AddRange(ServerPublicKeyFingerprints.TlSerialize());
        return bytes.ToArray();
    }
}

public abstract partial class ServerDhParamsBase;

public sealed partial class ServerDhParamsOk : ServerDhParamsBase, ITlSerializable
{
    public static readonly byte[] Identifier = [92, 7, 232, 208,];
    public Int128 Nonce { get; set; } = default!;
    public Int128 ServerNonce { get; set; } = default!;
    public byte[] EncryptedAnswer { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(Nonce.TlSerialize());
        bytes.AddRange(ServerNonce.TlSerialize());
        bytes.AddRange(EncryptedAnswer);
        return bytes.ToArray();
    }
}

public abstract partial class ServerDhInnerDataBase;

public sealed partial class ServerDhInnerData : ServerDhInnerDataBase, ITlSerializable
{
    public static readonly byte[] Identifier = [186, 13, 137, 181,];
    public Int128 Nonce { get; set; } = default!;
    public Int128 ServerNonce { get; set; } = default!;
    public int G { get; set; } = default!;
    public byte[] DhPrime { get; set; } = default!;
    public byte[] Ga { get; set; } = default!;
    public int ServerTime { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(Nonce.TlSerialize());
        bytes.AddRange(ServerNonce.TlSerialize());
        bytes.AddRange(G.TlSerialize());
        bytes.AddRange(DhPrime);
        bytes.AddRange(Ga);
        bytes.AddRange(ServerTime.TlSerialize());
        return bytes.ToArray();
    }
}

public abstract partial class ClientDhInnerDataBase;

public sealed partial class ClientDhInnerData : ClientDhInnerDataBase, ITlSerializable
{
    public static readonly byte[] Identifier = [84, 182, 67, 102,];
    public Int128 Nonce { get; set; } = default!;
    public Int128 ServerNonce { get; set; } = default!;
    public long RetryId { get; set; } = default!;
    public byte[] Gb { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(Nonce.TlSerialize());
        bytes.AddRange(ServerNonce.TlSerialize());
        bytes.AddRange(RetryId.TlSerialize());
        bytes.AddRange(Gb);
        return bytes.ToArray();
    }
}

public abstract partial class BindAuthKeyInnerBase;

public sealed partial class BindAuthKeyInner : BindAuthKeyInnerBase, ITlSerializable
{
    public static readonly byte[] Identifier = [101, 247, 163, 117,];
    public long Nonce { get; set; } = default!;
    public long TempAuthKeyId { get; set; } = default!;
    public long PermAuthKeyId { get; set; } = default!;
    public long TempSessionId { get; set; } = default!;
    public int ExpiresAt { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(Nonce.TlSerialize());
        bytes.AddRange(TempAuthKeyId.TlSerialize());
        bytes.AddRange(PermAuthKeyId.TlSerialize());
        bytes.AddRange(TempSessionId.TlSerialize());
        bytes.AddRange(ExpiresAt.TlSerialize());
        return bytes.ToArray();
    }
}

public abstract partial class RpcResultBase;

public sealed partial class RpcResult<T> : RpcResultBase, ITlSerializable where T : ITlDeserializable<T>
{
    public static readonly byte[] Identifier = [1, 109, 92, 243,];
    public long ReqMsgId { get; set; } = default!;
    public T Result { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(ReqMsgId.TlSerialize());
        bytes.AddRange(Result.TlSerialize());
        return bytes.ToArray();
    }
    public static RpcResult<T> TlDeserialize(Deserializer deserializer)
    {
        var id = deserializer.ReadId();
        ArgumentOutOfRangeException.ThrowIfNotEqual(id.SequenceEqual(Identifier), true);
        var reqId = deserializer.As<long>().Read();
        var result = T.TlDeserialize(deserializer);

        return new RpcResult<T>
        {
            ReqMsgId = reqId,
            Result = result
        };
    }
}

public abstract partial class RpcErrorBase;

public sealed partial class RpcError : RpcErrorBase, ITlSerializable
{
    public static readonly byte[] Identifier = [25, 202, 68, 33,];
    public int ErrorCode { get; set; } = default!;
    public string ErrorMessage { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(ErrorCode.TlSerialize());
        bytes.AddRange(ErrorMessage.TlSerialize());
        return bytes.ToArray();
    }
}

public abstract partial class FutureSaltBase;

public sealed partial class FutureSalt : FutureSaltBase, ITlSerializable, ITlDeserializable<FutureSalt>
{
    public static readonly byte[] Identifier = [220, 217, 73, 9,];
    public int ValidSince { get; set; } = default!;
    public int ValidUntil { get; set; } = default!;
    public long Salt { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(ValidSince.TlSerialize());
        bytes.AddRange(ValidUntil.TlSerialize());
        bytes.AddRange(Salt.TlSerialize());
        return bytes.ToArray();
    }
    public override string ToString() => Salt.ToString();
    public static FutureSalt New(long salt) => new() { Salt = salt, ValidUntil = int.MaxValue, ValidSince = 0 };
    public static FutureSalt TlDeserialize(Deserializer des)
    {
        var i = des.As<int>();
        var vSinse = i.Read();
        var vUntil = i.Read();
        var salt = des.As<long>().Read();
        return new() { ValidSince = vSinse, ValidUntil = vUntil, Salt = salt };
    }
}

public abstract partial class FutureSaltsBase;

public sealed partial class FutureSalts : FutureSaltsBase, ITlSerializable, ITlDeserializable<FutureSalts>
{
    public static readonly byte[] Identifier = [149, 8, 80, 174,];
    public long ReqMsgId { get; set; } = default!;
    public int Now { get; set; } = default!;
    public List<FutureSalt> Salts { get; set; } = default!;
    public override string ToString() => Salts.Aggregate("", (c, x) => c + $"{x},");
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(ReqMsgId.TlSerialize());
        bytes.AddRange(Now.TlSerialize());
        bytes.AddRange(Salts.TlSerialize());
        return bytes.ToArray();
    }
    public static FutureSalts TlDeserialize(Deserializer des)
    {
        ArgumentOutOfRangeException.ThrowIfNotEqual(des.IsCorrectId(Identifier), true);
        var reqMsgId = des.As<long>().Read();
        var intRead = des.As<int>();
        var now = intRead.Read();

        var len = intRead.Read();
        var salts = new FutureSalt[len];
        for (var i = 0; i < len; i++)
            salts[i] = des.ReadObject<FutureSalt>();
        return new FutureSalts { Salts = salts.ToList(), Now = now, ReqMsgId = reqMsgId };
    }
}

public abstract partial class PongBase;

public sealed partial class Pong : PongBase, ITlSerializable
{
    public static readonly byte[] Identifier = [197, 115, 119, 52,];
    public long MsgId { get; set; } = default!;
    public long PingId { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(MsgId.TlSerialize());
        bytes.AddRange(PingId.TlSerialize());
        return bytes.ToArray();
    }
    public static Pong TlDeserialize(byte[] data)
    {
        ArgumentOutOfRangeException.ThrowIfNotEqual(data[..4].SequenceEqual(Identifier), true);

        var d= data.AsSpan();
        var msgId = BinaryPrimitives.ReadInt64LittleEndian(d[4..12]);
        var pingId = BinaryPrimitives.ReadInt64LittleEndian(d[12..]);
        return new() { MsgId = msgId, PingId = pingId };
    }
}

public abstract partial class NewSessionBase;

public sealed partial class NewSessionCreated : NewSessionBase, ITlSerializable
{
    public static readonly byte[] Identifier = [8, 9, 194, 158,];
    public long FirstMsgId { get; set; } = default!;
    public long UniqueId { get; set; } = default!;
    public long ServerSalt { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(FirstMsgId.TlSerialize());
        bytes.AddRange(UniqueId.TlSerialize());
        bytes.AddRange(ServerSalt.TlSerialize());
        return bytes.ToArray();
    }
    public static NewSessionCreated TlDeserialize(Deserializer des)
    {
        ArgumentOutOfRangeException.ThrowIfNotEqual(des.IsCorrectId(Identifier), true);
        var reader = des.As<long>();

        var f = reader.Read();
        var u = reader.Read();
        var s = reader.Read();
        return new NewSessionCreated { FirstMsgId = f, UniqueId = u, ServerSalt = s };
    }
}

public abstract partial class MessageContainerBase;

public sealed partial class MsgContainer : MessageContainerBase, ITlSerializable
{
    public static readonly byte[] Identifier = [220, 248, 241, 115,];
    public List<Message> Messages { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(Messages.TlSerialize());
        return bytes.ToArray();
    }
    public static Message[] TlDeserialize(Deserializer des)
    {
        ArgumentOutOfRangeException.ThrowIfNotEqual(des.IsCorrectId(Identifier), true);

        var len = des.As<int>().Read();
        var messages = new Message[len];
        for (var i = 0; i < len; i++)
            messages[i] = Message.TlDeserialize(des);
        return messages;
    }
}

public abstract partial class MessageBase;

public sealed partial class Message : MessageBase, ITlSerializable, ITlDeserializable<Message>
{
    public static readonly byte[] Identifier = [17, 229, 184, 91,];
    public long MsgId { get; set; } = default!;
    public int Seqno { get; set; } = default!;

    /// called "Bytes" in tl schema
    public int Len { get; set; } = default!;

    public byte[] Body { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(MsgId.TlSerialize());
        bytes.AddRange(Seqno.TlSerialize());
        bytes.AddRange(Len.TlSerialize());
        bytes.AddRange(Body);
        return bytes.ToArray();
    }
    public static Message TlDeserialize(Deserializer des)
    {
        //it does not come with constructor id
        //ArgumentOutOfRangeException.ThrowIfNotEqual(des.IsCorrectId(Identifier), true);
        var msgId = des.As<long>().Read();
        var seq = des.As<int>().Read();
        var len = des.As<int>().Read();
        ArgumentOutOfRangeException.ThrowIfGreaterThan(len, 1024); //max msg size
        var body = new byte[len];
        des.Read(body);
        return new() { MsgId = msgId, Seqno = seq, Len = len, Body = body };
    }
}

public abstract partial class MessageCopyBase;

public sealed partial class MsgCopy : MessageCopyBase, ITlSerializable
{
    public static readonly byte[] Identifier = [178, 70, 96, 224,];
    public MessageBase OrigMessage { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(OrigMessage.TlSerialize());
        return bytes.ToArray();
    }
}

public abstract partial class objectBase;

public sealed partial class GzipPacked : objectBase, ITlSerializable
{
    public static readonly byte[] Identifier = [161, 207, 114, 48,];
    public byte[] PackedData { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(PackedData.TlSerialize());
        return bytes.ToArray();
    }
    public static byte[] Decompress(Deserializer des)
    {
        ArgumentOutOfRangeException.ThrowIfNotEqual(des.IsCorrectId(Identifier), true);
        using var mem = new MemoryStream(des.As<byte[]>().Read());
        using var s = new GZipStream(mem, CompressionMode.Decompress);
        using var to = new MemoryStream();
        s.CopyTo(to);
        return to.ToArray();
    }
}

public abstract partial class MessagesAckBase;

public sealed partial class MsgsAck : MessagesAckBase, ITlSerializable
{
    public static readonly byte[] Identifier = [89, 180, 214, 98,];
    public List<long> MsgIds { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(MsgIds.TlSerialize());
        return bytes.ToArray();
    }
    public static MsgsAck TlDeserialize(Deserializer des)
    {
        ArgumentOutOfRangeException.ThrowIfNotEqual(des.IsCorrectId(Identifier), true);
        var ids = des.ReadNumbers<long>();
        return new() { MsgIds = ids };
    }
    public override string ToString() => MsgIds.Aggregate("", (c, x) => c + $"{x},");
}

public abstract partial class MessageResendReqBase;

public sealed partial class MsgResendReq : MessageResendReqBase, ITlSerializable
{
    public static readonly byte[] Identifier = [8, 26, 134, 125,];
    public List<long> MsgIds { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(MsgIds.TlSerialize());
        return bytes.ToArray();
    }
}

public abstract partial class MessagesStateReqBase;

public sealed partial class MsgsStateReq : MessagesStateReqBase, ITlSerializable
{
    public static readonly byte[] Identifier = [82, 251, 105, 218,];
    public List<long> MsgIds { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(MsgIds.TlSerialize());
        return bytes.ToArray();
    }
}

public abstract partial class MessagesStateInfoBase;

public sealed partial class MsgsStateInfo : MessagesStateInfoBase, ITlSerializable
{
    public static readonly byte[] Identifier = [125, 181, 222, 4,];
    public long ReqMsgId { get; set; } = default!;
    public byte[] Info { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(ReqMsgId.TlSerialize());
        bytes.AddRange(Info.TlSerialize());
        return bytes.ToArray();
    }
}

public abstract partial class MessagesAllInfoBase;

public sealed partial class MsgsAllInfo : MessagesAllInfoBase, ITlSerializable
{
    public static readonly byte[] Identifier = [49, 209, 192, 140,];
    public List<long> MsgIds { get; set; } = default!;
    public byte[] Info { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(MsgIds.TlSerialize());
        bytes.AddRange(Info.TlSerialize());
        return bytes.ToArray();
    }
}

public abstract partial class PQInnerDataBase;

public sealed partial class PqInnerDataDc : PQInnerDataBase, ITlSerializable
{
    public static readonly byte[] Identifier = [149, 95, 245, 169,];
    public byte[] Pq { get; set; } = default!;
    public byte[] P { get; set; } = default!;
    public byte[] Q { get; set; } = default!;
    public Int128 Nonce { get; set; } = default!;
    public Int128 ServerNonce { get; set; } = default!;
    public Int256 NewNonce { get; set; } = default!;
    public int Dc { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(Pq);
        bytes.AddRange(P);
        bytes.AddRange(Q);
        bytes.AddRange(Nonce.TlSerialize());
        bytes.AddRange(ServerNonce.TlSerialize());
        bytes.AddRange(NewNonce.TlSerialize());
        bytes.AddRange(Dc.TlSerialize());
        return bytes.ToArray();
    }
}

public sealed partial class PqInnerDataTempDc : PQInnerDataBase, ITlSerializable
{
    public static readonly byte[] Identifier = [136, 223, 253, 86,];
    public byte[] Pq { get; set; } = default!;
    public byte[] P { get; set; } = default!;
    public byte[] Q { get; set; } = default!;
    public Int128 Nonce { get; set; } = default!;
    public Int128 ServerNonce { get; set; } = default!;
    public Int256 NewNonce { get; set; } = default!;
    public int Dc { get; set; } = default!;
    public int ExpiresIn { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(Pq.TlSerialize());
        bytes.AddRange(P.TlSerialize());
        bytes.AddRange(Q.TlSerialize());
        bytes.AddRange(Nonce.TlSerialize());
        bytes.AddRange(ServerNonce.TlSerialize());
        bytes.AddRange(NewNonce.TlSerialize());
        bytes.AddRange(Dc.TlSerialize());
        bytes.AddRange(ExpiresIn.TlSerialize());
        return bytes.ToArray();
    }
}

public abstract partial class DestroySessionResBase;

public sealed partial class DestroySessionOk : DestroySessionResBase, ITlSerializable
{
    public static readonly byte[] Identifier = [252, 69, 32, 226,];
    public long SessionId { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(SessionId.TlSerialize());
        return bytes.ToArray();
    }
}

public sealed partial class DestroySessionNone : DestroySessionResBase, ITlSerializable
{
    public static readonly byte[] Identifier = [201, 80, 211, 98,];
    public long SessionId { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(SessionId.TlSerialize());
        return bytes.ToArray();
    }
}

public abstract partial class BadMessageNotificationBase;

public sealed partial class BadMsgNotification : BadMessageNotificationBase, ITlSerializable
{
    public static readonly byte[] Identifier = [17, 248, 239, 167,];
    public long BadMsgId { get; set; } = default!;
    public int BadMsgSeqno { get; set; } = default!;
    public int ErrorCode { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(BadMsgId.TlSerialize());
        bytes.AddRange(BadMsgSeqno.TlSerialize());
        bytes.AddRange(ErrorCode.TlSerialize());
        return bytes.ToArray();
    }
    public static BadMsgNotification? TlDeserialize(Deserializer des)
    {
        if (!des.IsCorrectId(Identifier)) return null;
        var badMsgId = des.As<long>().Read();
        var badSeq = des.As<int>().Read();
        var eCode = des.As<int>().Read();
        return new() { BadMsgId = badMsgId, ErrorCode = eCode, BadMsgSeqno = badSeq };
    }
}

public sealed partial class BadServerSalt : BadMessageNotificationBase, ITlSerializable
{
    public static readonly byte[] Identifier = [123, 68, 171, 237,];
    public long BadMsgId { get; set; } = default!;
    public int BadMsgSeqno { get; set; } = default!;
    public int ErrorCode { get; set; } = default!;
    public long NewServerSalt { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(BadMsgId.TlSerialize());
        bytes.AddRange(BadMsgSeqno.TlSerialize());
        bytes.AddRange(ErrorCode.TlSerialize());
        bytes.AddRange(NewServerSalt.TlSerialize());
        return bytes.ToArray();
    }
}

public abstract partial class MessageDetailedInfoBase;

public sealed partial class MsgDetailedInfo : MessageDetailedInfoBase, ITlSerializable
{
    public static readonly byte[] Identifier = [198, 62, 109, 39,];
    public long MsgId { get; set; } = default!;
    public long AnswerMsgId { get; set; } = default!;
    public int Bytes { get; set; } = default!;
    public int Status { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(MsgId.TlSerialize());
        bytes.AddRange(AnswerMsgId.TlSerialize());
        bytes.AddRange(Bytes.TlSerialize());
        bytes.AddRange(Status.TlSerialize());
        return bytes.ToArray();
    }
}

public sealed partial class MsgNewDetailedInfo : MessageDetailedInfoBase, ITlSerializable
{
    public static readonly byte[] Identifier = [223, 182, 157, 128,];
    public long AnswerMsgId { get; set; } = default!;
    public int Bytes { get; set; } = default!;
    public int Status { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(AnswerMsgId.TlSerialize());
        bytes.AddRange(Bytes.TlSerialize());
        bytes.AddRange(Status.TlSerialize());
        return bytes.ToArray();
    }
}

public abstract partial class SetClientDhParamsAnswerBase;

public sealed partial class DhGenOk : SetClientDhParamsAnswerBase, ITlSerializable
{
    public static readonly byte[] Identifier = [52, 247, 203, 59,];
    public Int128 Nonce { get; set; } = default!;
    public Int128 ServerNonce { get; set; } = default!;
    public Int128 NewNonceHash1 { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(Nonce.TlSerialize());
        bytes.AddRange(ServerNonce.TlSerialize());
        bytes.AddRange(NewNonceHash1.TlSerialize());
        return bytes.ToArray();
    }
}

public sealed partial class DhGenRetry : SetClientDhParamsAnswerBase, ITlSerializable
{
    public static readonly byte[] Identifier = [185, 31, 220, 70,];
    public Int128 Nonce { get; set; } = default!;
    public Int128 ServerNonce { get; set; } = default!;
    public Int128 NewNonceHash2 { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(Nonce.TlSerialize());
        bytes.AddRange(ServerNonce.TlSerialize());
        bytes.AddRange(NewNonceHash2.TlSerialize());
        return bytes.ToArray();
    }
}

public sealed partial class DhGenFail : SetClientDhParamsAnswerBase, ITlSerializable
{
    public static readonly byte[] Identifier = [2, 174, 157, 166,];
    public Int128 Nonce { get; set; } = default!;
    public Int128 ServerNonce { get; set; } = default!;
    public Int128 NewNonceHash3 { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(Nonce.TlSerialize());
        bytes.AddRange(ServerNonce.TlSerialize());
        bytes.AddRange(NewNonceHash3.TlSerialize());
        return bytes.ToArray();
    }
}

public abstract partial class RpcDropAnswerBase;

public sealed partial class RpcAnswerUnknown : RpcDropAnswerBase, ITlSerializable
{
    public static readonly byte[] Identifier = [110, 211, 42, 94,];
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        return bytes.ToArray();
    }
}

public sealed partial class RpcAnswerDroppedRunning : RpcDropAnswerBase, ITlSerializable
{
    public static readonly byte[] Identifier = [134, 229, 120, 205,];
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        return bytes.ToArray();
    }
}

public sealed partial class RpcAnswerDropped : RpcDropAnswerBase, ITlSerializable
{
    public static readonly byte[] Identifier = [183, 216, 58, 164,];
    public long MsgId { get; set; } = default!;
    public int SeqNo { get; set; } = default!;
    public int Bytes { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(MsgId.TlSerialize());
        bytes.AddRange(SeqNo.TlSerialize());
        bytes.AddRange(Bytes.TlSerialize());
        return bytes.ToArray();
    }
}

public abstract partial class DestroyAuthKeyResBase;

public sealed partial class DestroyAuthKeyOk : DestroyAuthKeyResBase, ITlSerializable
{
    public static readonly byte[] Identifier = [212, 225, 96, 246,];
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        return bytes.ToArray();
    }
}

public sealed partial class DestroyAuthKeyNone : DestroyAuthKeyResBase, ITlSerializable
{
    public static readonly byte[] Identifier = [89, 34, 159, 10,];
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        return bytes.ToArray();
    }
}

public sealed partial class DestroyAuthKeyFail : DestroyAuthKeyResBase, ITlSerializable
{
    public static readonly byte[] Identifier = [19, 155, 16, 234,];
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        return bytes.ToArray();
    }
}

//Functions
public sealed partial class ReqPqMulti : ITlSerializable
{
    public static readonly byte[] Identifier = [241, 142, 126, 190,];
    public Int128 Nonce { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(Nonce.TlSerialize());
        return bytes.ToArray();
    }
}

public sealed partial class ReqDhParams : ITlSerializable
{
    public static readonly byte[] Identifier = [190, 228, 18, 215,];
    public Int128 Nonce { get; set; } = default!;
    public Int128 ServerNonce { get; set; } = default!;
    public byte[] P { get; set; } = default!;
    public byte[] Q { get; set; } = default!;
    public long PublicKeyFingerprint { get; set; } = default!;
    public byte[] EncryptedData { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(Nonce.TlSerialize());
        bytes.AddRange(ServerNonce.TlSerialize());
        bytes.AddRange(P);
        bytes.AddRange(Q);
        bytes.AddRange(PublicKeyFingerprint.TlSerialize());
        bytes.AddRange(EncryptedData);
        return bytes.ToArray();
    }
}

public sealed partial class SetClientDhParams : ITlSerializable
{
    public static readonly byte[] Identifier = [31, 95, 4, 245,];
    public Int128 Nonce { get; set; } = default!;
    public Int128 ServerNonce { get; set; } = default!;
    public byte[] EncryptedData { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(Nonce.TlSerialize());
        bytes.AddRange(ServerNonce.TlSerialize());
        bytes.AddRange(EncryptedData);
        return bytes.ToArray();
    }
}

public sealed partial class RpcDropAnswer : ITlSerializable
{
    public static readonly byte[] Identifier = [64, 167, 228, 88,];
    public long ReqMsgId { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(ReqMsgId.TlSerialize());
        return bytes.ToArray();
    }
}

public sealed partial class GetFutureSalts : TlFunction<FutureSalts>, ITlSerializable
{
    public static readonly byte[] Identifier = [4, 189, 33, 185,];
    public int Num { get; set; } = default!;
    public override byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(Num.TlSerialize());
        return bytes.ToArray();
    }
}

public sealed partial class Ping : ITlSerializable
{
    public static readonly byte[] Identifier = [236, 119, 190, 122,];
    public long PingId { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(PingId.TlSerialize());
        return bytes.ToArray();
    }
}

public sealed partial class PingDelayDisconnect : ITlSerializable
{
    public static readonly byte[] Identifier = [140, 123, 66, 243,];
    public long PingId { get; set; } = default!;
    public int DisconnectDelay { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(PingId.TlSerialize());
        bytes.AddRange(DisconnectDelay.TlSerialize());
        return bytes.ToArray();
    }
}

public sealed partial class DestroySession : ITlSerializable
{
    public static readonly byte[] Identifier = [38, 33, 81, 231,];
    public long SessionId { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(SessionId.TlSerialize());
        return bytes.ToArray();
    }
}

public sealed partial class HttpWait : ITlSerializable
{
    public static readonly byte[] Identifier = [159, 53, 153, 146,];
    public int MaxDelay { get; set; } = default!;
    public int WaitAfter { get; set; } = default!;
    public int MaxWait { get; set; } = default!;
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(MaxDelay.TlSerialize());
        bytes.AddRange(WaitAfter.TlSerialize());
        bytes.AddRange(MaxWait.TlSerialize());
        return bytes.ToArray();
    }
}

public sealed partial class DestroyAuthKey : ITlSerializable
{
    public static readonly byte[] Identifier = [96, 81, 67, 209,];
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        return bytes.ToArray();
    }
}