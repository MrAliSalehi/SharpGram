using System.Numerics;
using System.Security.Cryptography;

namespace SharpGram.Core.Cryptography;

public class RsaEncryption
{
    private static readonly byte[] DefaultIv = Enumerable.Repeat((byte)0, 32).ToArray();

    public BigInteger N { get; set; }
    public BigInteger E { get; set; }
    public RsaEncryption(string pubKey)
    {
        using var rsa = RSA.Create();
        rsa.ImportFromPem(pubKey);
        var param = rsa.ExportParameters(false);
        N = new BigInteger(param.Modulus!, true, true);
        E = new BigInteger(param.Exponent!, true, true);
    }

    public RsaEncryption(string n, string e)
    {
        N = BigInteger.Parse(n);
        E = BigInteger.Parse(e);
    }

    public IEnumerable<byte> Encrypt(byte[] data, byte[] random)
    {
        var dataWithPadding = data.ToList();
        dataWithPadding.AddRange(random[..(192 - data.Length)]);

        var dataPadReversed = dataWithPadding.Count < 256 ? stackalloc byte[dataWithPadding.Count] : new byte[dataWithPadding.Count];
        dataWithPadding.CopyTo(dataPadReversed);
        dataPadReversed.Reverse();

        BigInteger integerAesKey;
        var attempts = 0;
        var ige = new Ige(iv: DefaultIv);
        retry:
        while (true)
        {
            if (192 + 32 * attempts + 32 > random.Length) //shouldn't happen
            {
                random = RandomNumberGenerator.GetBytes(256);
                attempts--;
                goto retry;
            }

            var tempKey = random[(192 + 32 * attempts)..(192 + 32 * attempts + 32)];


            var dataHash = new List<byte>();
            dataHash.AddRange(dataPadReversed);
            var x1 = SHA256.HashData(tempKey.Concat(dataWithPadding).ToArray());
            dataHash.AddRange(x1);

            ige.Key = tempKey;
            var aesEnc = ige.Encrypt(dataHash.ToArray());

            var tempKeyXor = ((byte[])tempKey.Clone()).Zip(SHA256.HashData(aesEnc)).Select(t => t.First ^= t.Second);

            var aesKeyEnc = tempKeyXor.Concat(aesEnc).ToArray();

            integerAesKey = new BigInteger(aesKeyEnc, true, true);
            if (integerAesKey < N)
                break;

            attempts++;
        }

        var enc = BigInteger.ModPow(integerAesKey, E, N);

        var x = enc.ToByteArray(true, true).ToList();
        while (x.Count < 256)
            x = x.Prepend((byte)0).ToList();

        return x;

    }
}