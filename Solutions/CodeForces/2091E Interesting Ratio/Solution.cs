// Interesting Ratio
namespace CompetitiveProgramming.CodeForces.InterestingRatio;
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
        const long N = 10000007;

        bool[] vb = new bool[N];
        for (long p = 0; p < N; p++) vb[p] = true;
        vb[0] = vb[1] = false;

        for (long p = 2; p < N; p++)
        {
            if (!vb[p]) continue;
            for (long q = 2 * p; q < N; q += p) vb[q] = false;
        }

        List<long> w = new List<long>();
        for (long p = 0; p < N; p++) if (vb[p]) w.Add(p);

        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            long cnt = 0;
            for (int p = 0; p < w.Count; p++)
            {
                if (w[p] > n) break;
                cnt += n / w[p];
            }

            Console.WriteLine(cnt);
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Interesting Ratio");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}