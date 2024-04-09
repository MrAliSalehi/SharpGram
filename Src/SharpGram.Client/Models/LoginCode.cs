namespace EasyTg.Client.Models;

public readonly struct LoginCode(string code)
{
    private readonly string _code = code;
    public static implicit operator string(LoginCode code) => code._code;
    public static implicit operator LoginCode(string code) => new(code);
}