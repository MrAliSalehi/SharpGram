using SharpGram.Core.Contracts;
using SharpGram.Core.Conversions;

namespace SharpGram.Core.Models.Types;

public class TlList<T>(List<T> innerList) : ITlDeserializable<TlList<T>>, IEquatable<TlList<T>> where T : ITlDeserializable<T>
{
    public readonly List<T> InnerList = innerList;

    public static TlList<T> TlDeserialize(Deserializer deserializer) => deserializer.Read<T>();

    public static implicit operator TlList<T>(List<T> list) => new(list);
    public static implicit operator List<T>(TlList<T> list) => list.InnerList;
    public bool Equals(TlList<T>? other)
    {
        if (ReferenceEquals(null, other)) return false;
        return ReferenceEquals(this, other) || InnerList.Equals(other.InnerList);
    }
    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((TlList<T>)obj);
    }
    public override int GetHashCode() => InnerList.GetHashCode();
}