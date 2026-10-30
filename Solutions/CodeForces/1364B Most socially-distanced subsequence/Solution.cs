// Most socially-distanced subsequence
namespace CompetitiveProgramming.CodeForces.Mostsociallydistancedsubsequence;
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
            long[] a = new long[n];
            string[] vals = Console.ReadLine().Split();
            for (long p = 0; p < n; p++) a[p] = long.Parse(vals[p]);

            List<long> ans = new List<long>();
            for (long p = 0; p < n; p++)
            {
                if (p == 0 || p + 1 == n || ((a[p - 1] < a[p]) != (a[p] < a[p + 1])))
                    ans.Add(a[p]);
            }

            Console.WriteLine(ans.Count);
            Console.WriteLine(string.Join(" ", ans));
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
        StyleHelper.Title("Most socially-distanced subsequence");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}