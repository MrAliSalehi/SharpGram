using SharpGram.Core.Contracts;
using SharpGram.Core.Conversions;

namespace SharpGram.Core.Models.Types;

public struct TlLong(long t) : ITlDeserializable<TlLong>, IEquatable<TlLong>
{
    public long InnerInt { get; set; } = t;
    public static TlLong TlDeserialize(Deserializer deserializer) => deserializer.As<int>().Read();

    public static implicit operator long(TlLong t) => t.InnerInt;
    public static implicit operator TlLong(int t) => new(t);
    public bool Equals(TlLong other) => InnerInt == other.InnerInt;
    public override bool Equals(object? obj) => obj is TlInt other && Equals(other);
    public override int GetHashCode() => InnerInt.GetHashCode();

    public static bool operator ==(TlLong left, TlLong right) => left.Equals(right);

    public static bool operator !=(TlLong left, TlLong right) => !(left == right);
}