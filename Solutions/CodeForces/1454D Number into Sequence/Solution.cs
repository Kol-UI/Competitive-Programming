// Number into Sequence
namespace CompetitiveProgramming.CodeForces.NumberintoSequence;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Solution
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            Dictionary<long, long> factors = new Dictionary<long, long>();
            long rem = n;

            for (long p = 2; p * p <= n; p++)
            {
                if (p * p > rem) break;
                if (rem % p != 0) continue;
                while (rem % p == 0)
                {
                    if (factors.ContainsKey(p)) factors[p]++;
                    else factors[p] = 1;
                    rem /= p;
                }
            }

            if (rem > 0) factors[rem] = 1;

            long mx = 0, div = 1;
            foreach (var kv in factors)
            {
                if (kv.Value > mx) { mx = kv.Value; div = kv.Key; }
            }

            Console.WriteLine(mx);
            for (long p = 1; p < mx; p++)
            {
                Console.Write(div + " ");
                n /= div;
            }
            Console.WriteLine(n);
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Number into Sequence");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}