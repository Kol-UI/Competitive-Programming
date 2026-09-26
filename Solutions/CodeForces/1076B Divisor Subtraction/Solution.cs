// Divisor Subtraction
namespace CompetitiveProgramming.CodeForces.DivisorSubtraction;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        string nLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nLine)) return;

        long n = long.Parse(nLine.Trim());
        long res = 0;

        if (n % 2 != 0)
        {
            for (long p = 3; p * p <= n; p += 2)
            {
                if (n % p == 0)
                {
                    n -= p;
                    res = 1;
                    break;
                }
            }
            if (res == 0)
            {
                res = 1;
                n = 0;
            }
        }

        if (n > 0)
        {
            res += n / 2;
        }

        Console.WriteLine(res);
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Divisor Subtraction");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}