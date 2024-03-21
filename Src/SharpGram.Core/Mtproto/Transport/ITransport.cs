namespace SharpGram.Core.Mtproto.Transport;

/// <summary>
/// Responsible for <a href="https://core.telegram.org/mtproto#transport">Transport Layer</a>.
/// packing and unpacking a request for the implemented ( <see cref="Intermediate"/>, <see cref="Abridged"/>, <see cref="Full"/>) transport layer.
/// <remarks>this design was inspired by <a href="https://github.com/Lonami/grammers/tree/master/lib/grammers-mtproto/src/transport">grammers-mtproto</a></remarks>
/// </summary>
public interface ITransport
{
    void Pack(List<byte> input, List<byte> output);
    int UnPack(List<byte> input, List<byte> output);
    int UnPack(byte[] input, ref byte[] output);
    void ResetState();
}
