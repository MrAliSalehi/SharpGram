using FluentAssertions;
using SharpGram.Core.Models.Errors;

namespace SharpGram.Tests;

public class Errors
{
    [Test]
    public void Transport()
    {

        var t = TransportError.New(TransportErrType.BadTransport);
        var t2 = TransportError.New(TransportErrType.BadTransport);
        //eq overrides
        t.Should().BeEquivalentTo(t2);
        t.Equals(t).Should().BeTrue();
        t.Equals(null).Should().BeFalse();

        t!.Is(TransportErrType.BadTransport).Should().BeTrue();
        t.Is(TransportErrType.RetryRequest).Should().BeFalse();

        t.Is(ConnectionErrType.None).Should().BeTrue();
        t.Is(ConnectionErrType.Timeout | ConnectionErrType.DcNotFound).Should().BeFalse();

        t.GetHashCode().Should().Be(t2.GetHashCode());
        t.GetHashCode().Should().Be(0);

        FatalException ex = t;
        ex.Message.Should().BeEquivalentTo(t.TransportErr.ToStringFast());
        t.ToString().Should().BeEquivalentTo(t.TransportErr.ToStringFast());
    }
    [Test]
    public void Connection()
    {
        var c= ConnectionError.New(ConnectionErrType.SocketNotConnected);
        c.Is(TransportErrType.BadTransport).Should().BeFalse();
        c.Is(ConnectionErrType.SocketNotConnected).Should().BeTrue();
        c.ToString().Should().BeEquivalentTo(c.ConnectionErr.ToStringFast());
        FatalException ex = c;
        ex.Message.Should().BeEquivalentTo(c.ConnectionErr.ToStringFast());

        ErrorBase x = c;
        FatalException x2 = x;
        x2.Message.Should().BeEquivalentTo(c.ToString());
    }
}