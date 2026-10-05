// Omkar and Last Class of Math
namespace CompetitiveProgramming.CodeForces.OmkarandLastClassofMath;
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
            long div = n;
            for (long p = 2; p * p <= n; p++)
            {
                if (n % p == 0) { div = p; break; }
            }
            Console.WriteLine((n / div) + " " + (n / div * (div - 1)));
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Omkar and Last Class of Math");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}