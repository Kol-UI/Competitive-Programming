// Almost Ternary Matrix
namespace CompetitiveProgramming.CodeForces.AlmostTernaryMatrix;
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
            long m = long.Parse(input[1]);
            for (long row = 1; row <= n; row++)
            {
                for (long col = 1; col <= m; col++)
                {
                    int value = ((row % 4 <= 1) != (col % 4 <= 1)) ? 1 : 0;
                    Console.Write(value + " ");
                }
                Console.WriteLine();
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
        StyleHelper.Title("Almost Ternary Matrix");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}