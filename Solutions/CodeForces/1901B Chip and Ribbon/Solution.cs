// Chip and Ribbon
namespace CompetitiveProgramming.CodeForces.ChipandRibbon;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();

            long prev = long.Parse(input[0]);
            long ans = prev - 1;

            for (long p = 1; p < n; p++)
            {
                long x = long.Parse(input[p]);
                long diff = x - prev;
                if (diff < 0) diff = 0;
                ans += diff;
                prev = x;
            }

            Console.WriteLine(ans);
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
        StyleHelper.Title("Chip and Ribbon");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}
