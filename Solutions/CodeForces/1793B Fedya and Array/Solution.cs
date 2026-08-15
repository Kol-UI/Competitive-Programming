// Fedya and Array
namespace CompetitiveProgramming.CodeForces.FedyaandArray;
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
            long x = long.Parse(input[0]);
            long y = long.Parse(input[1]);

            Console.WriteLine(2 * (x - y));

            for (long p = y; p <= x; p++)
                Console.Write($"{p} ");

            for (long p = x - 1; p > y; p--)
                Console.Write($"{p} ");

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
        StyleHelper.Title("Fedya and Array");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}
