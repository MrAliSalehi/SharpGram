namespace SharpGram.Core.Models;

/// <summary>
/// represents an ID of a RPC message, not to be mistaken with regular high-level message ids
/// </summary>
/// <param name="id"></param>
public readonly struct MsgId(long id) : IEquatable<MsgId>
{
    private readonly long _id = id;
    public static readonly MsgId Zero = new(0);
    public bool Equals(MsgId other) => _id == other._id;
    public override bool Equals(object? obj) => obj is MsgId other && Equals(other);
    public override int GetHashCode() => _id.GetHashCode();
    public static bool operator ==(MsgId left, MsgId right) => left.Equals(right);
    public static bool operator ==(MsgId left, long right) => left._id == right;
    public static bool operator !=(MsgId left, long right) => left._id != right;
    public static bool operator !=(MsgId left, MsgId right) => !(left == right);
    public static implicit operator long(MsgId id) => id._id;
    public static implicit operator MsgId(long id) => new(id);
    public override string ToString() => _id.ToString();
}