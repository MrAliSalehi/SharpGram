namespace SharpGram.Core.Models.Errors;

public sealed class AuthorizeException(string msg) : Exception(msg)
{
    public static void ThrowServerNonceNotMatched() => throw new AuthorizeException("nonce from the server does not equal to local nonce");
    public static AuthorizeException ThrowDhGenFailed
    {
        get => new("DhGen Failed");
    }
}