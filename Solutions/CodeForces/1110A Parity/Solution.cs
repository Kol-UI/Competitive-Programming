// Parity
namespace CompetitiveProgramming.CodeForces.Parity;
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
        long b = input[0];
        long k = input[1];
        
        long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        
        long parity = numbers[k - 1] % 2;
        for (int p = 0; p < k - 1; p++)
        {
            parity += (numbers[p] % 2) * (b % 2);
        }
        parity %= 2;
        
        Console.WriteLine(parity == 1 ? "odd" : "even");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Parity");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}