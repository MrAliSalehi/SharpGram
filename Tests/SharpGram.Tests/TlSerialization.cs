using System.Buffers.Binary;
using FluentAssertions;
using SharpGram.Core.Conversions;
using SharpGram.Core.Models.Errors;

namespace SharpGram.Tests;

public class TlSerialization
{
    [Test]
    public void Deserialize()
    {
        var bytes = Enumerable.Repeat((byte)0x01, 256).ToArray();
        var des = Deserializer.New(bytes);
        byte[] id = [0x01, 0x01, 0x01, 0x01];
        des.ReadId().SequenceEqual(id).Should().BeTrue();
        des.LastId.SequenceEqual(id).Should().BeTrue();
        des.IsCorrectId(id).Should().BeTrue();

        des.As<int>().Read().Should().Be(16843009);
        des.As<uint>().Read().Should().Be(16843009);
        des.As<long>().Read().Should().Be(72340172838076673);


        byte[] len = [0x02, 0x00, 0x00, 0x00]; //2
        byte[] vectorId = [0x15, 0xc4, 0xb5, 0x1c];
        byte[] bytes2 = [..vectorId, ..len, ..bytes];
        var des2 = Deserializer.New(bytes2);
        des2.ReadNumbers<int>().Count(p => p == 16843009).Should().Be(2);

        //Assert.Throws<DeserializationException>(()=> {Deserializer.New(bytes).ReadNumbers<int>();});
        Console.WriteLine();

        byte[] b = [..bytes, ..bytes2];
        var des3 = Deserializer.New(b);
        des3.As<byte[]>().Read().SequenceEqual([(byte)0x01]).Should().BeTrue();

    }
}