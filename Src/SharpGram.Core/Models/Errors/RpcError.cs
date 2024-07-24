using System.Text;
using NetEscapades.EnumGenerators;

namespace SharpGram.Core.Models.Errors;

public sealed class RpcError : ErrorBase
{
    public RpcErrorTypes Msg { get; private set; } = RpcErrorTypes.None;
    public required string RawMessage { get; set; }
    public uint Value { get; set; }
    public static RpcError FromBytes(byte[] result)
    {
        var raw = Encoding.UTF8.GetString(result[8..]);
        var msg = new string(raw.ToCharArray().Where(p => char.IsLetter(p) || p == '_').ToArray()).Trim();
        var rp = new RpcError { RawMessage = msg };
        if (msg.Contains("PHONE_MIGRATE_") || msg.Contains("NETWORK_MIGRATE_") || msg.Contains("FLOOD_WAIT_"))
        {
            if (!uint.TryParse(msg.Split('_')[2], out var val))
                throw new FatalException($"could not parse the value coming from the error: {msg}");
            rp.Value = val;
        }

        rp.Msg = msg.ParseRpcErr();
        return rp;
    }
    public override string ToString() => Msg.ToStringFast();
}

//TODO add more errors
[EnumExtensions]
public enum RpcErrorTypes
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
    Migrate,
    Flood,
    AuthKeyUnregistered,
    None
}

internal static class EnumExt
{
    //maybe EnumGenerator can do this? IDK
    public static RpcErrorTypes ParseRpcErr(this string str)
    {
        if (str.Contains("MIGRATE")) return RpcErrorTypes.Migrate;
        if (str.Contains("FLOOD")) return RpcErrorTypes.Flood;
        return str switch
        {
            "PHONE_CODE_EMPTY"                  => RpcErrorTypes.PhoneCodeEmpty,
            "PHONE_CODE_EXPIRED"                => RpcErrorTypes.PhoneCodeExpired,
            "PHONE_CODE_HASH_EMPTY"             => RpcErrorTypes.PhoneCodeHashEmpty,
            "SEND_CODE_UNAVAILABLE"             => RpcErrorTypes.SendCodeUnavailable,
            "API_ID_INVALID"                    => RpcErrorTypes.ApiIdInvalid,
            "API_ID_PUBLISHED_FLOOD"            => RpcErrorTypes.ApiIdPublishedFlood,
            "AUTH_RESTART"                      => RpcErrorTypes.AuthRestart,
            "PHONE_NUMBER_APP_SIGNUP_FORBIDDEN" => RpcErrorTypes.PhoneNumberAppSignupForbidden,
            "PHONE_NUMBER_BANNED"               => RpcErrorTypes.PhoneNumberBanned,
            "PHONE_NUMBER_FLOOD"                => RpcErrorTypes.PhoneNumberFlood,
            "PHONE_NUMBER_INVALID"              => RpcErrorTypes.PhoneNumberInvalid,
            "PHONE_PASSWORD_FLOOD"              => RpcErrorTypes.PhonePasswordFlood,
            "PHONE_PASSWORD_PROTECTED"          => RpcErrorTypes.PhonePasswordProtected,
            "SMS_CODE_CREATE_FAILED"            => RpcErrorTypes.SmsCodeCreateFailed,
            "INPUT_REQUEST_TOO_LONG"            => RpcErrorTypes.InputRequestTooLong,
            "SESSION_PASSWORD_NEEDED"           => RpcErrorTypes.SessionPasswordNeeded,
            "AUTH_KEY_UNREGISTERED"             => RpcErrorTypes.AuthKeyUnregistered,
            _                                   => RpcErrorTypes.None
        };
    }
}