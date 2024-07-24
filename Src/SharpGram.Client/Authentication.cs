using System.Buffers.Binary;
using System.ComponentModel;
using System.Numerics;
using System.Security.Cryptography;
using OneOf;
using SharpGram.Core.Common;
using SharpGram.Core.Conversions;
using SharpGram.Core.Cryptography;
using SharpGram.Core.Models.Errors;
using SharpGram.Core.Models.Types;
using SharpGram.Core.Mtproto.Connections;
using SharpGram.Core.Mtproto.Transport;
using SharpGram.Core.Network;
using SharpGram.Tl.Constructors.DcOptionNs;
using SharpGram.Tl.Mtproto;
using Int128 = SharpGram.Core.Models.Types.Int128;

namespace SharpGram.Client;

public sealed record AuthResult([ReadOnly(true)] byte[] AuthKey, [ReadOnly(true)] int Offset, [ReadOnly(true)] long Salt);

public sealed class Authentication
{
    private readonly Int128 _nonce;
    private ResPq _resPq = null!;
    private Ige _ige = null!;
    private ServerDhInnerData _serverDhInnerData = null!;
    private readonly TcpConnection<UnAuthConnection, Intermediate> _tcp;
    private BigInteger _gb;
    private BigInteger _gab;
    private byte[] _newNonceBytes = null!;
    private int _offset;
    private byte[] _salt = null!;
    private byte[] _authKey = null!;
    private Authentication(TcpConnection<UnAuthConnection, Intermediate> tcp)
    {
        _nonce = Int128.GenerateRandom();
        _tcp = tcp;
    }
    /// <summary>
    /// https://core.telegram.org/mtproto/auth_key
    /// </summary>
    public static async Task<OneOf<Authentication, ConnectionError>> NewAsync(DcOption dc)
    {
        var connected = TcpConnection<UnAuthConnection, Intermediate>.New<UnAuthConnection, Intermediate>(dc).TryPickT0(out var connection, out var err);
        if (!connected)
            return err;
        var auth = new Authentication(connection!);
        await auth._tcp.ConnectAsync();
        return auth;
    }
    public TcpConnection<UnAuthConnection, Intermediate> GetConnection() => _tcp;
    public async Task<AuthResult> AuthorizeAsync()
    {
        await FirstStepAsync();
        await SecondStepAsync();
        await ThirdStepAsync();
        return new AuthResult(_authKey, _offset, BinaryPrimitives.ReadInt64LittleEndian(_salt));
    }
    private async Task FirstStepAsync()
    {
        var data = new ReqPqMulti { Nonce = _nonce }.TlSerialize();
        await _tcp.WriteAsync(data);

        var response = (await _tcp.ReadFullAsync()).UnsafeUnwrap();

        _resPq = ResPq.TlDeserialize(response);
        if (_resPq.Nonce != _nonce) AuthorizeException.ThrowServerNonceNotMatched();
    }
    private async ValueTask SecondStepAsync()
    {
        var newNonce = Int256.GenerateRandom();
        _newNonceBytes = newNonce.TlSerialize();

        var pQInnerDataDc = new PqInnerDataDc(_resPq.Pq, _resPq.P, _resPq.Q, _nonce, newNonce, _resPq.ServerNonce, 0);

        var (publicKey, fingerprint) = _resPq.GetPublicKey();

        var rsa = new RsaEncryption(publicKey);

        var cipherText = rsa.Encrypt(pQInnerDataDc.TlSerialize(), Helpers.GenRandomBytes(256)).ToArray();

        var dhParams = new ReqDhParams
        {
            Nonce = _nonce,
            ServerNonce = _resPq.ServerNonce,
            P = pQInnerDataDc.P,
            Q = pQInnerDataDc.Q,
            PublicKeyFingerprint = fingerprint,
            EncryptedData = cipherText.TlSerialize().ToArray(),
        }.TlSerialize();

        await _tcp.WriteAsync(dhParams);

        var result = (await _tcp.ReadFullAsync()).UnsafeUnwrap();

        var ok = ServerDhParamsOk.TlDeserialize(result);

        if (ok.Nonce != _nonce || ok.ServerNonce != _resPq.ServerNonce) AuthorizeException.ThrowServerNonceNotMatched();

        ArgumentOutOfRangeException.ThrowIfNotEqual(ok.EncryptedAnswer.Length % 16, 0);

        var (key, iv) = ok.GenerateKey(_newNonceBytes);

        _ige = new Ige(key.ToArray(), iv.ToArray());

        var answer = _ige.Decrypt(ok.EncryptedAnswer).ToArray();

        var answerHash = answer[..20];

        var (serverDhInnerData, pos) = ServerDhInnerData.TlDeserialize(answer[20..]);

        var hash = SHA1.HashData(answer[20..(20 + pos)]);

        ArgumentOutOfRangeException.ThrowIfNotEqual(answerHash.SequenceEqual(hash), true);

        if (serverDhInnerData.Nonce != _nonce || serverDhInnerData.ServerNonce != _resPq.ServerNonce) AuthorizeException.ThrowServerNonceNotMatched();

        var dhPrime = new BigInteger(serverDhInnerData.DhPrime, true, true);
        var g = new BigInteger(serverDhInnerData.G.TlSerialize().ToArray(), true);
        var ga = new BigInteger(serverDhInnerData.Ga, true, true);
        _offset = serverDhInnerData.ServerTime - (int)(DateTime.Now - StaticData.EpochTime).TotalSeconds;

        var b = new BigInteger(Helpers.GenRandomBytes(256), true, true);

        var gb = BigInteger.ModPow(g, b, dhPrime);
        var gab = BigInteger.ModPow(ga, b, dhPrime);

        var rng = BigInteger.One << (2048 - 64);
        g.CheckInRange(BigInteger.One, dhPrime - BigInteger.One);
        ga.CheckInRange(BigInteger.One, dhPrime - BigInteger.One);
        gb.CheckInRange(BigInteger.One, dhPrime - BigInteger.One);
        ga.CheckInRange(rng, dhPrime - rng);
        gb.CheckInRange(rng, dhPrime - rng);

        _serverDhInnerData = serverDhInnerData;
        _gb = gb;
        _gab = gab;
    }
    private async Task ThirdStepAsync()
    {
        var clientDhInner = new ClientDhInnerData
        {
            Nonce = _nonce,
            ServerNonce = _serverDhInnerData.ServerNonce,
            RetryId = 0,
            Gb = _gb.ToByteArray(isBigEndian: true).TlSerialize().ToArray()
        };

        var clientDhInnerHash = clientDhInner.ComputeHash().ToArray();

        var enc = _ige.Encrypt(clientDhInnerHash).ToArray();

        var setClientDhParams = new SetClientDhParams
        {
            Nonce = _nonce,
            ServerNonce = clientDhInner.ServerNonce,
            EncryptedData = enc.TlSerialize().ToArray()
        }.TlSerialize();

        await _tcp.WriteAsync(setClientDhParams);

        var setClientDhParamsAnswer = (await _tcp.ReadFullAsync()).UnsafeUnwrap();

        var dhParamsAnswer = SetClientDhParamsAnswerBase.TlDeserialize(setClientDhParamsAnswer);

        if (dhParamsAnswer is not DhGenOk dhGenOk) throw AuthorizeException.ThrowDhGenFailed;

        if (dhGenOk.Nonce != _nonce || dhGenOk.ServerNonce != _resPq.ServerNonce) AuthorizeException.ThrowServerNonceNotMatched();

        var authKeyBytes = new byte[256];
        var gabBytes = _gab.ToByteArray(isBigEndian: true);
        if (gabBytes[0] == 0x0)
            gabBytes = gabBytes.Skip(1).ToArray();

        gabBytes.CopyTo(authKeyBytes, authKeyBytes.Length - gabBytes.Length);

        var authKey = AuthKey.FromBytes(authKeyBytes);

        var newNonceHash = authKey.NewNonceHash(_newNonceBytes, 1);

        ArgumentOutOfRangeException.ThrowIfNotEqual(dhGenOk.NewNonceHash1, Int128.FromBytes(newNonceHash));

        var serverNonce = _serverDhInnerData.ServerNonce.ToBytes();
        _salt = new byte[8];
        for (var i = 0; i < _salt.Length; i++)
            _salt[i] = (byte)(_newNonceBytes[i] ^ serverNonce[i]);

        _authKey = authKey.AuthKeyData;
    }
}