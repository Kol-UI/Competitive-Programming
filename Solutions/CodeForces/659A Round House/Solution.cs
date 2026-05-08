// Round House
namespace CompetitiveProgramming.CodeForces.RoundHouse;
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
        string[] input = Console.ReadLine().Split();
        long n = long.Parse(input[0]);
        long a = long.Parse(input[1]);
        long b = long.Parse(input[2]);
        
        long ans = 1 + (n + (a - 1 + b) % n) % n;
        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Round House");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}