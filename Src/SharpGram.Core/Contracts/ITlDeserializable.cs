using SharpGram.Core.Conversions;

namespace SharpGram.Core.Contracts;

public interface ITlDeserializable<out TSelf>
{
    static abstract TSelf TlDeserialize(Deserializer deserializer);
}