// A BIT of a Construction
namespace CompetitiveProgramming.CodeForces.ABITofaConstruction;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

public class Solution
{
    static public void Main()
    {
        long t = long.Parse(Console.ReadLine());
        
        for(long i = 0; i < t; i++)
        {
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long n = input[0];
            long k = input[1];
            
            if(n == 1)
            {
                Console.Write(k);
            }
            else
            {
                long maxVal = 0;
                long test = 1;
                while(test <= k)
                {
                    maxVal = test;
                    test *= 2;
                }
                Console.Write($"{maxVal - 1} {k - maxVal + 1} ");
            }
            
            for(long p = 2; p < n; p++)
            {
                Console.Write("0 ");
            }
            Console.WriteLine();
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
        StyleHelper.Title("A BIT of a Construction");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}