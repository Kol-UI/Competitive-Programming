// Romantic Glasses
namespace CompetitiveProgramming.CodeForces.RomanticGlasses;
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
            long[] v = new long[n];
            string[] vals = Console.ReadLine().Split();
            for (long p = 0; p < n; p++)
            {
                v[p] = long.Parse(vals[p]);
                if (p % 2 == 1) v[p] = -v[p];
            }

            long cs = 0;
            bool ans = false;
            HashSet<long> w = new HashSet<long>();
            w.Add(0);
            for (long p = 0; !ans && p < n; p++)
            {
                cs += v[p];
                if (w.Contains(cs)) ans = true;
                w.Add(cs);
            }

            Console.WriteLine(ans ? "YES" : "NO");
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
        StyleHelper.Title("Romantic Glasses");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}