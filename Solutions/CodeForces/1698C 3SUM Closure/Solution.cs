// 3SUM Closure
namespace CompetitiveProgramming.CodeForces.ThreeSUMClosure;
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
            List<long> v = new List<long>();
            HashSet<long> s = new HashSet<long>();

            long pos = 0, neg = 0, z = 0;
            bool possible = true;

            string[] vals = Console.ReadLine().Split();
            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(vals[p]);
                if (x == 0) { z++; continue; }
                v.Add(x);
                s.Add(x);
                if (x > 0) pos++;
                if (x < 0) neg++;
                if (pos > 2 || neg > 2) possible = false;
            }

            if (z > 0) { v.Add(0); s.Add(0); }
            if (z > 1) { v.Add(0); s.Add(0); }

            for (int p = 0; possible && p < v.Count; p++)
            {
                for (int q = p + 1; possible && q < v.Count; q++)
                {
                    for (int r = q + 1; possible && r < v.Count; r++)
                    {
                        if (!s.Contains(v[p] + v[q] + v[r])) possible = false;
                    }
                }
            }

            Console.WriteLine(possible ? "YES" : "NO");
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
        StyleHelper.Title("3SUM Closure");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}