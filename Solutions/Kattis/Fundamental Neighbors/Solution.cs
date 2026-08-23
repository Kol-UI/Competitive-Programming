// Fundamental Neighbors
namespace CompetitiveProgramming.Kattis.FundamentalNeighbors;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Program
{
    const int mxN = 46500;
    static List<long> p = new List<long>();
    static long[] spf = new long[mxN];

    static Dictionary<long, int> Factorize(long m)
    {
        Dictionary<long, int> cnt = new Dictionary<long, int>();

        for (int i = 0; i < p.Count && p[i] * p[i] <= m; i++)
        {
            while (m % p[i] == 0)
            {
                if (!cnt.ContainsKey(p[i]))
                    cnt[p[i]] = 0;
                cnt[p[i]]++;
                m /= p[i];
            }
        }
        if (m > 1)
        {
            if (!cnt.ContainsKey(m))
                cnt[m] = 0;
            cnt[m]++;
        }
        return cnt;
    }

    static long Pw(long a, long b)
    {
        if (b == 0) return 1;
        long r = Pw(a, b >> 1);
        r = r * r;
        if ((b & 1) == 1) r = r * a;
        return r;
    }

    static void Sieve()
    {
        for (long i = 2; i < mxN; i++)
        {
            if (spf[i] == 0)
            {
                spf[i] = i;
                p.Add(i);
                for (long j = i * i; j < mxN; j += i)
                {
                    if (spf[j] == 0)
                        spf[j] = i;
                }
            }
        }
    }

    static void Main()
    {
        Sieve();

        string line;
        while ((line = Console.ReadLine()) != null)
        {
            long n = long.Parse(line);
            var f = Factorize(n);
            long ans = 1;

            foreach (var kvp in f)
            {
                ans *= Pw(kvp.Value, kvp.Key);
            }

            Console.WriteLine($"{n} {ans}");
        }
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Fundamental Neighbors");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}