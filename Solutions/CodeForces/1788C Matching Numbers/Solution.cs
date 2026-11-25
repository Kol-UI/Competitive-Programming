// Matching Numbers
namespace CompetitiveProgramming.CodeForces.MatchingNumbers;
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

            if (n % 2 == 0)
            {
                Console.WriteLine("No");
                continue;
            }

            Console.WriteLine("Yes");

            for (long p = 1; p <= n; p += 2)
                Console.WriteLine(p + " " + (2 * n - p / 2));

            for (long p = 2; p < n; p += 2)
                Console.WriteLine(p + " " + ((3 * n - p + 1) / 2));
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Matching Numbers");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}