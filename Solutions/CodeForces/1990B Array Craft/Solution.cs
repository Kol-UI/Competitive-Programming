// Array Craft
namespace CompetitiveProgramming.CodeForces.ArrayCraft;
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
            long x = long.Parse(input[1]);
            long y = long.Parse(input[2]);
            
            for (long p = 1; p <= n; p++)
            {
                if (p < y)
                {
                    Console.Write((p % 2 == y % 2) ? "1 " : "-1 ");
                }
                else if (p <= x)
                {
                    Console.Write("1 ");
                }
                else
                {
                    Console.Write((p % 2 == x % 2) ? "1 " : "-1 ");
                }
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
        StyleHelper.Title("Array Craft");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}