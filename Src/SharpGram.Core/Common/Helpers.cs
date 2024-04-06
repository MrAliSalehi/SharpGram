using System.Collections.Concurrent;
using System.Numerics;
using System.Security.Cryptography;
using OneOf;
using SharpGram.Core.Models;
using SharpGram.Core.Models.Errors;
using Crc32 = System.IO.Hashing.Crc32;

namespace SharpGram.Core.Common;

internal static class Helpers
{
    private static readonly Crc32 Crc32 = new();
    public static byte[] UnsafeUnwrap(this OneOf<RawRpcResponse, ErrorBase> d) => d.AsT0.RpcResult[0].result.AsT0;
    public static void CheckInRange<T>(this T self, T first, T second) where T : INumber<T> => ArgumentOutOfRangeException.ThrowIfNotEqual(first < self && self < second, true);
    //copied from https://github.com/wiz0u/WTelegramClient/blob/master/src/Helpers.cs
    internal static byte[] ToBigEndian(ulong value)
    {
        var i = 1;
        for (var temp = value; (temp >>= 8) != 0;) i++;
        var result = new byte[i];
        for (; --i >= 0; value >>= 8)
            result[i] = (byte)value;
        return result;
    }
    public static byte[] GenRandomBytes(int len)
    {
        var buff = new byte[len];
        RandomNumberGenerator.Fill(buff);
        return buff;
    }
    public static uint ComputeCrc32(byte[] data)
    {
        Crc32.Reset();
        Crc32.Append(data);
        return Crc32.GetCurrentHashAsUInt32();
    }

    public static void AddRange<T>(this ConcurrentBag<T> bag, List<T> items)
    {
        foreach (var item in items)
            bag.Add(item);
    }
    public static bool IsOneOf(this Span<byte> first, params byte[][] other)
    {
        foreach (var x in other)
            if (first.SequenceEqual(x))
                return true;
        return false;
    }
}