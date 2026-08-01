// Make Array Good
namespace CompetitiveProgramming.CodeForces.MakeArrayGood;
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
            Console.WriteLine(n);

            string[] input = Console.ReadLine().Split();
            for (long p = 1; p <= n; p++)
            {
                long x = long.Parse(input[p - 1]);
                long y = 1;
                while (y < x) y *= 2;

                Console.WriteLine($"{p} {y - x}");
            }
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
        StyleHelper.Title("Make Array Good");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}