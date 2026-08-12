// Pile Shuffling
namespace CompetitiveProgramming.CodeForces.PileShuffling;
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
            long total = 0;

            for (long p = 0; p < n; p++)
            {
                string[] input = Console.ReadLine().Split();
                long a = long.Parse(input[0]);
                long b = long.Parse(input[1]);
                long c = long.Parse(input[2]);
                long d = long.Parse(input[3]);

                if (b > d)
                    total += a + (b - d);
                else
                    total += (a > c) ? (a - c) : 0;
            }

            Console.WriteLine(total);
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
        StyleHelper.Title("Pile Shuffling");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}
