using System.Text;
using NetEscapades.EnumGenerators;

namespace SharpGram.Core.Models.Errors;

public sealed class RpcError : ErrorBase
{
    public RpcErrors Msg { get; private init; } = RpcErrors.None;
    public static RpcError FromBytes(byte[] result)
    {
        var raw = Encoding.UTF8.GetString(result[8..]);
        return new RpcError
        {
            Msg = new string(raw.ToCharArray().Where(p => char.IsLetter(p) || p == '_').ToArray()).ParseRpcErr()
        };
    }
    public override string ToString() => Msg.ToStringFast();
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
    InputRequestTooLong,
    SessionPasswordNeeded,
    None
}

internal static class EnumExt
{
    //maybe EnumGenerator can do this? IDK
    public static RpcErrors ParseRpcErr(this string str)
    {
        return str switch
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
            "INPUT_REQUEST_TOO_LONG"            => RpcErrors.InputRequestTooLong,
            "SESSION_PASSWORD_NEEDED"           => RpcErrors.SessionPasswordNeeded,
            _                                   => RpcErrors.None
        };
    }
}