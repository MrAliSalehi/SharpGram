using System.Buffers.Binary;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using SharpGram.Core.Common;
using SharpGram.Core.Contracts;
using SharpGram.Core.Conversions;
using SharpGram.Core.Cryptography;
using SharpGram.Core.Models.Types;
using SharpGram.Tl.Constructors.JSONObjectValueNs;
using SharpGram.Tl.Types;
using Int128 = SharpGram.Core.Models.Types.Int128;

// ReSharper disable InconsistentNaming CheckNamespace


namespace SharpGram.Tl.Mtproto;
public static class ManualMtproto
{
    public const int TlLayer = 172;
}
public partial class ResPq
{
    public required byte[] P { get; init; }
    public required byte[] Q { get; init; }
    public static ResPq TlDeserialize(byte[] payload)
    {
        var reader = CustomBinaryReader.From(payload);
        ArgumentOutOfRangeException.ThrowIfNotEqual(reader.Id.SequenceEqual(Identifier), true);
        var nonce = reader.ReadInt128();
        var server = reader.ReadInt128();
        var pq = reader.ReadStrAsBytes();
        var f = reader.ReadListOfLong();
        var intPq = BinaryPrimitives.ReadUInt64BigEndian(pq.AsSpan()[..8]);

        var (p, q) = CryptoHelpers.Factorize(intPq);
        return new ResPq
        {
            Nonce = nonce,
            ServerNonce = server,
            Pq = pq,
            ServerPublicKeyFingerprints = f.IsT1 ? [] : f.AsT0,
            P = Helpers.ToBigEndian(p),
            Q = Helpers.ToBigEndian(q),
        };
    }

    //fetched from https://my.telegram.org/apps
    public (string pubKey, long fingerPrint) GetPublicKey()
    {
        //production -3414540481677951611
        if (ServerPublicKeyFingerprints.Contains(-3414540481677951611))
            return ("""
                    -----BEGIN RSA PUBLIC KEY-----
                    MIIBCgKCAQEA6LszBcC1LGzyr992NzE0ieY+BSaOW622Aa9Bd4ZHLl+TuFQ4lo4g
                    5nKaMBwK/BIb9xUfg0Q29/2mgIR6Zr9krM7HjuIcCzFvDtr+L0GQjae9H0pRB2OO
                    62cECs5HKhT5DZ98K33vmWiLowc621dQuwKWSQKjWf50XYFw42h21P2KXUGyp2y/
                    +aEyZ+uVgLLQbRA1dEjSDZ2iGRy12Mk5gpYc397aYp438fsJoHIgJ2lgMv5h7WY9
                    t6N/byY9Nw9p21Og3AoXSL2q/2IJ1WRUhebgAdGVMlV1fkuOQoEzR7EdpqtQD9Cs
                    5+bfo3Nhmcyvk5ftB0WkJ9z6bNZ7yxrP8wIDAQAB
                    -----END RSA PUBLIC KEY-----
                    """, -3414540481677951611);

        //test -5595554452916591101
        if (ServerPublicKeyFingerprints.Contains(-5595554452916591101))
            return ("""
                    -----BEGIN RSA PUBLIC KEY-----
                    MIIBCgKCAQEAyMEdY1aR+sCR3ZSJrtztKTKqigvO/vBfqACJLZtS7QMgCGXJ6XIR
                    yy7mx66W0/sOFa7/1mAZtEoIokDP3ShoqF4fVNb6XeqgQfaUHd8wJpDWHcR2OFwv
                    plUUI1PLTktZ9uW2WE23b+ixNwJjJGwBDJPQEQFBE+vfmH0JP503wr5INS1poWg/
                    j25sIWeYPHYeOrFp/eXaqhISP6G+q2IeTaWTXpwZj4LzXq5YOpk4bYEQ6mvRq7D1
                    aHWfYmlEGepfaYR8Q0YqvvhYtMte3ITnuSJs171+GDqpdKcSwHnd6FudwGO4pcCO
                    j4WcDuXc2CTHgH8gFTNhp/Y8/SpDOhvn9QIDAQAB
                    -----END RSA PUBLIC KEY-----
                    """, -5595554452916591101);

        //local test 5029102387713689287
        if (ServerPublicKeyFingerprints.Contains(5029102387713689287))
            return ("""
                    -----BEGIN RSA PUBLIC KEY-----
                    MIIBCgKCAQEAtpKdF+PJ7+wHatWOJuUVv/ih42gVIeaOG/sHwVXGD6PofJAG0KxU
                    KxaJHVDRYgJxVg8HnVzGbzRlbuod0JzRjRP+GgIqNntuGIP+CDcFSV8vQ8xeH9om
                    SLlvLOoLK+SE4Q76BUR69cZS7J8WOs+eBpudPf8kV6m79X5UFNquXWA/ecHjhY7u
                    r3VPdTbRAyP2AWy5ahkZhzS27KmEKCUuua/f91AfAX4Z5n4U44/4jjg3cDGKcJcG
                    0SV8lcVB9NnB8A3joJtZrQSgW+EfAgo/im0GMzBl2RsP0MX0xyST3AznJlHXqpMc
                    Is9eZFnWOpaZgddRVzhKXg+UcFnK+/w6+wIDAQAB
                    -----END RSA PUBLIC KEY-----
                    """, 5029102387713689287);

        throw new NotSupportedException("this is not suppose to happen");
    }
}

public partial class ClientDhInnerData
{
    public List<byte> ComputeHash()
    {
        var serialize = TlSerialize();
        var result = new List<byte>();
        result.AddRange(SHA1.HashData(serialize.ToArray()));
        result.AddRange(serialize);
        result.AddRange(Helpers.GenRandomBytes((16 - result.Count % 16) % 16));
        return result;
    }
}

public partial class ServerDhInnerData
{
    public static (ServerDhInnerData, int pos) TlDeserialize(byte[] payload)
    {
        var reader = CustomBinaryReader.From(payload);
        ArgumentOutOfRangeException.ThrowIfNotEqual(reader.ReadId().SequenceEqual(Identifier), true);

        var nonce = reader.ReadInt128();
        var serverNonce = reader.ReadInt128();
        var g = reader.ReadInt();
        var dhPrime = reader.ReadStrAsBytes();
        var ga = reader.ReadStrAsBytes();
        var serverTime = reader.ReadInt();

        return (new ServerDhInnerData
        {
            Nonce = nonce,
            ServerNonce = serverNonce,
            G = g,
            DhPrime = dhPrime,
            Ga = ga,
            ServerTime = serverTime
        }, reader.Position);
    }
}

public partial class PqInnerDataDc
{
    [SetsRequiredMembers]
    public PqInnerDataDc(byte[] pq, byte[] p, byte[] q, Int128 nonce, Int256 newNonce, Int128 serverNonce, int dc)
    {
        var pBytes = new[] { (byte)p.Length };
        var qBytes = new[] { (byte)q.Length };
        var pqBytes = new[] { (byte)pq.Length };
        Array.Resize(ref pBytes, p.Length + 4);
        Array.Resize(ref qBytes, q.Length + 4);
        Array.Resize(ref pqBytes, pq.Length + 4);

        p.CopyTo(pBytes, 1);
        q.CopyTo(qBytes, 1);
        pq.CopyTo(pqBytes, 1);
        P = pBytes;
        Q = qBytes;
        Pq = pqBytes;
        Nonce = nonce;
        ServerNonce = serverNonce;
        NewNonce = newNonce;
        Dc = dc;
    }
}

public partial class ServerDhParamsOk
{
    public static ServerDhParamsOk TlDeserialize(byte[] payload)
    {
        var reader = CustomBinaryReader.From(payload);
        ArgumentOutOfRangeException.ThrowIfNotEqual(reader.Id.SequenceEqual(Identifier), true);

        var nonce = reader.ReadInt128();
        var serverNonce = reader.ReadInt128();
        var enc = reader.ReadStrAsBytes();
        return new ServerDhParamsOk
        {
            Nonce = nonce,
            ServerNonce = serverNonce,
            EncryptedAnswer = enc
        };
    }
    public (byte[] key, IEnumerable<byte> iv) GenerateKey(byte[] newNonce)
    {
        var serverNonce = ServerNonce.ToBytes();

        Span<byte> x = stackalloc byte[newNonce.Length * 2];
        newNonce.CopyTo(x[..newNonce.Length]);
        newNonce.CopyTo(x[newNonce.Length..]);
        var a = SHA1.HashData(newNonce.Concat(serverNonce).ToArray());
        var b = SHA1.HashData(serverNonce.Concat(newNonce).ToArray());
        var c = SHA1.HashData(x);

        Span<byte> key = stackalloc byte[32];
        a.CopyTo(key[..a.Length]);
        b[..12].CopyTo(key[a.Length..]);


        Span<byte> iv = stackalloc byte[32];

        b[12..].CopyTo(iv[..8]);
        c.CopyTo(iv[8..28]);
        newNonce[..4].CopyTo(iv[28..]);

        return (key.ToArray(), iv.ToArray());
    }
}

public partial class DhGenOk
{
    public new static DhGenOk TlDeserialize(byte[] payload)
    {
        var reader = CustomBinaryReader.From(payload);
        ArgumentOutOfRangeException.ThrowIfNotEqual(reader.ReadId().SequenceEqual(Identifier), true);
        var nonce = reader.ReadInt128();
        var serverNonce = reader.ReadInt128();
        var newNonce = reader.ReadInt128();
        return new DhGenOk
        {
            Nonce = nonce,
            ServerNonce = serverNonce,
            NewNonceHash1 = newNonce
        };
    }
}

public partial class DhGenRetry
{
    public new static DhGenRetry TlDeserialize(byte[] payload)
    {
        var reader = CustomBinaryReader.From(payload);
        ArgumentOutOfRangeException.ThrowIfNotEqual(reader.Id.SequenceEqual(Identifier), true);
        var nonce = reader.ReadInt128();
        var serverNonce = reader.ReadInt128();
        var newNonce = reader.ReadInt128();
        return new DhGenRetry
        {
            Nonce = nonce,
            ServerNonce = serverNonce,
            NewNonceHash2 = newNonce
        };
    }
}

public partial class DhGenFail
{
    public new static DhGenFail TlDeserialize(byte[] payload)
    {
        var reader = CustomBinaryReader.From(payload);
        ArgumentOutOfRangeException.ThrowIfNotEqual(reader.Id.SequenceEqual(Identifier), true);
        var nonce = reader.ReadInt128();
        var serverNonce = reader.ReadInt128();
        var newNonce = reader.ReadInt128();
        return new DhGenFail
        {
            Nonce = nonce,
            ServerNonce = serverNonce,
            NewNonceHash3 = newNonce
        };
    }
}

public abstract partial class SetClientDhParamsAnswerBase
{
    public static SetClientDhParamsAnswerBase TlDeserialize(byte[] payload)
    {
        var id = payload[..4];
        if (id.SequenceEqual(DhGenOk.Identifier))
            return DhGenOk.TlDeserialize(payload);
        if (id.SequenceEqual(DhGenFail.Identifier))
            return DhGenFail.TlDeserialize(payload);

        return DhGenRetry.TlDeserialize(payload);
    }
}

public sealed class RpcResult : RpcResultBase
{
    public static readonly byte[] Identifier = [1, 109, 92, 243,];
    public long ReqMsgId { get; init; }
    public byte[] Result { get; init; } = default!;

    private RpcResult() { }
    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(ReqMsgId.TlSerialize());
        bytes.AddRange(Result.TlSerialize());
        return bytes.ToArray();
    }
    public static RpcResult TlDeserialize(Deserializer deserializer)
    {
        var id = deserializer.ReadId();
        ArgumentOutOfRangeException.ThrowIfNotEqual(id.SequenceEqual(Identifier), true);
        var reqId = deserializer.As<long>().Read();
        var result = deserializer.ReadToEnd();

        return new RpcResult
        {
            ReqMsgId = reqId,
            Result = result
        };
    }
}


public sealed class InitConnection<TRet> : TlFunction<TRet> where TRet : ITlDeserializable<TRet>
{
    public static readonly byte[] Identifier = [169,94,205,193];

    public int ApiId { get; set; }
    public string DeviceModel { get; set; } = default!;
    public string SystemVersion { get; set; } = default!;
    public string AppVersion { get; set; } = default!;
    public string SystemLangCode { get; set; } = default!;
    public string LangPack { get; set; } = default!;
    public string LangCode { get; set; } = default!;
    public InputClientProxyBase? Proxy { get; set; }
    public JSONObjectValueBase? Params { get; set; }
    public TlFunction<TRet> Query { get; set; } = default!;

    public override byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange((0 | (Proxy is not null ? 1 : 0) | (Params is not null ? 2 : 0) ).TlSerialize());
        bytes.AddRange(ApiId.TlSerialize());
        bytes.AddRange(DeviceModel.TlSerialize());
        bytes.AddRange(SystemVersion.TlSerialize());
        bytes.AddRange(AppVersion.TlSerialize());
        bytes.AddRange(SystemLangCode.TlSerialize());
        bytes.AddRange(LangPack.TlSerialize());
        bytes.AddRange(LangCode.TlSerialize());
        if (Proxy is not null) bytes.AddRange(Proxy.TlSerialize());
        if (Params is not null) bytes.AddRange(Params.TlSerialize());
        bytes.AddRange(Query.TlSerialize());
        return bytes.ToArray();
    }
}
public sealed class InvokeWithLayer<TRet> : TlFunction<TRet> where TRet: ITlDeserializable<TRet>
{
    private static readonly byte[] Identifier = [13,13,155,218];
    public int Layer { get => ManualMtproto.TlLayer; }
    public TlFunction<TRet> Query { get; set; } = default!;
    public override byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(Identifier);
        bytes.AddRange(Layer.TlSerialize());
        bytes.AddRange(Query.TlSerialize());
        return bytes.ToArray();
    }
}