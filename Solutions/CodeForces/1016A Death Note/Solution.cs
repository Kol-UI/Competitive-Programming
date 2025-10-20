// Death Note
namespace CompetitiveProgramming.CodeForces.DeathNote;
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
        long m = input[1];
        
        long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        long sum = 0;
        
        foreach (long number in numbers)
        {
            sum += number;
            Console.Write(sum / m + " ");
            sum %= m;
        }
        
        Console.WriteLine();
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Death Note");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}