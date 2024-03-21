using SharpGram.Core.Contracts;
using SharpGram.Core.Conversions;

namespace SharpGram.Core.Models.Types;

public struct TlBool(bool innerBool) : ITlSerializable, ITlDeserializable<TlBool>, IEquatable<TlBool>
{
    public bool InnerBool { get; set; } = innerBool;
    public byte[] TlSerialize() => InnerBool.TlSerialize().ToArray();
    public static TlBool TlDeserialize(Deserializer deserializer) => deserializer.As<bool>().Read();

    public static implicit operator bool(TlBool b) => b.InnerBool;
    public static implicit operator TlBool(bool b) => new(b);
    public bool Equals(TlBool other) => InnerBool == other.InnerBool;
    public override bool Equals(object? obj) => obj is TlBool other && Equals(other);
    public override int GetHashCode() => InnerBool.GetHashCode();

    public static bool operator ==(TlBool left, TlBool right) => left.Equals(right);

    public static bool operator !=(TlBool left, TlBool right) => !(left == right);
}