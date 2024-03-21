namespace SharpGram.Core.Mtproto.Transport;

public class Abridged : ITransport
{
    public bool Init { get; private set; }

    public void Pack(List<byte> input, List<byte> output)
    {
        ArgumentOutOfRangeException.ThrowIfNotEqual(input.Count % 4, 0);
        if (!Init)
        {
            output.Add(0xef);
            Init = true;
        }

        var len = input.Count / 4;
        if (len < 127)
        {
            output.Add((byte)len);
            output.AddRange(input);
            return;
        }

        output.Add(0x7f);
        var bytes = BitConverter.GetBytes(len);
        output.Add(bytes[0]);
        output.Add(bytes[1]);
        output.Add(bytes[2]);
        output.AddRange(input);
    }
    public int UnPack(List<byte> input, List<byte> output)
    {
        if (input.Count == 0) throw new ArgumentException("input is empty");

        var defaultLen = input[0];
        int headerLen;
        int len;
        if (defaultLen < 127)
        {
            headerLen = 1;
            len = defaultLen;
        }
        else
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(input.Count, 4);
            headerLen = 4;
            var l = new byte[4];
            Array.Copy(input.ToArray(), 1, l, 0, 3);
            len = BitConverter.ToInt32(l, 0);
        }

        len *= 4;

        ArgumentOutOfRangeException.ThrowIfLessThan(input.Count, headerLen + len);

        output.AddRange(input[headerLen.. (headerLen + len)]);
        return headerLen + len;
    }
    public int UnPack(byte[] input, ref byte[] output) => throw new NotImplementedException();
    public void ResetState() => Init = false;
}