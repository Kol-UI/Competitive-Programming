// Increasing Sequence
namespace CompetitiveProgramming.CodeForces.AIncreasingSequence;
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
        long d = long.Parse(input[1]);
        
        long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        long current = -1;
        long total = 0;
        
        foreach (long num in numbers)
        {
            if (current < num)
            {
                current = num;
            }
            else
            {
                long steps = 1 + (current - num) / d;
                current = num + steps * d;
                total += steps;
            }
        }
        
        Console.WriteLine(total);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Increasing Sequence");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}