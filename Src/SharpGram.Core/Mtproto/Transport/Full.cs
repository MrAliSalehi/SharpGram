using System.Buffers.Binary;
using SharpGram.Core.Common;

namespace SharpGram.Core.Mtproto.Transport;

public class Full : ITransport
{
    public int SendSeq { get; private set; }
    public int ReceiveSeq { get; private set; }

    public void Pack(List<byte> input, List<byte> output)
    {
        ArgumentOutOfRangeException.ThrowIfNotEqual(input.Count % 4, 0);
        var len = input.Count + 4 + 4 + 4;
        output.Capacity += len;
        var start = output.Count;

        output.AddRange(BitConverter.GetBytes(len));
        output.InsertRange(start + 4 , BitConverter.GetBytes(SendSeq));
        output.AddRange(input);

        var crc = Helpers.ComputeCrc32(output.GetRange(start, len - 4).ToArray());

        output.InsertRange(start + len - 4 , BitConverter.GetBytes(crc));
        SendSeq++;
    }
    public int UnPack(List<byte> input, List<byte> output)
    {
        ArgumentOutOfRangeException.ThrowIfNotEqual(input.Count % 4, 0);
        var totalLen = input.Count;
        var len = BinaryPrimitives.ReadInt32LittleEndian(input[..4].ToArray());

        ArgumentOutOfRangeException.ThrowIfLessThan(len, 12);
        ArgumentOutOfRangeException.ThrowIfLessThan(totalLen, len);

        var seq = BinaryPrimitives.ReadInt32LittleEndian(input[4..8].ToArray());
        ArgumentOutOfRangeException.ThrowIfNotEqual(seq, ReceiveSeq);

        var crc = BinaryPrimitives.ReadUInt32LittleEndian(input[(len -4)..len].ToArray());

        var validCrc = Helpers.ComputeCrc32(input[..(len - 4)].ToArray());

        ArgumentOutOfRangeException.ThrowIfNotEqual(crc, validCrc);

        ReceiveSeq++;
        output.AddRange(input[8..(len - 4)]);
        return len;
    }
    //todo impl unpack
    public int UnPack(byte[] input,ref byte[] output) => throw new NotImplementedException();

    public void ResetState()
    {
        ReceiveSeq = 0;
        SendSeq = 0;
    }
}