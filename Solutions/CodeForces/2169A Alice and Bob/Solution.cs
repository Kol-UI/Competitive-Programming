// Alice and Bob
namespace CompetitiveProgramming.CodeForces.AliceandBob;
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
        int testCases = int.Parse(Console.ReadLine());
        
        for (int test = 0; test < testCases; test++)
        {
            long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long n = input[0];
            long a = input[1];
            
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long diff = 0;
            
            foreach (long x in numbers)
            {
                if (x > a) diff++;
                else if (x < a) diff--;
            }
            
            long result = a - 1 + 2 * (diff > 0 ? 1 : 0);
            Console.WriteLine(result);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Alice and Bob");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}