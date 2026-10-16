// Alice, Bob and Candies
namespace CompetitiveProgramming.CodeForces.AliceBobandCandies;
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
            long[] a = new long[n];
            string[] vals = Console.ReadLine().Split();
            for (long p = 0; p < n; p++) a[p] = long.Parse(vals[p]);

            long cnt = 0, alice = 0, bob = 0;
            long x = 0, y = n - 1;
            long cur = 0, prev = 0;

            while (x <= y)
            {
                while (x <= y && cur <= prev) { cur += a[x]; alice += a[x]; x++; }
                prev = cur; cnt += (cur > 0) ? 1 : 0; cur = 0;

                while (x <= y && cur <= prev) { cur += a[y]; bob += a[y]; y--; }
                prev = cur; cnt += (cur > 0) ? 1 : 0; cur = 0;
            }

            Console.WriteLine(cnt + " " + alice + " " + bob);
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
        StyleHelper.Title("Alice, Bob and Candies");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}