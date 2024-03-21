using OneOf;
using SharpGram.Core.Models;
using SharpGram.Core.Models.Errors;

namespace SharpGram.Core.Mtproto.Connections;

/// <summary>
/// Responsible for request modifications in every connection.
/// <see cref="AuthConnection"/> for authorized connections, <see cref="UnAuthConnection"/> for initial and unauthorized connections.
/// <remarks>originally inspired by <a href="https://github.com/Lonami/grammers/tree/master/lib/grammers-mtproto/src/mtp">grammers-mtproto</a></remarks>
/// </summary>
public interface IConnection
{
    OneOf<MsgId, ConnectionError> Wrap(byte[] request, bool isContent);

    List<byte> Pop();
    void ClearBuffer();
    OneOf<RawRpcResponse, ErrorBase> Deserialize(byte[] payload);
}