// Box Fitting
namespace CompetitiveProgramming.CodeForces.BoxFitting;
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
            string[] first = Console.ReadLine().Split();
            long n = long.Parse(first[0]);
            long w = long.Parse(first[1]);

            Dictionary<long, long> rem = new Dictionary<long, long>();
            string[] vals = Console.ReadLine().Split();
            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(vals[p]);
                if (rem.ContainsKey(x)) rem[x]++;
                else rem[x] = 1;
            }

            long[] v = new long[100007];
            for (long i = 0; i < v.Length; i++) v[i] = w;

            long res = 0;
            for (int p = 30; p >= 0; p--)
            {
                long cur = 1L << p;
                long rod = rem.ContainsKey(cur) ? rem[cur] : 0;
                bool carryon = true;
                for (long idx = 0; carryon && idx < v.Length; idx++)
                {
                    long cap = v[idx] / cur;
                    if (cap >= rod) { cap = rod; carryon = false; }
                    rod -= cap;
                    v[idx] -= cap * cur;
                    if (idx > res) res = idx;
                }
            }

            Console.WriteLine(res + 1);
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
        StyleHelper.Title("Box Fitting");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}