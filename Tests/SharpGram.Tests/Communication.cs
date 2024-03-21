using FluentAssertions;
using OneOf.Types;
using SharpGram.Core.Conversions;
using SharpGram.Core.Models;
using SharpGram.Core.Models.Errors;
using SharpGram.Core.Mtproto.Connections;
using OneOfAssertion = FluentAssertions.OneOf.AssertionExtensions;

namespace SharpGram.Tests;

public class Communication
{
    private static readonly byte[] Req = "Hey!".Select(Convert.ToByte).ToArray();

    [Test]
    public void UnEncrypted_ShouldPushOnce()
    {
        var unAuth = new UnAuthConnection();

        OneOfAssertion.Should(unAuth.Wrap(Req, false)).Be<MsgId>();
        var a = unAuth.Wrap(Req, false);
        a.IsT1.Should().BeTrue();
        (a.AsT1 is TransportError).Should().BeTrue();
        ((TransportError)a.AsT1).Is(TransportErrType.BufferNotEmpty);
    }

    [Test]
    public void UnEncryptedDeserialize_ShouldCheckMsgBuffer()
    {
        var unAth = new UnAuthConnection();
        var a = unAth.Deserialize([1, 2, 3, 4]);
        a.IsT1.Should().BeTrue();
        (a.AsT1 is TransportError).Should().BeTrue();
        ((TransportError)a.AsT1).Is(TransportErrType.TransportErr).Should().BeTrue();

        var b = unAth.Deserialize(Enumerable.Range(0, 19).Select(p => (byte)p).ToArray());
        b.IsT1.Should().BeTrue();
        (b.AsT1 is TransportError).Should().BeTrue();
        ((TransportError)b.AsT1).Is(TransportErrType.SmallMsg).Should().BeTrue();
    }
    [Test]
    public void Pop()
    {
        var a = new UnAuthConnection();
        var id = a.Wrap([1, 2, 3, 4], true).AsT0;
        ((long)id).Should().Be(0);
        var result = a.Pop();
        result.Should().BeEquivalentTo([0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 4, 0x00, 0x00, 0x00, 1, 2, 3, 4]);
    }
    [Test]
    public void UnAuthDeserialize()
    {
        var a = new UnAuthConnection();
        var authKey = Enumerable.Repeat(0, 8).Select(p => (byte)p).ToList();
        var msgId = ((long)1005).TlSerialize();
        var len = 30.TlSerialize().ToList();
        var msg = Enumerable.Range(0, 30).Select(p => (byte)p).ToList();

        var data = authKey.Concat(msgId).Concat(len).Concat(msg).ToArray();
        var result = a.Deserialize(data);
        result.IsT0.Should().BeTrue();

        //badAuth
        var authKey2 = Enumerable.Repeat(1, 8).Select(p => (byte)p).ToList();
        var data2 = authKey2.Concat(msgId).Concat(len).Concat(msg).ToArray();
        var result2 = a.Deserialize(data2);
        result2.IsT1.Should().BeTrue();
        (result2.AsT1 as TransportError)!.TransportErr.Should().Be(TransportErrType.BadAuthKey);

        //badMsgId
        var msgId2 = ((long)1004).TlSerialize();
        var data3 = authKey.Concat(msgId2).Concat(len).Concat(msg).ToArray();
        var result3 = a.Deserialize(data3);
        result3.IsT1.Should().BeTrue();
        (result3.AsT1 as TransportError)!.TransportErr.Should().Be(TransportErrType.BadMsgId);

        //BadLen

        var len2 = 0.TlSerialize();
        var data4 = authKey.Concat(msgId).Concat(len2).Concat(msg).ToArray();
        var result4 = a.Deserialize(data4);
        result4.IsT1.Should().BeTrue();
        (result4.AsT1 as TransportError)!.TransportErr.Should().Be(TransportErrType.BadMsgLen);

    }
}