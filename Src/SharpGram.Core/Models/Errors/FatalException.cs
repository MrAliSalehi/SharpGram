namespace SharpGram.Core.Models.Errors;

public class FatalException : Exception
{
    public override string Message { get; }
    public FatalException(string msg) => Message = msg;
    public FatalException(ConnectionError ce) => Message = ce.ConnectionErr.ToStringFast();
    public FatalException(TransportError te) => Message = te.TransportErr.ToStringFast();
    public FatalException(ErrorBase eb)
    {
        if (eb is ConnectionError ce)
            Message = ce.ConnectionErr.ToStringFast();
        else
            Message = eb switch
            {
                TransportError te => te.TransportErr.ToStringFast(),
                RpcError r        => r.Msg,
                _                 => throw new NotSupportedException()
            };
    }
}