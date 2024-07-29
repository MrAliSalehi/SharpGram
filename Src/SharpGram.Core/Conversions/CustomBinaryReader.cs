using OneOf;
using OneOf.Types;
using SharpGram.Core.Common;
using Int128 = SharpGram.Core.Models.Types.Int128;

namespace SharpGram.Core.Conversions;

public class CustomBinaryReader
{
    private byte[] _buffer = [];
    internal int Position { get; private set; }
    internal byte[] Buffer
    {
        get => _buffer;
        set
        {
            Position = 0;
            _buffer = value;
        }
    }
    public byte[] Id { get; private set; } = [];
    private CustomBinaryReader(byte[] b, int pos, bool readId)
    {
        Buffer = b;
        Position = pos;
        Id = [];
        if (readId)
            Id = ReadId(); //auto read
    }
    public CustomBinaryReader() { }
    public void Read(Span<byte> data)
    {
        if (Position + data.Length > Buffer.Length)
            return;

        Buffer[Position..(Position + data.Length)].CopyTo(data);
        Position += data.Length;
    }
    public OneOf<byte, None> ReadOneByte()
    {
        if (Position >= Buffer.Length) return StaticData.None;
        var b = Buffer[Position];
        Position++;
        return b;
    }
    public long ReadLong()
    {
        Span<byte> buffer = stackalloc byte[8];
        Read(buffer);
        return BitConverter.ToInt64(buffer);
    }
    public byte[] ReadId()
    {
        if (Id.Length is not 0)
            return Id;
        var buffer = new byte[4];
        Read(buffer);
        Id = buffer;
        return Id;
    }

    public int ReadInt()
    {
        Span<byte> buffer = stackalloc byte[4];
        Read(buffer);
        return BitConverter.ToInt32(buffer);
    }
    public uint ReadUInt()
    {
        Span<byte> buffer = stackalloc byte[4];
        Read(buffer);
        return BitConverter.ToUInt32(buffer);
    }
    public Int128 ReadInt128()
    {
        Span<byte> buffer = stackalloc byte[16];
        Read(buffer);
        return Int128.FromBytes(buffer);
    }
    /// <summary>
    /// read a string as an array of bytes
    /// </summary>
    /// <returns></returns>
    public byte[] ReadStrAsBytes()
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
    public OneOf<List<long>, None> ReadListOfLong()
    {
        var id = ReadInt();
        if (id != 481674261) //vector ctor
            return StaticData.None;

        var len = ReadInt();

        return Enumerable.Range(0, len).Select(_ => ReadLong()).ToList();
    }
    public static CustomBinaryReader From(byte[] payload, bool readId = true) => new(payload, 0, readId);
    public void Reset()
    {
        Buffer = [];
        Position = 0;
    }
}