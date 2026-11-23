// Two Round Dances
namespace CompetitiveProgramming.CodeForces.TwoRoundDances;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

class Solution
{
    static long Fact(long x)
    {
        long res = 1;
        for (long p = 1; p <= x; p++) res *= p;
        return res;
    }

    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long ans = Fact(n) / (n / 2) / (n / 2) / 2;
        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Two Round Dances");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}