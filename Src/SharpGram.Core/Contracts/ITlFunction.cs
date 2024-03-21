using SharpGram.Core.Conversions;

namespace SharpGram.Core.Contracts;

/// <summary>
/// represents a <a href= "https://core.telegram.org/methods">Telegram Function</a>.
/// Tl Functions should all implement <see cref="ITlSerializable"/>.
/// </summary>
/// <typeparam name="T">Return type of this function, it has to be <see cref="ITlDeserializable{TSelf}"/>.</typeparam>
public abstract class TlFunction<T> : ITlSerializable where T : ITlDeserializable<T>
{
    public virtual T DeserializeResponse(Deserializer des) => T.TlDeserialize(des);
    public abstract byte[] TlSerialize();
}
