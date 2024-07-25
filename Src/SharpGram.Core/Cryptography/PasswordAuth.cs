using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using OneOf;
using SharpGram.Core.Common;
using SharpGram.Core.Models.Errors;
using SharpGram.Tl.Constructors.AccountPasswordNs;
using SharpGram.Tl.Constructors.InputCheckPasswordSRPNs;
using SharpGram.Tl.Constructors.PasswordKdfAlgoNs;
using SharpGram.Tl.Types;

namespace SharpGram.Core.Cryptography;

public static class PasswordAuth
{
    public static OneOf<InputCheckPasswordSRPBase, LoginError> GenerateSrp(AccountPasswordBase passwordBase, string password)
    {
        var pwd = (AccountPassword)passwordBase;

        if (pwd.CurrentAlgo is not PasswordKdfAlgoSHA256SHA256PBKDF2HMACSHA512iter100000SHA256ModPow a)
            return new LoginError(LoginErrorType.InvalidKdf);
        var (p, gInt, salt1, salt2) = (a.P, a.G, a.Salt1, a.Salt2);
        var bigP = new BigInteger(p, true, true);


        if (!IsSafePrime(bigP)) return new LoginError(LoginErrorType.InvalidP);

        if (!IsValidG(gInt, bigP)) return new LoginError(LoginErrorType.InvalidG);


        var gHash = new byte[256];
        gHash[^1] = (byte)gInt;
        var gBArr = pwd.SrpB!;
        var gB = new byte[256];
        gBArr.CopyTo(gB.AsSpan(256 - gBArr.Length));

        var bigG = new BigInteger(gInt);
        var bigA = new BigInteger(pwd.SecureRandom, true, true);
        var bigGb = new BigInteger(pwd.SrpB, true, true);
        var pwdBytes = Encoding.UTF8.GetBytes(password);

        //PH1(password, salt1, salt2) := SH(SH(password, salt1), salt2)
        var ph1 = Helpers.HashArrays(salt2, Helpers.HashArrays(salt1, pwdBytes, salt1), salt2);

        //PH2(password, salt1, salt2) := SH(pbkdf2(sha512, ph1, salt1, 100000), salt2)
        var pbk = Rfc2898DeriveBytes.Pbkdf2(ph1, salt1, 100000, HashAlgorithmName.SHA512, 64);
        var ph2 = Helpers.HashArrays(salt2, pbk, salt2);

        //g_a := pow(g, a) mod p
        var gaArray = BigInteger.ModPow(bigG, bigA, bigP).ToByteArray(true, true);
        var gA = new byte[256];
        gaArray.CopyTo(gA.AsSpan(256 - gaArray.Length));
        //k := H(p | g)
        var k = new BigInteger(Helpers.HashArrays(p, gHash), true, true);

        //u := H(g_a | g_b)
        var u = Helpers.HashArrays(gA, gB);
        var bigU = new BigInteger(u, true, true);


        //x := PH2(password, salt1, salt2)
        var x = new BigInteger(ph2, true, true);

        //v := pow(g, x) mod p
        var v = BigInteger.ModPow(bigG, x, bigP);

        //k_v := (k * v) mod p
        var kV = k * v % bigP;

        //t := (g_b - k_v) mod p (positive modulo, if the result is negative increment by p)
        var t = (bigGb > kV ? bigGb - kV : kV - bigGb) % bigP;

        //s_a := pow(t, a + u * x) mod p
        var bigSa = BigInteger.ModPow(t, bigA + bigU * x, bigP).ToByteArray(true, true);

        var sA = new byte[256];
        bigSa.CopyTo(sA.AsSpan(256 - bigSa.Length));

        //k_a := H(s_a)
        var kA = SHA256.HashData(sA);

        var hashP = SHA256.HashData(p);
        var hashG = SHA256.HashData(gHash);

        //xorPg = H(p) xor H(g)
        var xorPg = hashP.Select((t1, i) => (byte)(t1 ^ hashG[i])).ToArray();


        //M1 := H(xorPg | H(salt1) | H(salt2) | g_a | g_b | k_a)
        var m1 = Helpers.HashArrays(xorPg, SHA256.HashData(salt1), SHA256.HashData(salt2), gA, gB, kA);
        return new InputCheckPasswordSRP { A = gA, M1 = m1, SrpId = pwd.SrpId!.Value };
    }
    /// <summary>
    ///  https://core.telegram.org/api/srp
    /// g generates a cyclic subgroup of prime order (p-1)/2, i.e. is a quadratic residue mod p.
    /// Since g is always equal to 2, 3, 4, 5, 6 or 7, this is easily done using quadratic reciprocity law,
    /// yielding a simple condition on p mod 4g -- namely, p mod 8 = 7 for g = 2; p mod 3 = 2 for g = 3;
    /// no extra condition for g = 4; p mod 5 = 1 or 4 for g = 5; p mod 24 = 19 or 23 for g = 6; and p mod 7 = 3, 5 or 6 for g = 7.
    /// </summary>
    public static bool IsValidG(int g, BigInteger p) => g switch
    {
        2 => p % 8 == 7,
        3 => p % 3 == 2,
        4 => true,
        5 => (int)(p % 5) is 1 or 4,
        6 => (int)(p % 24) is 19 or 23,
        7 => (int)(p % 7) is 3 or 5 or 6,
        _ => false
    };
    internal static bool IsSafePrime(BigInteger number)
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