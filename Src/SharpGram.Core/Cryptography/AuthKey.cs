using System.Security.Cryptography;
using System.Text.Json.Serialization;
using SharpGram.Core.Contracts;
using SharpGram.Core.Conversions;

namespace SharpGram.Core.Cryptography;

public sealed class AuthKey : ITlSerializable, ITlDeserializable<AuthKey>
{
    //256
    public required byte[] AuthKeyData { get; init; }

    //8
    public required byte[] AuxHash { get; init; }

    //8
    public required byte[] KeyId { get; init; }

    public static readonly AuthKey Empty = new() { AuxHash = [], KeyId = [], AuthKeyData = [] };

    [JsonConstructor]
    internal AuthKey() { }
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

    public byte[] TlSerialize()
    {
        List<byte> bytes = [];
        bytes.AddRange(AuthKeyData.TlSerialize());
        bytes.AddRange(AuxHash.TlSerialize());
        bytes.AddRange(KeyId.TlSerialize());
        return bytes.ToArray();
    }
    public static AuthKey TlDeserialize(Deserializer des)
    {
        var data = des.As<byte[]>().Read();
        var aux = des.As<byte[]>().Read();
        var keyId = des.As<byte[]>().Read();
        return new AuthKey
        {
            AuthKeyData = data,
            AuxHash = aux,
            KeyId = keyId
        };
    }
}