using FluentAssertions;

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
}