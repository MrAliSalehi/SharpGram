namespace SharpGram.Core.Models.Errors;

/// <summary>
/// basic error type
/// </summary>
public abstract class ErrorBase
{
    public static implicit operator FatalException(ErrorBase e) => new(e);
    public bool Is(TransportErrType te) => this is TransportError e && e.TransportErr == te;
    public bool Is(ConnectionErrType c) => this is ConnectionError connectionError && connectionError.ConnectionErr == c;
    public abstract override string ToString();
}

