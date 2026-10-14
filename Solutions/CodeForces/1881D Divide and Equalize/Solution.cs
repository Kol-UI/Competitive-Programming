// Divide and Equalize
namespace CompetitiveProgramming.CodeForces.DivideandEqualize;
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
                for (long d = 2; d * d <= x; d++)
                {
                    while (x % d == 0)
                    {
                        if (m.ContainsKey(d)) m[d]++;
                        else m[d] = 1;
                        x /= d;
                    }
                }
                if (x > 1)
                {
                    if (m.ContainsKey(x)) m[x]++;
                    else m[x] = 1;
                }
            }

            bool res = true;
            foreach (var kv in m)
            {
                if (kv.Value % n != 0) { res = false; break; }
            }

            Console.WriteLine(res ? "YES" : "NO");
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
        StyleHelper.Title("Divide and Equalize");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}