using System.Text;
using FluentAssertions;
using SharpGram.Core.Conversions;

namespace SharpGram.Tests;

public class BinaryConversions
{
    [Test]
    public void SerializeLong()
    {
        const long zero = 0;
        const long one = 1;
        const long negativeOne = -1;
        zero.TlSerialize().Should().BeEquivalentTo([0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0]);
        one.TlSerialize().Should().BeEquivalentTo([0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0]);
        negativeOne.TlSerialize().Should().BeEquivalentTo([0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff]);
        long.MaxValue.TlSerialize().Should().BeEquivalentTo([0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f]);
        long.MinValue.TlSerialize().Should().BeEquivalentTo([0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x80]);
    }

    [Test]
    public void SerializeUInt()
    {
        const uint zero = 0;
        const uint one = 1;
        zero.TlSerialize().Should().BeEquivalentTo([0x00, 0x00, 0x00, 0x00]);
        one.TlSerialize().Should().BeEquivalentTo([0x01, 0x00, 0x00, 0x00]);
        uint.MaxValue.TlSerialize().Should().BeEquivalentTo([0xff, 0xff, 0xff, 0xff]);
    }

    [Test]
    public void SerializeInt()
    {
        const int zero = 0;
        const int one = 1;
        const int negativeOne = -1;
        zero.TlSerialize().Should().BeEquivalentTo([0x00, 0x00, 0x00, 0x00]);
        one.TlSerialize().Should().BeEquivalentTo([0x01, 0x00, 0x00, 0x00]);
        negativeOne.TlSerialize().Should().BeEquivalentTo([0xff, 0xff, 0xff, 0xff]);
        int.MaxValue.TlSerialize().Should().BeEquivalentTo([0xff, 0xff, 0xff, 0x7f]);
        int.MinValue.TlSerialize().Should().BeEquivalentTo([0x00, 0x00, 0x00, 0x80]);
    }

    [Test]
    public void SerializeBool()
    {

        true.TlSerialize().Should().BeEquivalentTo([0xb5, 0x75, 0x72, 0x99]);
        false.TlSerialize().Should().BeEquivalentTo([0x37, 0x97, 0x79, 0xbc]);
    }

    [Test]
    public void DeserializeCharArray()
    {
        var reader = CustomBinaryReader.From([0x01, 0x7f, 0x00, 0x00],false);
        reader.ReadStrAsBytes().Should().BeEquivalentTo([0x7F]);

    }

    [Test]
    public void SerializeString()
    {
        var sr = "Hello".TlSerialize();
        byte[] len = [0x05];
        byte[] pad = [0x0,0x0];
        var ex = len.Concat(Encoding.UTF8.GetBytes("Hello")).Concat(pad).ToList();
        sr.Should().BeEquivalentTo(ex);
    }
}