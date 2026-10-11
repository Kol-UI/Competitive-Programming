// Maximal AND
namespace CompetitiveProgramming.CodeForces.MaximalAND;
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
            string[] first = Console.ReadLine().Split();
            long n = long.Parse(first[0]);
            long k = long.Parse(first[1]);

            long[] v = new long[31];
            string[] vals = Console.ReadLine().Split();
            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(vals[p]);
                for (long b = 0; b < 31; b++)
                {
                    v[b] += x % 2;
                    x /= 2;
                }
            }

            long res = 0;
            for (long b = 30; b >= 0; b--)
            {
                if (v[b] + k >= n)
                {
                    res += (1L << (int)b);
                    k -= (n - v[b]);
                }
            }

            Console.WriteLine(res);
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
        StyleHelper.Title("Maximal AND");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}