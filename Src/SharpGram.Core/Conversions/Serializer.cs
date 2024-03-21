using System.Text;
using SharpGram.Core.Contracts;

namespace SharpGram.Core.Conversions;

public static class Serializer
{
    private static readonly byte[] Empty = [0];
    public static byte[] TlSerialize(this long data) => BitConverter.GetBytes(data);
    public static byte[] TlSerialize(this long? data) => data is null ? Empty : data.Value.TlSerialize();
    public static byte[] TlSerialize(this ulong data) => BitConverter.GetBytes(data);

    public static IEnumerable<byte> TlSerialize(this uint data) => BitConverter.GetBytes(data);
    public static IEnumerable<byte> TlSerialize(this double data) => BitConverter.GetBytes(data);
    public static IEnumerable<byte> TlSerialize(this double? data) => data is null ? Empty : BitConverter.GetBytes(data.Value);

    public static IEnumerable<byte> TlSerialize(this int data) => BitConverter.GetBytes(data);
    public static IEnumerable<byte> TlSerialize(this int? data) => data is null ? Empty : BitConverter.GetBytes(data.Value);

    public static IEnumerable<byte> TlSerialize(this bool data) => (data ? 0x997275b5 : 0xbc799737).TlSerialize();

    public static IEnumerable<byte> TlSerialize(this byte[] data) => data.ToList().TlSerialize();
    public static IEnumerable<byte> TlSerialize(this List<byte[]> list)
    {
        var bytes = new List<byte>();
        bytes.AddRange(VectorByteId);
        bytes.AddRange(list.Count.TlSerialize());
        foreach (var item in list)
            bytes.AddRange(item.TlSerialize());
        return bytes;
    }
    public static IEnumerable<byte> TlSerialize(this List<byte> data)
    {
        var result = new List<byte>();
        int len;
        if (data.Count <= 253)
        {
            result.Add((byte)data.Count);
            len = data.Count + 1;
        }
        else
        {
            result.AddRange([254, (byte)(data.Count & 0xff), (byte)((data.Count >> 8) & 0xff), (byte)((data.Count >> 16) & 0xff)]);
            len = data.Count;
        }

        var p = (4 - len % 4) % 4;
        result.AddRange(data);

        result.AddRange(Enumerable.Repeat((byte)0, p));

        return result;
    }

    //[28, 181, 196, 21]  481674261
    private static readonly byte[] VectorByteId = [21, 196, 181, 28];
    public static IEnumerable<byte> TlSerialize<T>(this List<T> list) where T : ITlSerializable
    {
        var bytes = new List<byte>();
        bytes.AddRange(VectorByteId);
        bytes.AddRange(list.Count.TlSerialize());
        foreach (var item in list)
            bytes.AddRange(item.TlSerialize());
        return bytes;
    }
    public static IEnumerable<byte> TlSerialize(this List<int> list)
    {
        var bytes = new List<byte>();
        bytes.AddRange(VectorByteId);
        bytes.AddRange(list.Count.TlSerialize());
        foreach (var item in list)
            bytes.AddRange(item.TlSerialize());
        return bytes;
    }
    public static IEnumerable<byte> TlSerialize(this List<string> list)
    {
        var bytes = new List<byte>();
        bytes.AddRange(VectorByteId);
        bytes.AddRange(list.Count.TlSerialize());
        foreach (var item in list)
            bytes.AddRange(item.TlSerialize());
        return bytes;
    }
    public static IEnumerable<byte> TlSerialize(this string str) => Encoding.UTF8.GetBytes(str).ToList().TlSerialize();
    //TODO fix unsupported types
    public static IEnumerable<byte> TlSerialize(this object data) => throw new NotImplementedException();
    public static IEnumerable<byte> TlSerialize(this List<long> list)
    {
        var bytes = new List<byte>();
        bytes.AddRange(VectorByteId);
        bytes.AddRange(list.Count.TlSerialize());
        foreach (var item in list)
            bytes.AddRange(item.TlSerialize());
        return bytes;
    }
}