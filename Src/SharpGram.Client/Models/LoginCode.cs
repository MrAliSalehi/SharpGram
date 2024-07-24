namespace SharpGram.Client.Models;

public readonly struct LoginCode(string code)
{
    private readonly string _code = code;
    public static implicit operator string(LoginCode code) => code._code;
    public static implicit operator LoginCode(string code) => new(code);
    /// <summary>
    /// test Dc number repeated 5 times
    /// </summary>
    public static readonly LoginCode TestCode = "22222";
}