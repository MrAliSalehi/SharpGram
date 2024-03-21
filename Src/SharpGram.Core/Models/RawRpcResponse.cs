using OneOf;
using SharpGram.Core.Models.Errors;

namespace SharpGram.Core.Models;

/// <summary>
/// response from an rpc query, can be basically anything from MTPROTO.TL
/// </summary>
public sealed class RawRpcResponse
{
    /// <summary>
    /// <b>id</b> in this context is the id of original request so it can be mapped to its response.
    /// <b>result can be either <see cref="ErrorBase"/> or raw byte array</b>
    /// </summary>
    public List<(MsgId id, OneOf<byte[], ErrorBase> result)> RpcResult { get; init; } = new();
}