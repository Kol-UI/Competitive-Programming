// Basketball Together
namespace CompetitiveProgramming.CodeForces.BasketballTogether;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        long n = input[0];
        long d = input[1];
        
        long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        Array.Sort(numbers);
        Array.Reverse(numbers);
        
        long remaining = n;
        long count = 0;
        
        foreach (long number in numbers)
        {
            long required = 1 + d / number;
            if (required <= remaining)
            {
                remaining -= required;
                count++;
            }
            else
            {
                break;
            }
        }
        
        Console.WriteLine(count);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Basketball Together");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}