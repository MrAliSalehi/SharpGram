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
    public required List<(MsgId id, OneOf<byte[], ErrorBase> result)> RpcResult { get; init; }

    /// <summary>
    /// Updates that directly came from the Tcp connection
    /// </summary>
    public required List<OneOf<Tl.Types.UpdatesBase, UpdateGap>> Updates { get; set; }
}

public readonly struct UpdateGap(byte[] r, UpdateState s = UpdateState.Invalid)
{
    public readonly byte[] RawUpdate = r;
    public readonly UpdateState State = s;
}

public enum UpdateState { Gap, Invalid }