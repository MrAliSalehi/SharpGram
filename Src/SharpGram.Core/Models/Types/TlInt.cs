using SharpGram.Core.Contracts;
using SharpGram.Core.Conversions;

namespace SharpGram.Core.Models.Types;

public struct TlInt(int t) : ITlDeserializable<TlInt>, IEquatable<TlInt>
{
    public int InnerInt { get; set; } = t;
    public static TlInt TlDeserialize(Deserializer deserializer) => deserializer.As<int>().Read();

    public static implicit operator int(TlInt t) => t.InnerInt;
    public static implicit operator TlInt(int t) => new(t);
    public bool Equals(TlInt other) => InnerInt == other.InnerInt;
    public override bool Equals(object? obj) => obj is TlInt other && Equals(other);
    public override int GetHashCode() => InnerInt;

    public static bool operator ==(TlInt left, TlInt right) => left.Equals(right);

    public static bool operator !=(TlInt left, TlInt right) => !(left == right);
}