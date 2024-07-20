using NetEscapades.EnumGenerators;

namespace SharpGram.Core.Models.Errors;

public sealed class TransportError : ConnectionError, IEquatable<TransportError>
{
    public TransportErrType TransportErr { get; private init; } = TransportErrType.None;
    public static TransportError New(TransportErrType t) => new() { TransportErr = t };
    public bool Equals(TransportError? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return TransportErr == other.TransportErr;
    }
    public override bool Equals(object? obj) => ReferenceEquals(this, obj) || obj is TransportError other && Equals(other);
    public override int GetHashCode() => (int)TransportErr;
    public override string ToString() => TransportErr.ToStringFast();
    public static implicit operator FatalException(TransportError e) => new(e);
}
[EnumExtensions]
public enum TransportErrType
{
    BadTransport,
    BadMsgLen,
    BadAuthKey,
    SmallMsg,
    None,
    TransportErr,
    BadMsgId,
    AckWithoutResult,
    RetryRequest,
    BufferNotEmpty
}
