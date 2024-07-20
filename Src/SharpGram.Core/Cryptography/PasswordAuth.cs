using System.Numerics;
using OneOf;
using SharpGram.Core.Models.Errors;
using SharpGram.Tl.Constructors.AccountPasswordNs;
using SharpGram.Tl.Constructors.InputCheckPasswordSRPNs;
using SharpGram.Tl.Constructors.PasswordKdfAlgoNs;
using SharpGram.Tl.Types;

namespace SharpGram.Core.Cryptography;

public static class PasswordAuth
{
    public static OneOf<InputCheckPasswordSRPBase, LoginError> Validate(AccountPasswordBase passwordBase)
    {
        var pwd = (AccountPassword)passwordBase;

        if (pwd.CurrentAlgo is not PasswordKdfAlgoSHA256SHA256PBKDF2HMACSHA512iter100000SHA256ModPow a)
            throw new FatalException("Invalid KDF");
        var (p, g, salt1, salt2) = (new BigInteger(a.P, true, true), a.G, a.Salt1, a.Salt2);

        if (!IsSafePrime(p)) return new LoginError(LoginErrorType.InvalidP);

        if (!IsValidG(g, p)) return new LoginError(LoginErrorType.InvalidG);

        var (g_a, sr) = (pwd.SrpB, pwd.SecureRandom);
        //TODO complete the validation and create the Srp object
        throw new NotImplementedException();
    }
    private static bool IsValidG(int g, BigInteger p)
    {
        /* https://core.telegram.org/api/srp
         * g generates a cyclic subgroup of prime order (p-1)/2, i.e. is a quadratic residue mod p.
         * Since g is always equal to 2, 3, 4, 5, 6 or 7, this is easily done using quadratic reciprocity law,
         * yielding a simple condition on p mod 4g -- namely, p mod 8 = 7 for g = 2; p mod 3 = 2 for g = 3;
         * no extra condition for g = 4; p mod 5 = 1 or 4 for g = 5; p mod 24 = 19 or 23 for g = 6; and p mod 7 = 3, 5 or 6 for g = 7.
         */
        return g switch
        {
            2 => p % 8 == 7,
            3 => p % 3 == 2,
            4 => true,
            5 => (int)(p % 5) is 1 or 4,
            6 => (int)(p % 24) is 19 or 23,
            7 => (int)(p % 7) is 3 or 5 or 6,
            _ => false
        };
    }
    public static bool IsSafePrime(BigInteger number)
    {
        if (number <= 2)
            return false;

        var primes = GetPrimeNumbers(number);

        if (!primes.Contains(number))
            return false;

        var q = (number - 1) / 2;
        return primes.Contains(q);
    }
    /// <summary>
    /// this function is an implementation of sieve of Eratosthenes algorithm to find all prime numbers
    /// </summary>
    /// <param name="limit">return all prime numbers up to the limit</param>
    private static List<BigInteger> GetPrimeNumbers(BigInteger limit)
    {
        var isPrime = new bool[(int)(limit + 1)];
        for (BigInteger i = 2; i <= limit; i++)
            isPrime[(int)i] = true;

        for (BigInteger p = 2; p * p <= limit; p++)
            if (isPrime[(int)p])
                for (var i = p * p; i <= limit; i += p)
                    isPrime[(int)i] = false;


        var primes = new List<BigInteger>();
        for (BigInteger i = 2; i <= limit; i++)
            if (isPrime[(int)i])
                primes.Add(i);

        return primes;
    }
}