// Prime Square
namespace CompetitiveProgramming.CodeForces.PrimeSquare;
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
            if (n == 2)
            {
                Console.WriteLine("4 1");
                Console.WriteLine("1 4");
                continue;
            }
            for (long row = 0; row < n; row++)
            {
                for (long col = 0; col < n; col++)
                {
                    if (col == row) Console.Write("4 ");
                    else if (col == (row + 1) % n) Console.Write("1 ");
                    else Console.Write("0 ");
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
        StyleHelper.Title("Prime Square");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}