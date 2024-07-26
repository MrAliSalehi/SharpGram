using FluentAssertions;
using SharpGram.Core.Conversions;

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
    [Test]
    public void Serialize()
    {
        var k = GetAuthKey();
        var ser = k.TlSerialize();

        var de = Core.Cryptography.AuthKey.TlDeserialize(Deserializer.New(ser));

        byte[] expectedSer = [254, 0, 1, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 182, 183, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 8, 73, 22, 214, 189, 183, 247, 142, 104, 0, 0, 0, 8, 50, 209, 88, 110, 164, 87, 223, 200, 0, 0, 0];
        byte[] expectedAuxHash = [73, 22, 214, 189, 183, 247, 142, 104];
        byte[] expectedAuthKeyData = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 182, 183, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255,];
        byte[] expectedKeyId = [50, 209, 88, 110, 164, 87, 223, 200,];

        ser.Should().BeEquivalentTo(expectedSer);
        de.AuxHash.Should().BeEquivalentTo(expectedAuxHash);
        de.AuthKeyData.Should().BeEquivalentTo(expectedAuthKeyData);
        de.KeyId.Should().BeEquivalentTo(expectedKeyId);
    }
}