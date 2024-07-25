using FluentAssertions;
using SharpGram.Core.Models.Errors;
using SharpGram.Tl.Constructors.AccountPasswordNs;
using SharpGram.Tl.Constructors.InputCheckPasswordSRPNs;
using SharpGram.Tl.Constructors.PasswordKdfAlgoNs;
using SharpGram.Tl.Constructors.SecurePasswordKdfAlgoNs;

namespace SharpGram.Tests;

public class PasswordAuth
{
    [Test]
    public void SafePrime()
    {
        var safePrimes = new[] { 5, 7, 11, 23, 47, 59, 83, 107, 167, 179 };
        foreach (var p in safePrimes)
            Core.Cryptography.PasswordAuth.IsSafePrime(p).Should().Be(true);

        Core.Cryptography.PasswordAuth.IsSafePrime(2).Should().Be(false);
        Core.Cryptography.PasswordAuth.IsSafePrime(546).Should().Be(false);
    }
    [Test]
    public void GenerateSrp()
    {
        var pwd = new AccountPassword
        {
            SecureRandom = [12, 43],
            SrpB = [10],
            CurrentAlgo = new PasswordKdfAlgoSHA256SHA256PBKDF2HMACSHA512iter100000SHA256ModPow
            {
                Salt1 = [12],
                Salt2 = [24],
                G = 3,
                P = [23]
            },
            NewAlgo = new PasswordKdfAlgoUnknown(),
            NewSecureAlgo = new SecurePasswordKdfAlgoUnknown(),
            SrpId = 0
        };
        var srp = Core.Cryptography.PasswordAuth.GenerateSrp(pwd, "test");
        var s = (InputCheckPasswordSRP)srp.AsT0;


        var m1 = new byte[] { 114, 140, 58, 5, 82, 224, 12, 114, 246, 40, 158, 131, 184, 15, 97, 245, 54, 17, 146, 3, 148, 91, 22, 143, 49, 107, 78, 118, 52, 179, 113, 25, };
        var a = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 9, };

        s.SrpId.Should().Be(0);
        s.M1.Should().BeEquivalentTo(m1);
        s.A.Should().BeEquivalentTo(a);

        //something that is not safe prime and its invalid
        ((PasswordKdfAlgoSHA256SHA256PBKDF2HMACSHA512iter100000SHA256ModPow)pwd.CurrentAlgo).P = [123];
        var srp2 = Core.Cryptography.PasswordAuth.GenerateSrp(pwd, "test");
        srp2.TryPickT1(out var e, out _).Should().BeTrue();
        e.ErrorType.Should().Be(LoginErrorType.InvalidP);

        //invalid kdf
        pwd.CurrentAlgo = new PasswordKdfAlgoUnknown();
        var srp3 = Core.Cryptography.PasswordAuth.GenerateSrp(pwd, "test");
        srp3.TryPickT1(out var e2, out _).Should().BeTrue();
        e2.ErrorType.Should().Be(LoginErrorType.InvalidKdf);

        //invalid g

        for (var i = 1; i < 8; i++)
        {
            var r = Core.Cryptography.PasswordAuth.IsValidG(i, 0);
            if (i is 4)
                r.Should().BeTrue();
            else
                r.Should().BeFalse();
        }
    }
}