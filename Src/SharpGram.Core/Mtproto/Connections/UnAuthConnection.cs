using OneOf;
using SharpGram.Core.Conversions;
using SharpGram.Core.Models;
using SharpGram.Core.Models.Errors;

namespace SharpGram.Core.Mtproto.Connections;

public class UnAuthConnection : IConnection
{
    private readonly byte[] _serializedZero = ((long)0).TlSerialize();

    private List<byte> Buffer { get; set; } = [];

    private readonly CustomBinaryReader _reader = new();

    public OneOf<MsgId, ConnectionError> Wrap(byte[] request, bool isContent)
    {
        if (Buffer.Count != 0) return TransportError.New(TransportErrType.BufferNotEmpty);

        Buffer.AddRange(_serializedZero);              //auth key
        Buffer.AddRange(_serializedZero);              //msg id
        Buffer.AddRange(request.Length.TlSerialize()); // msg len

        Buffer.AddRange(request);

        return MsgId.Zero;
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
        if (payload.Length == 4) return TransportError.New(TransportErrType.TransportErr);
        if (payload.Length <= 20) return TransportError.New(TransportErrType.SmallMsg);

        _reader.Buffer = payload;
        var authKeyId = _reader.ReadLong();
        if (authKeyId != 0) return TransportError.New(TransportErrType.BadAuthKey);

        var msgId = _reader.ReadLong();

        if (msgId <= 0 || msgId % 4 != 1) return TransportError.New(TransportErrType.BadMsgId);

        var len = _reader.ReadInt();

        if (len <= 0 || len + 20 > payload.Length) return TransportError.New(TransportErrType.BadMsgLen);

        _reader.Reset();
        return new RawRpcResponse
        {
            RpcResult = [(new MsgId(0), payload[20..(20 + len)])],
            Updates = []
        };
    }
}