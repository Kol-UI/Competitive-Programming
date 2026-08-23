// Hungry Sequence
namespace CompetitiveProgramming.CodeForces.HungrySequence;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        for (long k = n + 1; k <= 2 * n; k++)
        {
            Console.Write($"{k} ");
        }
        Console.WriteLine();
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Hungry Sequence");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}