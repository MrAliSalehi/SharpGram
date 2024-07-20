using NetEscapades.EnumGenerators;

namespace SharpGram.Core.Models.Errors;

public class ConnectionError : ErrorBase
{
    public ConnectionErrType ConnectionErr { get; init; } = ConnectionErrType.None;
    public static ConnectionError New(ConnectionErrType t) => new() { ConnectionErr = t };
    public override string ToString() => ConnectionErr.ToStringFast();
    public static implicit operator FatalException(ConnectionError e) => new(e);
}

[Flags, EnumExtensions]
public enum ConnectionErrType
{
    DcNotFound,
    SocketNotConnected,
    Timeout,

    /// <summary>
    /// default value for this enum, if this is set, it means there is no problem
    /// </summary>
    None
}
