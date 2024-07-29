using SharpGram.Core.Common;

namespace SharpGram.Core.Models.Types;

public readonly struct Int128 : IEquatable<Int128>
{
    internal int Int1 {get; init;}
    internal int Int2 {get; init;}
    internal int Int3 {get; init;}
    internal int Int4 {get; init;}
    public Int128() { }

    public static Int128 GenerateRandom() => FromBytes(Helpers.GenRandomBytes(16));

    public static Int128 FromBytes(byte[] nonce) => new()
    {
        Int1 = BitConverter.ToInt32(nonce.AsSpan()[..4]),
        Int2 = BitConverter.ToInt32(nonce.AsSpan()[4..8]),
        Int3 = BitConverter.ToInt32(nonce.AsSpan()[8..12]),
        Int4 = BitConverter.ToInt32(nonce.AsSpan()[12..16]),
    };
    public static Int128 FromBytes(Span<byte> nonce) => new()
    {
        Int1 = BitConverter.ToInt32(nonce[..4]),
        Int2 = BitConverter.ToInt32(nonce[4..8]),
        Int3 = BitConverter.ToInt32(nonce[8..12]),
        Int4 = BitConverter.ToInt32(nonce[12..16]),
    };
    public byte[] ToBytes() => BitConverter.GetBytes(Int1)
        .Concat(BitConverter.GetBytes(Int2))
        .Concat(BitConverter.GetBytes(Int3))
        .Concat(BitConverter.GetBytes(Int4))
        .ToArray();
    public byte[] TlSerialize() => ToBytes();
    public bool Equals(Int128 other) => Int1 == other.Int1 && Int2 == other.Int2 && Int3 == other.Int3 && Int4 == other.Int4;
    public override bool Equals(object? obj) => obj is Int128 other && Equals(other);
    public override int GetHashCode() => HashCode.Combine(Int1, Int2, Int3, Int4);
    public static bool operator ==(Int128 left, Int128 right) => left.Equals(right);
    public static bool operator !=(Int128 left, Int128 right) => !(left == right);
}