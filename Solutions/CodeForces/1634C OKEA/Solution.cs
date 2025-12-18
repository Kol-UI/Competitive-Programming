// OKEA
namespace CompetitiveProgramming.CodeForces.OKEA;
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
            long k = input[1];
            
            if (n % 2 == 1 && k > 1)
            {
                Console.WriteLine("NO");
                continue;
            }
            
            Console.WriteLine("YES");
            for (long row = 1; row <= n; row++)
            {
                for (long col = 0; col < k; col++)
                {
                    long value = row + n * col;
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }
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
        StyleHelper.Title("OKEA");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}