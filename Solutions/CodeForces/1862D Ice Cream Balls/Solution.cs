// Ice Cream Balls
namespace CompetitiveProgramming.CodeForces.IceCreamBalls;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
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

            long res = 0, left = 0, right = 2000000015;
            while (left <= right)
            {
                long mid = (left + right) / 2;
                long comb = mid * (mid - 1) / 2;
                if (comb <= n)
                {
                    res = mid + (n - comb);
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            Console.WriteLine(res);
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Ice Cream Balls");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}