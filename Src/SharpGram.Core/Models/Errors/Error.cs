using System.Text;
using NetEscapades.EnumGenerators;
using OneOf;

namespace SharpGram.Core.Models.Errors;

/// <summary>
/// basic error type
/// </summary>
public abstract class ErrorBase
{
    public static implicit operator FatalException(ErrorBase e) => new(e);
    public bool Is(TransportErrType te) => this is TransportError e && e.TransportErr == te;
    public bool Is(ConnectionErrType c) => this is ConnectionError connectionError && connectionError.ConnectionErr == c;
}

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

public sealed class RpcError : ErrorBase
{
    public RpcErrors Msg { get; private init; } = RpcErrors.None;
    public static RpcError FromBytes(byte[] result) => new()
    {
        Msg = Encoding.UTF8.GetString(result[8..]).ParseRpcErr()
    };
}

//TODO add more errors
[EnumExtensions]
public enum RpcErrors
{
    PhoneCodeEmpty,
    PhoneCodeExpired,
    PhoneCodeHashEmpty,
    SendCodeUnavailable,
    ApiIdInvalid,
    ApiIdPublishedFlood,
    AuthRestart,
    PhoneNumberAppSignupForbidden,
    PhoneNumberBanned,
    PhoneNumberFlood,
    PhoneNumberInvalid,
    PhonePasswordFlood,
    PhonePasswordProtected,
    SmsCodeCreateFailed,
    None
}

internal static class EnumExt
{
    //maybe EnumGenerator can do this? IDK
    public static RpcErrors ParseRpcErr(this string str) => str switch
    {
        "PHONE_CODE_EMPTY"                  => RpcErrors.PhoneCodeEmpty,
        "PHONE_CODE_EXPIRED"                => RpcErrors.PhoneCodeExpired,
        "PHONE_CODE_HASH_EMPTY"             => RpcErrors.PhoneCodeHashEmpty,
        "SEND_CODE_UNAVAILABLE"             => RpcErrors.SendCodeUnavailable,
        "API_ID_INVALID"                    => RpcErrors.ApiIdInvalid,
        "API_ID_PUBLISHED_FLOOD"            => RpcErrors.ApiIdPublishedFlood,
        "AUTH_RESTART"                      => RpcErrors.AuthRestart,
        "PHONE_NUMBER_APP_SIGNUP_FORBIDDEN" => RpcErrors.PhoneNumberAppSignupForbidden,
        "PHONE_NUMBER_BANNED"               => RpcErrors.PhoneNumberBanned,
        "PHONE_NUMBER_FLOOD"                => RpcErrors.PhoneNumberFlood,
        "PHONE_NUMBER_INVALID"              => RpcErrors.PhoneNumberInvalid,
        "PHONE_PASSWORD_FLOOD"              => RpcErrors.PhonePasswordFlood,
        "PHONE_PASSWORD_PROTECTED"          => RpcErrors.PhonePasswordProtected,
        "SMS_CODE_CREATE_FAILED"            => RpcErrors.SmsCodeCreateFailed,
        _                                   => RpcErrors.None
    };
}