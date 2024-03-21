using System.Reflection;
using FluentAssertions;
using SharpGram.Core.Contracts;
/*using EasyTg.Tl.Constructors;
using EasyTg.Tl.Types;*/

namespace SharpGram.Tests;

public class Bindings
{
    [Test]
    public void Serializable()
    {
        var baseTypes = Assembly.GetExecutingAssembly().GetTypes().Where(p => p.Namespace == "EasyTg.Tl.Base").ToList();
        CheckType(baseTypes);
        var t = Assembly.GetExecutingAssembly().GetTypes().Where(p => p.Namespace == "EasyTg.Tl.Types").ToList();
        CheckType(t);
        return;

        void CheckType(List<Type> types)
        {
            foreach (var type in types)
            {
                type.IsAbstract.Should().BeFalse();
                type.GetInterface("ITlSerializable", true).Should().NotBeNull();
                type.GetMethod("TlSerialize").Should().NotBeNull();
            }
        }
    }

    [Test]
    public void ShouldBeAbstract()
    {
        var ct = Assembly.GetExecutingAssembly().GetTypes().Where(p => p.Namespace == "EasyTg.Tl.Constructors").ToList();
        foreach (var t in ct)
            t.IsAbstract.Should().BeTrue();
    }

    [Test]
    public void AbstractSerialize1()
    {
        var list = new List<MyBase>
        {
            new Child1(),
            new Child2()
        };

        list[0].TlSerialize().Should().BeEquivalentTo([1]);
        list[1].TlSerialize().Should().BeEquivalentTo([2]);
    }
    [Test]
    public void AbstractSerialize2()
    {/*
        var list2 = new List<PostInteractionCounters>
        {
            new PostInteractionCountersMessage { Forwards = 1, Reactions = 1, Views = 1, MsgId = 1 },
            new PostInteractionCountersStory { Forwards = 1, Reactions = 1, Views = 1, StoryId = 1 },
        };

        list2[0].TlSerialize()[..4].Should().BeEquivalentTo([127, 142, 5, 231]);
        list2[1].TlSerialize()[..4].Should().BeEquivalentTo([39, 14, 72, 138,]);*/
    }
}

public abstract class MyBase : ITlSerializable
{
    public byte[] TlSerialize() => this switch
    {
        Child1 c  => c.TlSerialize(),
        Child2 c2 => c2.TlSerialize(),
        _         => []
    };
}

public class Child1 : MyBase, ITlSerializable
{
    public new byte[] TlSerialize() => [1];
}

public class Child2 : MyBase, ITlSerializable
{
    public new byte[] TlSerialize() => [2];
}