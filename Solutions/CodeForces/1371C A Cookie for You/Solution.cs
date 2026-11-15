// A Cookie for You
namespace CompetitiveProgramming.CodeForces.ACookieforYou;
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
            string[] vals = Console.ReadLine().Split();
            long a = long.Parse(vals[0]);
            long b = long.Parse(vals[1]);
            long n = long.Parse(vals[2]);
            long m = long.Parse(vals[3]);

            long least = a < b ? a : b;
            Console.WriteLine((m + n <= a + b && m <= least) ? "Yes" : "No");
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
        StyleHelper.Title("A Cookie for You");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}