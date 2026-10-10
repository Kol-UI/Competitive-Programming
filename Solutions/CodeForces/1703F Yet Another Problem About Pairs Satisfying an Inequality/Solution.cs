// Yet Another Problem About Pairs Satisfying an Inequality
namespace CompetitiveProgramming.CodeForces.YetAnotherProblemAboutPairsSatisfyinganInequality;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            long[] v = new long[n + 1];
            long total = 0;

            string[] vals = Console.ReadLine().Split();
            for (long p = 1; p <= n; p++)
            {
                long x = long.Parse(vals[p - 1]);
                v[p] = v[p - 1];
                if (x < p)
                {
                    v[p]++;
                    total += (x != 0) ? v[x - 1] : 0;
                }
            }

            Console.WriteLine(total);
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
        StyleHelper.Title("Yet Another Problem About Pairs Satisfying an Inequality");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}