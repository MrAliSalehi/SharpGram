using System.Security.Cryptography;
using SharpGram.Core.Common;

namespace SharpGram.Core.Cryptography;

internal static class CryptoHelpers
{
    internal static IRandomGenerator Random = new RealRandom();
    //copied from https://github.com/wiz0u/WTelegramClient/blob/master/src/Helpers.cs
    public static (ulong p, ulong q) Factorize(ulong pq)
    {
        if (pq < 2) return (1, 1);

        ulong p = 0;
        for (int i = 0, iter = 0; i < 3 || iter < 1000; i++)
        {
            var q = Random.Random(17, 32) % (pq - 1);
            var x = (Random.Random() + Random.Random() << 31) % (pq - 1) + 1;
            var y = x;
            var lim = 1 << (Math.Min(5, i) + 18);
            for (var j = 1; j < lim; j++)
            {
                iter++;
                // x = (q + x * x) % pq
                ulong res = q, a = x;
                while (x != 0)
                {
                    if ((x & 1) != 0)
                        res = (res + a) % pq;
                    a = (a + a) % pq;
                    x >>= 1;
                }

                x = res;
                var z = x < y ? pq + x - y : x - y;
                p = Gcd(z, pq);
                if (p != 1)
                    break;

                if ((j & (j - 1)) == 0)
                    y = x;
            }

            if (p > 1 && p < pq)
                break;
        }

        if (p != 0)
        {
            var other = pq / p;
            if (other < p)
                p = other;
        }

        return (p, pq / p);
    }
    private static ulong Gcd(ulong left, ulong right)
    {
        while (right != 0)
        {
            var num = left % right;
            left = right;
            right = num;
        }

        return left;
    }
}

internal interface IRandomGenerator
{
    ulong Random(int from = int.MinValue, int to = int.MaxValue);
}

internal class RealRandom : IRandomGenerator
{
    public ulong Random(int from = int.MinValue, int to = int.MaxValue)
        => (ulong)RandomNumberGenerator.GetInt32(from, to);
}