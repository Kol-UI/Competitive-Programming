// Relatively Prime Pairs
namespace CompetitiveProgramming.CodeForces.RelativelyPrimePairs;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Solution
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        long l = long.Parse(input[0]);
        long r = long.Parse(input[1]);
        
        Console.WriteLine("YES");
        for (long p = l; p <= r; p += 2)
        {
            Console.WriteLine($"{p} {p + 1}");
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Relatively Prime Pairs");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}