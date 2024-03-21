using System.Buffers.Binary;
using System.Security.Cryptography;
using OneOf;
using SharpGram.Core.Common;
using SharpGram.Core.Conversions;
using SharpGram.Core.Cryptography;
using SharpGram.Core.Models;
using SharpGram.Core.Models.Errors;
using SharpGram.Tl.Mtproto;
using RpcError = SharpGram.Tl.Mtproto.RpcError;

namespace SharpGram.Core.Mtproto.Connections;

public class AuthConnection : IConnection
{
    private static readonly byte[][] UnsupportedTypes = [MsgCopy.Identifier, DestroySession.Identifier, DestroySessionOk.Identifier, DestroySessionNone.Identifier, HttpWait.Identifier, RpcAnswerUnknown.Identifier, RpcAnswerDropped.Identifier, RpcAnswerDroppedRunning.Identifier, MsgsStateInfo.Identifier, MsgsStateReq.Identifier, MsgsAllInfo.Identifier, MsgDetailedInfo.Identifier, MsgNewDetailedInfo.Identifier, MsgResendReq.Identifier];
    private List<byte> Buffer { get; set; } = [];
    private List<(MsgId id, OneOf<byte[], ErrorBase> result)> RpcResultList { get; } = [];
    public Session Session { get; init; } = default!;
    //internal readonly List<long> ReceivedAckList = [];

    public OneOf<MsgId, ConnectionError> Wrap(byte[] request, bool isContent = true)
    {
        var msgId = GetNewMsgId();
        var seq = GetSequenceNumber(isContent);
        Console.WriteLine($"[{msgId}] sequence is {seq}, isContent: {(seq & 1) == 1}, passedIsContent: {isContent}");
        var unPad = (32 + request.Length + 12) % 16;
        var padding = 12 + (unPad != 0 ? 16 - unPad : 0);

        var bytes = new List<byte>();
        bytes.AddRange(Session.FutureSalts.First().Salt.TlSerialize()); //todo take a newer salt
        bytes.AddRange(Session.SessionId.TlSerialize());
        bytes.AddRange(msgId.TlSerialize());
        bytes.AddRange(seq.TlSerialize());
        bytes.AddRange(request.Length.TlSerialize());
        bytes.AddRange(request);
        bytes.AddRange(Helpers.GenRandomBytes(padding));

        var plainData = bytes.ToArray();
        var msgK = SHA256.HashData(Session.AuthKey.AuthKeyData[88..120].Concat(plainData).ToArray())[8..24];
        var encryptedData = Ige.From(Session.AuthKey, msgK, false).Encrypt(plainData);
        ArgumentOutOfRangeException.ThrowIfNotEqual(encryptedData.Length % 16, 0);
        Buffer.AddRange(Session.AuthKey.KeyId);
        Buffer.AddRange(msgK);
        Buffer.AddRange(encryptedData);
        Session.MsgCount++;
        return new MsgId(msgId);
    }
    public List<byte> Pop()
    {
        var cp = Buffer;
        ClearBuffer();
        return cp;
    }
    public void ClearBuffer() => Buffer = [];
    public OneOf<RawRpcResponse, ErrorBase> Deserialize(byte[] payload)
    {
        var responseAuthKeyId = payload[..8];
        ArgumentOutOfRangeException.ThrowIfNotEqual(responseAuthKeyId.SequenceEqual(Session.AuthKey.KeyId), true);

        var responseMsgKey = payload[8..(8 + 16)];

        var responseDecrypted = Ige.From(Session.AuthKey, responseMsgKey, true).Decrypt(payload[24..]).ToArray();

        var ourKey = SHA256.HashData(Session.AuthKey.AuthKeyData[(88 + 8)..(88 + 8 + 32)].Concat(responseDecrypted).ToArray())[8..(8 + 16)];

        ArgumentOutOfRangeException.ThrowIfNotEqual(responseMsgKey.SequenceEqual(ourKey), true);

        var reader = Deserializer.New(responseDecrypted);

        _ = reader.As<long>().Read(); //ignore salt
        var responseSessionId = reader.As<long>().Read();
        ArgumentOutOfRangeException.ThrowIfNotEqual(responseSessionId, Session.SessionId);
        var msg = Message.TlDeserialize(reader);

        ArgumentOutOfRangeException.ThrowIfLessThan(responseDecrypted.Length, msg.Len);

        CheckContent(msg);
        return new RawRpcResponse { RpcResult = [..RpcResultList, (msg.MsgId, msg.Body)], };
    }

    private void FixTimeOffset(long msgId)
    {
        var now = DateTime.Now - StaticData.EpochTime;
        Session.TimeOffsetSeconds = (int)(msgId >> 32) - (int)now.TotalSeconds;
    }
    private long GetNewMsgId()
    {
        var now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
        var nanoseconds = (int)((now - Math.Floor((double)now)) * 1e9);
        var newMsgId = (now << 32) | (uint)(nanoseconds << 2);

        if (Session.LastMsgId >= newMsgId)
            newMsgId = Session.LastMsgId + 4;

        Session.LastMsgId = newMsgId;

        return newMsgId;
    }
    private int GetSequenceNumber(bool content)
    {
        if (!content) return Session.Sequence;
        Session.Sequence += 2;
        return Session.Sequence - 1;
    }
    private void CheckContent(Message msg)
    {
        Session.PendingAcknowledges.Add(msg.MsgId);

        var ctor = msg.Body.AsSpan(0, 4);
        //TODO rpc err
        if (ctor.SequenceEqual(RpcResult.Identifier))
        {
            var rpcResult = RpcResult.TlDeserialize(Deserializer.New(msg.Body));

            var innerCtor = rpcResult.Result.AsSpan(0, 4);
            if (innerCtor.SequenceEqual(GzipPacked.Identifier))
            {
                var d = GzipPacked.Decompress(Deserializer.New(rpcResult.Result));
                RpcResultList.Add((rpcResult.ReqMsgId, d));
            }
            else if (innerCtor.SequenceEqual(RpcError.Identifier))
                RpcResultList.Add((rpcResult.ReqMsgId, Models.Errors.RpcError.FromBytes(rpcResult.Result)));
            else if (innerCtor.IsOneOf(UnsupportedTypes))
                throw new NotImplementedException($"ctor [{BitConverter.ToString(ctor.ToArray())}] is not implemented.");
            else //TODO check for updates
                RpcResultList.Add((rpcResult.ReqMsgId, rpcResult.Result));
        }
        else if (ctor.SequenceEqual(FutureSalts.Identifier))
        {
            RpcResultList.Add((BinaryPrimitives.ReadInt64LittleEndian(msg.Body.AsSpan()[4..12]), msg.Body));
            Console.WriteLine("got salts");
        }
        else if (ctor.SequenceEqual(BadMsgNotification.Identifier))
        {
            var badMsg = BadMsgNotification.TlDeserialize(Deserializer.New(msg.Body));
            if (badMsg is not null)
                switch (badMsg.ErrorCode)
                {
                    case 16 or 17:
                        FixTimeOffset(badMsg.BadMsgId);
                        RpcResultList.Add((badMsg.BadMsgId, TransportError.New(TransportErrType.RetryRequest)));
                        break;
                    case 32 or 33:
                        //TODO restart the session
                        Console.WriteLine($"[{badMsg.BadMsgId}]seqNO either too low or too high ({badMsg.ErrorCode}), seq: [{badMsg.BadMsgSeqno}], sent seq : {Session.Sequence}");
                        RpcResultList.Add((badMsg.BadMsgId, TransportError.New(TransportErrType.RetryRequest)));
                        break;
                    default:
                        Console.WriteLine($"unhandled badNotification [{badMsg.BadMsgId}] err: {badMsg.ErrorCode}");
                        break;
                }
        }
        else if (ctor.SequenceEqual(BadServerSalt.Identifier))
        {
            throw new FatalException("badServerSalt, this should never happen since we are fetching new salts every 25 minutes.");
        }
        else if (ctor.SequenceEqual(MsgsAck.Identifier))
        {
            //nobody cares
            var ids = MsgsAck.TlDeserialize(Deserializer.New(msg.Body));
            //ReceivedAckList.AddRange(ids.MsgIds);
            Console.WriteLine($"[{ids}] msg acknowledged ");
        }
        else if (ctor.SequenceEqual(MsgContainer.Identifier))
        {
            foreach (var m in MsgContainer.TlDeserialize(Deserializer.New(msg.Body)))
                CheckContent(m);
        }
        else if (ctor.SequenceEqual(NewSessionCreated.Identifier))
        {
            var newSession = NewSessionCreated.TlDeserialize(Deserializer.New(msg.Body));
            Session.FutureSalts.Clear();
            Session.FutureSalts.Add(FutureSalt.New(newSession.ServerSalt));
        }
        else if (ctor.SequenceEqual(GzipPacked.Identifier))
        {
            msg.Body = GzipPacked.Decompress(Deserializer.New(msg.Body));
        }
        else if (ctor.SequenceEqual(Pong.Identifier))
        {
            var pongMsgId = BinaryPrimitives.ReadInt64LittleEndian(msg.Body.AsSpan()[4..12]);
            RpcResultList.Add((pongMsgId, msg.Body));
        }
        else if (ctor.IsOneOf(UnsupportedTypes))
        {
            throw new NotImplementedException($"ctor [{BitConverter.ToString(ctor.ToArray())}] is not implemented.");
        }
        else
        {
            //TODO check for updates
        }
    }
}