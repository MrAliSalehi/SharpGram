namespace SharpGram.Core.Models.Errors;

public class DeserializationException(string msg) : Exception(msg)
{
    public static readonly DeserializationException InvalidCtor = new("Invalid Constructor");
}