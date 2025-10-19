// Garden
namespace CompetitiveProgramming.CodeForces.Garden;
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
        long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        long n = input[0];
        long k = input[1];
        
        long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        long minTime = k;
        
        foreach (long number in numbers)
        {
            if (k % number == 0)
            {
                long time = k / number;
                minTime = Math.Min(minTime, time);
            }
        }
        
        Console.WriteLine(minTime);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Garden");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}