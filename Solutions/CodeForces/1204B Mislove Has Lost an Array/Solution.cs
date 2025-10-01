// Mislove Has Lost an Array
namespace CompetitiveProgramming.CodeForces.MisloveHasLostanArray;
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
        long l = long.Parse(input[1]);
        long r = long.Parse(input[2]);
        
        long minSum = (n - l + 1);
        for (long p = 1; p < l; p++)
        {
            minSum += (1L << (int)p);
        }
        
        long maxSum = 0;
        long exponentLimit = r - 1;
        for (long p = 0; p < n; p++)
        {
            long exponent = Math.Min(p, exponentLimit);
            maxSum += (1L << (int)exponent);
        }
        
        Console.WriteLine($"{minSum} {maxSum}");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Mislove Has Lost an Array");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}