using FluentAssertions;

namespace SharpGram.Tests;

public class AuthKey
{
    private static Core.Cryptography.AuthKey GetAuthKey() => Core.Cryptography.AuthKey.FromBytes(Enumerable.Range(0, 256).Select(p => (byte)p).ToArray());

    private static IEnumerable<byte> GetNewNonce() => Enumerable.Range(0, 32).Select(p => (byte)p);

    [Test]
    public void AuthKeyData()
    {
        var authKey = GetAuthKey();
        authKey.AuthKeyData.Should().BeEquivalentTo(Enumerable.Range(0, 256).Select(p => (byte)p).ToArray());
    }
    [Test]
    public void AuxHash()
    {
        var authKey = GetAuthKey();
        var ex = new byte[] { 73, 22, 214, 189, 183, 247, 142, 104 };
        authKey.AuxHash.Should().BeEquivalentTo(ex);
    }

    [Test]
    public void AuthKeyId()
    {
        var authKey = GetAuthKey();
        var ex = new byte[] { 50, 209, 88, 110, 164, 87, 223, 200 };
        authKey.KeyId.Should().BeEquivalentTo(ex);
    }

    [Test]
    public void NewNonceHash1()
    {
        var authKey = GetAuthKey();
        var newNonce = GetNewNonce();
        var ex = new byte[] { 194, 206, 210, 179, 62, 89, 58, 85, 210, 127, 74, 93, 171, 238, 124, 103 };
        authKey.NewNonceHash(newNonce, 1).Should().BeEquivalentTo(ex);
    }

    [Test]
    public void NewNonceHash2()
    {
        var authKey = GetAuthKey();
        var newNonce = GetNewNonce();
        var ex = new byte[] { 244, 49, 142, 133, 189, 47, 243, 190, 132, 217, 254, 252, 227, 220, 227, 159 };
        authKey.NewNonceHash(newNonce, 2).Should().BeEquivalentTo(ex);
    }

    [Test]
    public void NewNonceHash3()
    {
        var authKey = GetAuthKey();
        var newNonce = GetNewNonce();
        var ex = new byte[] { 75, 249, 215, 179, 125, 180, 19, 238, 67, 29, 40, 81, 118, 49, 203, 61 };
        authKey.NewNonceHash(newNonce, 3).Should().BeEquivalentTo(ex);
    }
}