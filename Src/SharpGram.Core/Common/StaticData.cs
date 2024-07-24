using System.Threading.Channels;
using OneOf.Types;
using SharpGram.Tl.Constructors.DcOptionNs;

namespace SharpGram.Core.Common;

internal static class StaticData
{
    public static readonly Dictionary<int, DcOption> DcList = new()
    {
        { 1, new DcOption { IpAddress = "149.154.167.50", Port = 443 } }, // prod
        { 2, new DcOption { IpAddress = "149.154.167.40", Port = 443 } }, //test
        { 3, new DcOption { IpAddress = "127.0.0.1", Port = 4430 } }      //local test
    };

    public static None None { get; } = new();
    public static Success Success { get; } = new();

    public static readonly DateTime EpochTime = new(1970, 1, 1, 0, 0, 0, DateTimeKind.Local);

    public static readonly BoundedChannelOptions DefaultChannelOptions = new(1)
    {
        FullMode = BoundedChannelFullMode.Wait,
        SingleWriter = true,
        SingleReader = false,
    };
}