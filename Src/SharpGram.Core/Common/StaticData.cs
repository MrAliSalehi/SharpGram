using System.Net;
using OneOf.Types;

namespace SharpGram.Core.Common;

internal static class StaticData
{
    public static readonly Dictionary<int, IPEndPoint> DcList = new()
    {
        { 1, new IPEndPoint(new IPAddress(new byte[] { 149, 154, 175, 53 }), 443) },
        { 2, new IPEndPoint(new IPAddress(new byte[] { 149, 154, 167, 50 }), 443) }, // prod
        { 3, new IPEndPoint(new IPAddress(new byte[] { 149, 154, 175, 100 }), 443) },
        { 4, new IPEndPoint(new IPAddress(new byte[] { 149, 154, 167, 92 }), 443) },
        { 5, new IPEndPoint(new IPAddress(new byte[] { 91, 108, 56, 190 }), 443) },
        { 6, new IPEndPoint(new IPAddress(new byte[] { 149, 154, 167, 40 }), 443) }, //test
        { 7, new IPEndPoint(new IPAddress(new byte[] { 127, 0, 0, 1 }), 4430) },     //local test
    };
    public static None None { get; } = new();
    public static Success Success { get; } = new();

    public static readonly DateTime EpochTime = new(1970, 1, 1, 0, 0, 0, DateTimeKind.Local);

}