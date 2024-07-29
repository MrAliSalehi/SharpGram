using FluentAssertions;
using SharpGram.Client;
using SharpGram.Tl.Constructors.ConfigNs;
using SharpGram.Tl.Constructors.DcOptionNs;

namespace SharpGram.Tests;

public class Session
{
    [Test]
    public void ConnectionSession()
    {
        var authKeyBytes = Enumerable.Range(0, 256).Select(p => (byte)p).ToArray();
        var session = new TelegramSession
        {
            ConnectionSession =
            {
                AuthKey = Core.Cryptography.AuthKey.FromBytes(authKeyBytes),
                SessionId = 323842312
            }
        };
        var sessionBytes = session.Save();

        var loadedSession = TelegramSession.LoadOrCreate(sessionBytes);

        //authKey
        loadedSession.ConnectionSession.AuthKey.Should().BeEquivalentTo(session.ConnectionSession.AuthKey);

        //session Id
        loadedSession.ConnectionSession.SessionId.Should().Be(session.ConnectionSession.SessionId);

        //Sequence
        loadedSession.ConnectionSession.Sequence.Should().Be(session.ConnectionSession.Sequence);

        //LastMsgId
        loadedSession.ConnectionSession.LastMsgId.Should().Be(session.ConnectionSession.LastMsgId);

        //PingId
        loadedSession.ConnectionSession.PingId.Should().Be(session.ConnectionSession.PingId);

        //TimeOffsetSeconds
        loadedSession.ConnectionSession.TimeOffsetSeconds.Should().Be(session.ConnectionSession.TimeOffsetSeconds);

        //FutureSalts
        loadedSession.ConnectionSession.FutureSalts.SequenceEqual(session.ConnectionSession.FutureSalts).Should().BeTrue();

        //is authorized
        loadedSession.ConnectionSession.AuthKey = Core.Cryptography.AuthKey.Empty;
        loadedSession.ConnectionSession.IsAuthorized().Should().BeFalse();

        //reset

        loadedSession.ConnectionSession.Reset();
        loadedSession.ConnectionSession.AuthKey.Should().BeEquivalentTo(Core.Cryptography.AuthKey.Empty);
    }

    [Test]
    public void BasicInfo()
    {
        var session = new TelegramSession
        {
            ApiHash = "a239i20tjsfksefksoef",
            ApiId = 23148451,
            Phone = "+923428348234",
            TwoFactorPassword = "sdogfdoirgj",
            CurrentDc = new DcOption { IpAddress = "192.168.85.85", Port = 8585, Id = 4, Secret = [] },
        };

        var sessionBytes = session.Save();

        var loadedSession = TelegramSession.LoadOrCreate(sessionBytes);

        loadedSession.Phone.Should().BeEquivalentTo(session.Phone);
        loadedSession.ApiHash.Should().BeEquivalentTo(session.ApiHash);
        loadedSession.ApiId.Should().Be(session.ApiId);
        loadedSession.TwoFactorPassword.Should().BeEquivalentTo(session.TwoFactorPassword);

        loadedSession.Should().NotBeNull();
        loadedSession.CurrentDc!.IpAddress.Should().BeEquivalentTo(session.CurrentDc.IpAddress);
        loadedSession.CurrentDc.Port.Should().Be(session.CurrentDc.Port);
        loadedSession.CurrentDc.Id.Should().Be(session.CurrentDc.Id);

        loadedSession.GetDc().IpAddress.Should().BeEquivalentTo(session.CurrentDc.IpAddress);

        loadedSession.CurrentDc = null;
        loadedSession.GetDc().IpAddress.Should().Be("149.154.167.50");
    }

    [Test]
    public void BadSession()
    {
        //small data
        var sessionBytes = Enumerable.Repeat(10, 40).Select(p => (byte)p).ToArray();
        Assert.DoesNotThrow(() => { TelegramSession.LoadOrCreate(sessionBytes); });

        var sessionBytes2 = Enumerable.Repeat(10, 400).Select(p => (byte)p).ToArray();
        Assert.DoesNotThrow(() => { TelegramSession.LoadOrCreate(sessionBytes2); });
    }
}