// A and B and Team Training
namespace CompetitiveProgramming.CodeForces.AandBandTeamTraining;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Solution
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        long a = long.Parse(input[0]);
        long b = long.Parse(input[1]);

        if (b < a)
        {
            long temp = a;
            a = b;
            b = temp;
        }

        long ans = 0;
        for (int p = 0; p <= a && 2 * p <= b; p++)
        {
            long test = p + Math.Min(b - 2 * p, (a - p) / 2);
            if (test > ans) ans = test;
        }

        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("A and B and Team Training");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}