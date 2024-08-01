using System.Buffers.Binary;
using System.Diagnostics;
using System.Numerics;
using System.Text;
using OneOf;
using OneOf.Types;
using SharpGram.Core.Common;
using SharpGram.Core.Contracts;
using SharpGram.Core.Models.Errors;

namespace SharpGram.Core.Conversions;

public sealed class Deserializer : IDeserializer<int>, IDeserializer<uint>, IDeserializer<string>, IDeserializer<bool>, IDeserializer<long>, IDeserializer<byte[]>
{
    private int Position { get; set; }
    private byte[] Buffer { get; set; }

    public byte[] LastId { get; set; } = [];
    private Deserializer(byte[] b, int pos)
    {
        Buffer = b;
        Position = pos;
    }
    public static Deserializer New(byte[] payload) => new(payload, 0);
    public byte[] ReadId()
    {
        var buffer = new byte[4];
        Read(buffer);
        LastId = buffer;
        return buffer;
    }
    public bool IsCorrectId(byte[] expectedId) => LastId.SequenceEqual(expectedId) || ReadId().SequenceEqual(expectedId);
    public IDeserializer<T> As<T>() => (this as IDeserializer<T>)!;
    int IDeserializer<int>.Read()
    {
        Span<byte> buffer = stackalloc byte[4];
        Read(buffer);
        return BinaryPrimitives.ReadInt32LittleEndian(buffer);
    }
    uint IDeserializer<uint>.Read()
    {
        Span<byte> buffer = stackalloc byte[4];
        Read(buffer);
        return BinaryPrimitives.ReadUInt32LittleEndian(buffer);
    }
    bool IDeserializer<bool>.Read() => (this as IDeserializer<uint>).Read() switch
    {
        0x997275b5 => true,
        0xbc799737 => false,
        _          => throw new UnreachableException("this shouldn't happen")
    };
    long IDeserializer<long>.Read()
    {
        Span<byte> buffer = stackalloc byte[8];
        Read(buffer);
        return BinaryPrimitives.ReadInt64LittleEndian(buffer);
    }
    public List<T> Read<T>() where T : ITlDeserializable<T>
    {
        if (((IDeserializer<uint>)this).Read() != 0x1cb5c415) throw DeserializationException.InvalidCtor;
        var len = (int)((IDeserializer<uint>)this).Read();

        return Enumerable.Range(0, len).Select(_ => T.TlDeserialize(this)).ToList();
    }
    public T ReadObject<T>() where T : ITlDeserializable<T> => T.TlDeserialize(this);
    public List<T> ReadNumbers<T>() where T : INumber<T>
    {
        if (((IDeserializer<uint>)this).Read() != 0x1cb5c415) throw DeserializationException.InvalidCtor;
        var len = (int)((IDeserializer<uint>)this).Read();
        var r = (this as IDeserializer<T>)!;
        return Enumerable.Range(0, len).Select(_ => r.Read()).ToList();
    }
    public List<byte[]> ReadByteArrayList()
    {
        if (((IDeserializer<uint>)this).Read() != 0x1cb5c415) throw DeserializationException.InvalidCtor;
        var len = (int)((IDeserializer<uint>)this).Read();
        var r = this as IDeserializer<byte[]>;
        return Enumerable.Range(0, len).Select(_ => r.Read()).ToList();
    }
    public List<string> ReadStrings()
    {
        if (((IDeserializer<uint>)this).Read() != 0x1cb5c415) throw DeserializationException.InvalidCtor;
        var len = (int)((IDeserializer<uint>)this).Read();
        var r = this as IDeserializer<string>;
        return Enumerable.Range(0, len).Select(_ => r.Read()).ToList();
    }
    byte[] IDeserializer<byte[]>.Read()
    {
        var tryFirst = ReadOneByte();
        if (tryFirst.IsT1) return [];
        var first = tryFirst.AsT0;

        int len, padding;
        if (first == 254)
        {
            Span<byte> buf = stackalloc byte[3];
            Read(buf);
            len = buf[0] | (buf[1] << 8) | (buf[2] << 16);
            padding = len % 4;
        }
        else
        {
            len = first;
            padding = (len + 1) % 4;
        }

        var result = new byte[len];
        Read(result);
        if (padding <= 0) return result;

        foreach (var _ in Enumerable.Range(0, 4 - padding))
            ReadOneByte();

        return result;
    }
    string IDeserializer<string>.Read() => Encoding.UTF8.GetString(((IDeserializer<byte[]>)this).Read());

    public byte[] ReadToEnd() => Buffer[Position..];
    public void Read(Span<byte> data)
    {
        if (Position + data.Length > Buffer.Length)
            return;

        Buffer[Position..(Position + data.Length)].CopyTo(data);
        Position += data.Length;
    }
    private OneOf<byte, None> ReadOneByte()
    {
        if (Position >= Buffer.Length) return StaticData.None;
        var b = Buffer[Position];
        Position++;
        return b;
    }
}

public interface IDeserializer<out T>
{
    T Read();
}