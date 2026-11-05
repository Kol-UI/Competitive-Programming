// We Were Both Children
namespace CompetitiveProgramming.CodeForces.WeWereBothChildren;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
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
            Dictionary<long, long> m = new Dictionary<long, long>();

            string[] vals = Console.ReadLine().Split();
            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(vals[p]);
                if (m.ContainsKey(x)) m[x]++;
                else m[x] = 1;
            }

            long[] v = new long[n + 1];
            long mx = 0;

            foreach (var kv in m)
            {
                long key = kv.Key;
                long val = kv.Value;
                for (long p = 1; p * key <= n; p++)
                {
                    v[p * key] += val;
                    if (v[p * key] > mx) mx = v[p * key];
                }
            }

            Console.WriteLine(mx);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("We Were Both Children");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}