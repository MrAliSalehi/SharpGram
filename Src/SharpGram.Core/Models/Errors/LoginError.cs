using NetEscapades.EnumGenerators;

namespace SharpGram.Core.Models.Errors;

public class LoginError(LoginErrorType errorType) : ErrorBase
{
    public LoginErrorType ErrorType { get; } = errorType;
    public override string ToString() => ErrorType.ToStringFast();
}

[EnumExtensions]
public enum LoginErrorType
{
    SignupRequired,
    None,
    Timeout,
    InvalidG,
    InvalidP,
    TwoFactorPasswordMissing,
    ChannelIsNotCreated,
    UserAlreadyLoggedIn,
    InvalidKdf
}