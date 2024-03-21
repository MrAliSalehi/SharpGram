using FluentAssertions;
using SharpGram.Core.Mtproto.Transport;

namespace SharpGram.Tests;

public class Transport
{
    #region Intermediate

    [Test]
    public void IntermediatePackEmpty()
    {
        var (t, inp, output) = Init<Intermediate>(0);
        t.Pack(inp, output);
        output.Should().BeEquivalentTo(new byte[] { 0xee, 0xee, 0xee, 0xee, 0, 0, 0, 0 });
    }

    [Test]
    public void IntermediatePackNonPadded()
    {
        var (t, inp, _) = Init<Intermediate>(7);
        Assert.Throws<ArgumentOutOfRangeException>(() => t.Pack(inp, []));
    }

    [Test]
    public void IntermediatePackNormal()
    {
        var (t, inp, output) = Init<Intermediate>(128);
        t.Pack(inp, output);
        output[..8].Should().BeEquivalentTo(new byte[] { 0xee, 0xee, 0xee, 0xee, 128, 0, 0, 0 });
        output[8..].Should().BeEquivalentTo(inp[..]);
    }

    [Test]
    public void IntermediateUnpackSmall()
    {
        var t = new Intermediate();
        Assert.Throws<ArgumentOutOfRangeException>(() => t.UnPack([1], []));
    }

    [Test]
    public void IntermediateUnpackNormal()
    {
        var (t, inp, packed) = Init<Intermediate>(128);
        t.Pack(inp, packed);
        var unpacked = new List<byte>();
        t.UnPack(packed[4..], unpacked);
        byte[] result = [];
        t.UnPack(packed[4..].ToArray(), ref result);
        result.Should().BeEquivalentTo(unpacked);
    }
    [Test]
    public void IntermediateUnpackTwo()
    {
        var (t, inp, packed) = Init<Intermediate>(128);
        t.Pack(inp, packed);
        var twoInp = packed.Skip(4).Concat(packed.Skip(4)).ToList();
        var unpacked = new List<byte>();
        var res = t.UnPack(twoInp, unpacked);
        inp.Should().BeEquivalentTo(unpacked);
        res.Should().Be(packed.Count - 4);

        t.UnPack(packed[4..], unpacked);
    }

    [Test]
    public void IntermediateResetState()
    {
        var t = new Intermediate();
        t.ResetState();
        t.FirstPacket.Should().BeTrue();
    }

    #endregion

    #region Full

    [Test]
    public void FullPackEmpty()
    {
        var (f, inp, output) = Init<Full>(0);
        f.Pack(inp, output);
        output.Should().BeEquivalentTo([12, 0, 0, 0, 0, 0, 0, 0, 38, 202, 141, 50]);
    }

    [Test]
    public void FullPackNonPadded()
    {
        var (f, inp, output) = Init<Full>(7);
        Assert.Throws<ArgumentOutOfRangeException>(() => f.Pack(inp, output));
    }
    [Test]
    public void FullPackNormal()
    {
        var (f, inp, output) = Init<Full>(128);
        f.Pack(inp, output);
        output[..4].Should().BeEquivalentTo([140, 0, 0, 0]);
        output[4..8].Should().BeEquivalentTo([0, 0, 0, 0]);
        output[8..(8 + inp.Count)].Should().BeEquivalentTo(inp[..]);
        output[(8 + inp.Count)..].Should().BeEquivalentTo([134, 115, 149, 55]);
    }

    [Test]
    public void FullPackTwo()
    {
        var (f, inp, output) = Init<Full>(128);
        f.Pack(inp, output);
        output.Clear();
        f.Pack(inp, output);

        output[..4].Should().BeEquivalentTo([140, 0, 0, 0]);
        output[4..8].Should().BeEquivalentTo([1, 0, 0, 0]);

        output[8..(8 + inp.Count)].Should().BeEquivalentTo(inp[..]);

        output[(8 + inp.Count)..].Should().BeEquivalentTo([150, 9, 240, 74]);
    }

    [Test]
    public void FullUnpackNormal()
    {
        var (ex, f, inp, output) = InitUnpackFull(128);
        f.UnPack(inp, output);
        output.Should().BeEquivalentTo(ex);
    }

    [Test]
    public void FullUnpackTwo()
    {
        var (ex, f, inp, output) = InitUnpackFull(128);
        var twoInp = inp.Concat(inp).ToList();

        var n = f.UnPack(twoInp, output);

        output.Should().BeEquivalentTo(ex);
        n.Should().Be(inp.Count);
        output.Should().BeEquivalentTo(ex);

        Assert.Throws<ArgumentOutOfRangeException>(() => f.UnPack(inp, output));
    }

    [Test]
    public void FullUnpackMultipleTimes()
    {
        var (f, inp, packed) = Init<Full>(128);
        var unpacked = new List<byte>();
        for (var i = 0; i < 5; i++)
        {
            packed.Clear();
            unpacked.Clear();
            f.Pack(inp, packed);
            f.UnPack(packed, unpacked);
            inp.Should().BeEquivalentTo(unpacked);
        }
    }

    [Test]
    public void FullUnpackBadCrc()
    {
        var (_, f, inp, output) = InitUnpackFull(128);
        inp[^1] ^= 0xff;
        var func = () => f.UnPack(inp, output);
        func.Should().Throw<ArgumentOutOfRangeException>();
    }
    [Test]
    public void FullUnpackBadSeq()
    {
        var (f, inp, packed) = Init<Full>(128);
        var unpacked = new List<byte>();
        f.Pack(inp, packed);
        packed.Clear();
        f.Pack(inp, packed);

        var func = () => f.UnPack(inp, unpacked);
        func.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Test]
    public void FullResetState()
    {
        var (f, inp, packed) = Init<Full>(128);
        f.Pack(inp, packed);
        var seq = f.SendSeq;
        f.ResetState();
        seq.Should().NotBe(f.SendSeq);
        f.SendSeq.Should().Be(0);
    }

    #endregion

    #region Abridged

    [Test]
    public void AbridgedPackEmpty()
    {
        var (a, inp, output) = Init<Abridged>(0);
        a.Pack(inp, output);
        output.Should().BeEquivalentTo([0xef, 0]);
    }
    [Test]
    public void AbridgedPackNonPadded()
    {
        var (a, inp, output) = Init<Abridged>(7);
        Assert.Throws<ArgumentOutOfRangeException>(() => a.Pack(inp, output));
    }

    [Test]
    public void AbridgedPackNormal()
    {
        var (a, inp, output) = Init<Abridged>(128);
        a.Pack(inp, output);
        output[..2].Should().BeEquivalentTo([0xef, 32]);
        output[2..output.Count].Should().BeEquivalentTo(inp);
    }

    [Test]
    public void AbridgedPackLarge()
    {
        var (a, inp, output) = Init<Abridged>(1024);
        a.Pack(inp, output);
        output[..5].Should().BeEquivalentTo([0xef, 127, 0, 1, 0]);
        output[5..].Should().BeEquivalentTo(inp[..]);
    }

    [Test]
    public void AbridgedUnPackSmall()
    {
        var a = new Abridged();
        var output = new List<byte>();
        Assert.Throws<ArgumentException>(()=>a.UnPack([],output));
    }
    [Test]
    public void AbridgedUnPackNormal()
    {
        var (a, inp, packed) = Init<Abridged>(128);
        var unpacked = new List<byte>();
        a.Pack(inp, packed);
        a.UnPack(packed[1..], unpacked);
        inp.Should().BeEquivalentTo(unpacked);
    }

    [Test]
    public void AbridgedUnPackTwo()
    {
        var (a, inp, packed) = Init<Abridged>(128);
        var unpacked = new List<byte>();

        a.Pack(inp, packed);
        var twInput = packed.Skip(1).Concat(packed.Skip(1)).ToList();

        var n = a.UnPack(twInput, unpacked);

        inp.Should().BeEquivalentTo(unpacked);
        n.Should().Be(packed.Count - 1);
    }

    [Test]
    public void AbridgedUnPackLarge()
    {
        var (a, inp, packed) = Init<Abridged>(1024);
        var unpacked = new List<byte>();
        a.Pack(inp, packed);
        a.UnPack(packed[1..], unpacked);
        inp.Should().BeEquivalentTo(unpacked);
    }
    [Test]
    public void AbridgedResetState()
    {
        var (a, inp, output) = Init<Abridged>(1024);
        var state = a.Init;
        state.Should().BeFalse();
        a.Pack(inp, output);
        a.Init.Should().BeTrue();

        a.ResetState();
        a.Init.Should().BeFalse();
    }
    #endregion

    private static (T t, List<byte> input, List<byte> output) Init<T>(int n) where T : ITransport, new()
        => (new T(), Enumerable.Range(0, n).Select(i => (byte)(i & 0xff)).ToList(), []);

    private static (List<byte>, Full, List<byte> inp, List<byte> output) InitUnpackFull(int n)
    {
        var (f, expectedOut, inp) = Init<Full>(n);
        f.Pack(expectedOut, inp);
        return (expectedOut, new Full(), inp, []);
    }
}