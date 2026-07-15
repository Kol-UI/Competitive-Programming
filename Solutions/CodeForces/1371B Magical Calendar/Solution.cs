// Magical Calendar
namespace CompetitiveProgramming.CodeForces.MagicalCalendar;
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
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            long r = long.Parse(input[1]);

            long ans = (r >= n) ? 1 : 0;
            if (r >= n) r = n - 1;
            ans += r * (r + 1) / 2;

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
        StyleHelper.Title("Magical Calendar");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}