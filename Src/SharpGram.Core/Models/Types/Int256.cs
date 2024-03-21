using SharpGram.Core.Common;

namespace SharpGram.Core.Models.Types;

public readonly struct Int256 : IEquatable<Int256>
{
    private int Int1 {get;init;}
    private int Int2 {get;init;}
    private int Int3 {get;init;}
    private int Int4 {get;init;}
    private int Int5 {get;init;}
    private int Int6 {get;init;}
    private int Int7 {get;init;}
    private int Int8 {get;init;}

    public Int256() { }
    public static Int256 GenerateRandom() => FromBytes(Helpers.GenRandomBytes(32));

    public static Int256 FromBytes(byte[] nonce) => new()
    {
        Int1 = BitConverter.ToInt32(nonce.AsSpan()[..4]),
        Int2 = BitConverter.ToInt32(nonce.AsSpan()[4..8]),
        Int3 = BitConverter.ToInt32(nonce.AsSpan()[8..12]),
        Int4 = BitConverter.ToInt32(nonce.AsSpan()[12..16]),
        Int5 = BitConverter.ToInt32(nonce.AsSpan()[16..20]),
        Int6 = BitConverter.ToInt32(nonce.AsSpan()[20..24]),
        Int7 = BitConverter.ToInt32(nonce.AsSpan()[24..28]),
        Int8 = BitConverter.ToInt32(nonce.AsSpan()[28..32]),
    };
    public byte[] TlSerialize() => BitConverter.GetBytes(Int1)
        .Concat(BitConverter.GetBytes(Int2))
        .Concat(BitConverter.GetBytes(Int3))
        .Concat(BitConverter.GetBytes(Int4))
        .Concat(BitConverter.GetBytes(Int5))
        .Concat(BitConverter.GetBytes(Int6))
        .Concat(BitConverter.GetBytes(Int7))
        .Concat(BitConverter.GetBytes(Int8))
        .ToArray();
    public bool Equals(Int256 other) => Int1 == other.Int1 && Int2 == other.Int2 && Int3 == other.Int3 && Int4 == other.Int4 && Int5 == other.Int5 && Int6 == other.Int6 && Int7 == other.Int7 && Int8 == other.Int8;
    public override bool Equals(object? obj) => obj is Int256 other && Equals(other);
    public override int GetHashCode() => HashCode.Combine(Int1, Int2, Int3, Int4, Int5, Int6, Int7, Int8);
    public static bool operator ==(Int256 left, Int256 right) => left.Equals(right);
    public static bool operator !=(Int256 left, Int256 right) => !(left == right);
}