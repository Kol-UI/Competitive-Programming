// Sign Flipping
namespace CompetitiveProgramming.CodeForces.SignFlipping;
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

            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(input[p]);

                if (p % 2 == 1 && x > 0)
                    Console.Write($"{(-x)} ");
                else if (p % 2 == 0 && x < 0)
                    Console.Write($"{(-x)} ");
                else
                    Console.Write($"{x} ");
            }
            Console.WriteLine();
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
        StyleHelper.Title("Sign Flipping");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}