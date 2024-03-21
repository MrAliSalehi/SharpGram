using System.Security.Cryptography;

namespace SharpGram.Core.Cryptography;

public sealed class AuthKey
{
    //256
    public required byte[] AuthKeyData { get; init; }

    //8
    public required byte[] AuxHash { get; init; }

    //8
    public required byte[] KeyId { get; init; }

    public static readonly AuthKey Empty = new() { AuxHash = [], KeyId = [], AuthKeyData = [] };

    public static AuthKey FromBytes(byte[] data)
    {
        var sha = SHA1.HashData(data);
        return new AuthKey
        {
            AuthKeyData = data,
            AuxHash = sha[..8],
            KeyId = sha[^8..]
        };
    }
    public byte[] NewNonceHash(IEnumerable<byte> newNonce, byte number)
    {
        var buffer = new List<byte>();
        buffer.AddRange(newNonce);
        buffer.Add(number);
        buffer.AddRange(AuxHash);
        return SHA1.HashData(buffer.ToArray())[4..];
    }
}