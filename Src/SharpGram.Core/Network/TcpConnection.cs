using System.Buffers.Binary;
using System.Net;
using System.Net.Sockets;
using OneOf;
using SharpGram.Core.Common;
using SharpGram.Core.Models;
using SharpGram.Core.Models.Errors;
using SharpGram.Core.Mtproto.Connections;
using SharpGram.Core.Mtproto.Transport;
using TransportError = SharpGram.Core.Models.Errors.TransportError;

namespace SharpGram.Core.Network;

public sealed class TcpConnection<TConnection, TTransport> : IDisposable
    where TConnection : IConnection, new()
    where TTransport : ITransport, new()
{
    private readonly SemaphoreSlim _lockWrite = new(1);
    private TcpClient TcpClient { get; init; } = default!;
    private IPEndPoint Dc { get; init; } = default!;
    internal TConnection Connection { get; private init; } = default!;
    internal TTransport Transport { get; init; } = default!;
    private readonly byte[] _lenBuff = new byte[4];
    private int DcId { get; init; }
    public TcpConnection<AuthConnection, TTransport> IntoAuthenticated(AuthConnection conn)
    {
        return New(DcId, Transport, TcpClient, conn).AsT0; //already connected to socket so its safe to cast
    }

    /// this is ugly AF
    public static OneOf<TcpConnection<T1, T2>, ConnectionError> New<T1, T2>(int dcId,
                                                                            T2? tr = default,
                                                                            TcpClient? tcpClient = default,
                                                                            T1? conn = default)
        where T1 : IConnection, new() where T2 : ITransport, new()
    {
        var found = StaticData.DcList.TryGetValue(dcId, out var dc);
        if (!found) return ConnectionError.New(ConnectionErrType.DcNotFound);
        return new TcpConnection<T1, T2>
        {
            TcpClient = tcpClient ?? new TcpClient
            {
                ReceiveTimeout = 500,
                SendTimeout = 500
            },
            DcId = dcId,
            Dc = dc!,
            Transport = tr ?? new T2(),
            Connection = conn ?? new T1(),
        };
    }

    public async Task<bool> ConnectAsync(CancellationToken ct = default)
    {
        if (IsConnected()) return false;
        await TcpClient.ConnectAsync(Dc, ct);
        return true;
    }

    public async Task<OneOf<RawRpcResponse, ErrorBase>> ReadFullAsync(CancellationToken ct = default)
    {
        if (!IsConnected()) return ConnectionError.New(ConnectionErrType.SocketNotConnected);

        var ns = TcpClient.GetStream();
        await ns.ReadExactlyAsync(_lenBuff, 0, 4, ct);
        var envelopeLen = BinaryPrimitives.ReadInt32LittleEndian(_lenBuff);
        ArgumentOutOfRangeException.ThrowIfLessThan(envelopeLen, 4);

        var data = new byte[envelopeLen];
        var read = 0;

        do
        {
            read += await ns.ReadAsync(data.AsMemory(read, envelopeLen - read), ct);
        } while (read < envelopeLen);

        if (data.Length < envelopeLen) return TransportError.New(TransportErrType.TransportErr);

        byte[] unpacked = [];
        var len = Transport.UnPack([.._lenBuff, ..data], ref unpacked);
        ArgumentOutOfRangeException.ThrowIfNotEqual(len, envelopeLen + 4);
        return Connection.Deserialize(unpacked);
    }


    public async Task<OneOf<MsgId, ConnectionError>> WriteAsync(byte[] data, bool isContent = true, CancellationToken ct = default)
    {
        await _lockWrite.WaitAsync(ct);
        var res = await PrivateWriteAsync(data, isContent, ct);
        _lockWrite.Release();
        return res;
    }
    private async Task<OneOf<MsgId, ConnectionError>> PrivateWriteAsync(byte[] data, bool isContent = true, CancellationToken ct = default)
    {
        if (!IsConnected()) return ConnectionError.New(ConnectionErrType.SocketNotConnected);
        var id = Connection.Wrap(data, isContent);
        var unencryptedData = Connection.Pop();
        List<byte> packed = [];
        Transport.Pack(unencryptedData, packed);
        await TcpClient.GetStream().WriteAsync(packed.ToArray(), ct);
        return id.AsT0; //shouldn't fail
    }

    public async Task WriteUnsafeAsync(byte[] b) => await TcpClient.GetStream().WriteAsync(b);
    public async Task<byte[]> ReadUnsafeAsync()
    {
        var b = new byte[1204];
        var r = await TcpClient.GetStream().ReadAsync(b);
        if (b.Length > r)
            Array.Resize(ref b, r);
        return b;
    }
    public bool IsConnected() => TcpClient.Connected;

    public void Dispose() => TcpClient.Dispose();
}