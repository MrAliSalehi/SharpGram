using System.Collections.Concurrent;
using System.Reactive.Linq;
using System.Threading.Channels;
using OneOf;
using SharpGram.Core.Common;
using SharpGram.Core.Conversions;
using SharpGram.Core.Models;
using SharpGram.Core.Models.Errors;
using SharpGram.Core.Mtproto.Connections;
using SharpGram.Core.Mtproto.Transport;
using SharpGram.Tl.Mtproto;
using ResultChannel = System.Threading.Channels.Channel<OneOf.OneOf<byte[], SharpGram.Core.Models.Errors.ErrorBase>>;

namespace SharpGram.Core.Network;

public sealed class NetworkManager<T>(AuthConnection comm, TcpConnection<UnAuthConnection, T> tcpConnection)
    where T : ITransport, new()
{
    private static readonly BoundedChannelOptions ChannelOptions = new(1)
    {
        FullMode = BoundedChannelFullMode.Wait,
        SingleWriter = true,
        SingleReader = false,
    };

    private TcpConnection<AuthConnection, T> Tcp { get; } = tcpConnection.IntoAuthenticated(comm);
    private BlockingCollection<Request> RequestQueue { get; set; } = [];
    private readonly ConcurrentDictionary<MsgId, ResultChannel> _resultChannels = [];
    private readonly SemaphoreSlim _pushLock = new(1);
    public async Task RunAsync(CancellationToken ct)
    {
        _ = Task.Run(async () => await RunListenerAsync(ct), ct);
        _ = Task.Run(async () => await RunSenderAsync(ct), ct);
        _ = Task.Run(async () => await AckHandlerAsync(ct), ct);
        await SaltHandlerAsync(ct);
        await PingHandlerAsync(ct);
    }
    public bool IsAuthorized() => Tcp.Connection.Session.AuthKey.AuthKeyData.Length != 0;
    public ChannelReader<OneOf<byte[], ErrorBase>> Push(byte[] request, bool isContent = true, CancellationToken ct = default)
    {
        var rp = Channel.CreateBounded<OneOf<byte[], ErrorBase>>(ChannelOptions);
        _pushLock.WaitAsync(ct);
        RequestQueue.Add(new Request(request, rp, isContent), ct);
        _pushLock.Release();
        return rp.Reader;
    }
    private async Task PingHandlerAsync(CancellationToken ct)
    {
        //TODO dynamic ping delay
        await AsyncObservable.Timer(TimeSpan.FromSeconds(10), TimeSpan.FromSeconds(20)).SubscribeAsync(async _ =>
        {
            if (!IsAuthorized()) return;

            var request = new Ping { PingId = Tcp.Connection.Session.PingId }.TlSerialize();
            Console.WriteLine($"sending ping: {Tcp.Connection.Session.PingId}.");
            var reader = Push(request);
            await reader.WaitToReadAsync(ct);
            if ((await reader.ReadAsync(ct)).TryPickT1(out var e, out var result)) throw e;
            var pong = Pong.TlDeserialize(result);
            Console.WriteLine($"[{pong.MsgId}] received pong: {pong.PingId}");
            ArgumentOutOfRangeException.ThrowIfNotEqual(pong.PingId, Tcp.Connection.Session.PingId);
            Tcp.Connection.Session.PingId++;
        });
    }
    private async Task RunListenerAsync(CancellationToken ct)
    {
        while (!ct.IsCancellationRequested)
        {
            var response = await Tcp.ReadFullAsync(ct);
            if (response.TryPickT1(out var err, out var deserialization)) //if failed
            {
                //TODO retry instead of failing all the channels
                foreach (var (_, c) in _resultChannels)
                {
                    await c.Writer.WriteAsync(err, ct);
                    c.Writer.Complete();
                }

                _resultChannels.Clear();
                continue;
            }

            // send back the response of the rpc query
            foreach (var (id, result) in deserialization.RpcResult)
            {
                if (_resultChannels.TryGetValue(id, out var channel))
                {
                    Console.WriteLine($"[{id}] Returning Result.");
                    await channel.Writer.WriteAsync(result, ct);
                    channel.Writer.Complete();
                    _resultChannels.Remove(id, out _);
                }
            }

            //TODO is this really useful ?
            //return ack response
            /*foreach (var id in Tcp.Connection.ReceivedAckList)
            {
                if (_resultChannels.TryGetValue(id, out var channel))
                {
                    Console.WriteLine($"rpc query was ignored for msg : {id}");
                    await channel.Writer.WriteAsync(TransportError.New(TransportErrType.AckWithoutResult), ct);
                    //_resultChannels.Remove(id, out _);
                }
            }*/
        }
    }

    private async Task RunSenderAsync(CancellationToken ct)
    {
        while (!ct.IsCancellationRequested)
        {
            var item = RequestQueue.Take(ct); //block until there is something

            var result = await Tcp.WriteAsync(item.Req, item.IsContent, ct);
            if (result.TryPickT0(out var newId, out var e))
            {
                var added = _resultChannels.TryAdd(newId, item.ResultChannel);
                Console.WriteLine($"[{newId}], this request {(added ? "added" : "already exist")}.");
            }
            else
            {
                //if write operation failed just return the result, perhaps it could retry after a few moments here..
                await item.ResultChannel.Writer.WriteAsync(e, ct);
            }
        }
    }

    private async Task AckHandlerAsync(CancellationToken ct)
    {
        while (!ct.IsCancellationRequested)
        {
            if (Tcp.Connection.Session.PendingAcknowledges.IsEmpty)
            {
                await Task.Delay(TimeSpan.FromMilliseconds(100), ct);
                continue;
            }

            var acks = new MsgsAck { MsgIds = Tcp.Connection.Session.PendingAcknowledges.ToList() };
            Tcp.Connection.Session.PendingAcknowledges.Clear();
            Push(acks.TlSerialize(), false, ct);
            Console.WriteLine($"Pushed Ack List: {acks}");
        }
    }

    private async Task SaltHandlerAsync(CancellationToken ct)
    {
#if DEBUG
        var every = TimeSpan.FromSeconds(10);
#else
        var every = TimeSpan.FromMinutes(25);
#endif
        //TODO dynamic salt delay maybe?
        await AsyncObservable.Timer(TimeSpan.FromSeconds(6), every).SubscribeAsync(async _ =>
        {
            if (!IsAuthorized()) return;
            Console.WriteLine("asking for salts...");
            var getSalt = new GetFutureSalts { Num = 1 }.TlSerialize();
            var reader = Push(getSalt, true, ct);
            await reader.WaitToReadAsync(ct);

            if ((await reader.ReadAsync(ct)).TryPickT1(out var e, out var result))
                throw e;

            var futureSalts = FutureSalts.TlDeserialize(Deserializer.New(result));
            Console.WriteLine($"[{futureSalts.ReqMsgId}] fetched some new Salts ({futureSalts.Now}): {futureSalts}");
            Tcp.Connection.Session.FutureSalts.Clear();
            Tcp.Connection.Session.FutureSalts.AddRange(futureSalts.Salts);
        });
    }
}

public sealed record Request(byte[] Req, ResultChannel ResultChannel, bool IsContent);