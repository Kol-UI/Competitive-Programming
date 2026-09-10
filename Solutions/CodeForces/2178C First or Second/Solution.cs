// First or Second
namespace CompetitiveProgramming.CodeForces.FirstorSecond;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        string tLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(tLine)) return;

        long t = long.Parse(tLine.Trim());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine().Trim());
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            long f = 0;
            long s = long.Parse(parts[0]);

            for (int p = 1; p < n; p++)
            {
                long x = long.Parse(parts[p]);
                f = Math.Max(f - x, s);
                s += Math.Abs(x);
            }

            Console.WriteLine(f);
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("First or Second");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}