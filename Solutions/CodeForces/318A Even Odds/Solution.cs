// Even Odds
namespace CompetitiveProgramming.EvenOdds;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        string[] input = Console.ReadLine()!.Split();
        long n = long.Parse(input[0]);
        long k = long.Parse(input[1]);
        long x = (n + 1) / 2;
        long result = k <= x ? 1 + (k - 1) * 2 : 2 + (k - x - 1) * 2;
        Console.WriteLine(result);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Even Odds");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}