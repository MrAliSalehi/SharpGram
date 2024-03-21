using System.Buffers.Binary;

namespace SharpGram.Core.Mtproto.Transport;

public sealed class Intermediate : ITransport
{
    public bool FirstPacket { get; private set; } = true;
    private static readonly byte[] InitBytes = BitConverter.GetBytes(0xee_ee_ee_ee);
    public void Pack(List<byte> input,List<byte> output)
    {
        ArgumentOutOfRangeException.ThrowIfNotEqual(input.Count % 4, 0);
        if (FirstPacket)
        {
            output.InsertRange(0, InitBytes);
            FirstPacket = false; // only the very first req needs to have 0xee_ee_ee_ee
        }
        output.AddRange(BitConverter.GetBytes(input.Count));
        output.AddRange(input);
    }
    public int UnPack(List<byte> input, List<byte> output)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(input.Count, 4);
        var len = BinaryPrimitives.ReadInt32LittleEndian(input[..4].ToArray());
        ArgumentOutOfRangeException.ThrowIfLessThan(input.Count - 4, len);
        output.AddRange(input[4..(4 + len)]);
        return len + 4;
    }
    public int UnPack(byte[] input, ref byte[] output)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(input.Length, 4);
        var len = BinaryPrimitives.ReadInt32LittleEndian(input);
        ArgumentOutOfRangeException.ThrowIfLessThan(input.Length - 4, len);

        var d = input[4..(4 + len)];

        Array.Resize(ref output, d.Length);
        for (var i = 0; i < d.Length; i++)
            output[i] = d[i];

        return len + 4;
    }
    public void ResetState() => FirstPacket = true;
}