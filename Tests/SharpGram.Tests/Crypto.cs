using System.Buffers.Binary;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using FluentAssertions;
using SharpGram.Core.Cryptography;

namespace SharpGram.Tests;

public class Crypto
{
    [Test]
    public void IgeFrom()
    {
        var b = Enumerable.Range(0, 256).Select(p => (byte)p).ToArray();
        var authKey = Core.Cryptography.AuthKey.FromBytes(b);
        var msgK = Enumerable.Repeat(700, 900).Select(p => (byte)p).ToArray();
        var ige = Ige.From(authKey, msgK, true);

        ige.Key.Should().BeEquivalentTo([76,241,99,50,147,17,226,244,43,253,45,24,80,182,72,229,7,156,44,169,169,20,57,184,17,249,200,99,82,153,77,227,]);
        ige.Iv.Should().BeEquivalentTo([245,3,84,214,6,181,147,103,86,175,108,27,209,78,9,243,196,40,118,81,111,226,140,174,183,77,27,220,54,249,218,73,]);
    }
    [Test]
    public void AuthKey()
    {
        var key = Enumerable.Range(0, 256).Select(p => (byte)p).ToArray();
        var sha = SHA1.HashData(key);
        var authKey = Core.Cryptography.AuthKey.FromBytes(key);

        authKey.AuthKeyData.Should().BeEquivalentTo(key);
        authKey.AuxHash.Should().BeEquivalentTo(sha[..8]);
        authKey.KeyId.Should().BeEquivalentTo(sha[^8..]);

        var nonce = authKey.NewNonceHash([1, 2, 3, 4], 1);

        var expectedNonce = SHA1.HashData([1, 2, 3, 4, 1, ..authKey.AuxHash])[4..];
        nonce.Should().BeEquivalentTo(expectedNonce);

        var e = Core.Cryptography.AuthKey.Empty;
        e.AuthKeyData.Should().BeEquivalentTo(Array.Empty<byte>());
        e.AuxHash.Should().BeEquivalentTo(Array.Empty<byte>());
        e.KeyId.Should().BeEquivalentTo(Array.Empty<byte>());
    }
    [Test]
    public void Factorize()
    {
        CryptoHelpers.Random = new FakeGenerator();
        // 15372995644809422249 = 7,2196142234972774607
        CryptoHelpers.Factorize(15372995644809422249).Should().BeEquivalentTo((7, 2196142234972774607));

        // 18255838524116489356 = 4,4563959631029122339
        CryptoHelpers.Factorize(18255838524116489356).Should().BeEquivalentTo((4, 4563959631029122339));

        //5537025579653158815   = 5,1107405115930631763
        CryptoHelpers.Factorize(5537025579653158815).Should().BeEquivalentTo((5, 1107405115930631763));

        //17943101308602765370  = 5,3588620261720553074
        CryptoHelpers.Factorize(17943101308602765370).Should().BeEquivalentTo((5, 3588620261720553074));

        //16140778392020958380  = 5,3228155678404191676
        CryptoHelpers.Factorize(16140778392020958380).Should().BeEquivalentTo((5, 3228155678404191676));

        //10346000269752500875  = 5,2069200053950500175
        CryptoHelpers.Factorize(10346000269752500875).Should().BeEquivalentTo((5, 2069200053950500175));

        //8313689077050055129   = 3067,2710690928284987
        CryptoHelpers.Factorize(8313689077050055129).Should().BeEquivalentTo((3067, 2710690928284987));


        CryptoHelpers.Factorize(0).Should().BeEquivalentTo((1, 1));
        CryptoHelpers.Factorize(1).Should().BeEquivalentTo((1, 1));

        CryptoHelpers.Factorize(ulong.MaxValue).Should().BeEquivalentTo((858993459, 21474836485));

        Console.WriteLine();
    }
    [Test]
    public void Rand()
    {
        var r = new RealRandom();
        r.Random(1,43503).Should().BeGreaterThan(1).And.BeLessThan(43503);
    }
}

class FakeGenerator : IRandomGenerator
{
    public ulong Random(int from = int.MinValue, int to = int.MaxValue) => 5;
}