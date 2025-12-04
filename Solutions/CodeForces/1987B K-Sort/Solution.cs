// K-Sort
namespace CompetitiveProgramming.CodeForces.KSort;
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
        int testCases = int.Parse(Console.ReadLine());
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            int n = int.Parse(Console.ReadLine());
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            long previous = 0;
            long total = 0;
            long maxDiff = 0;
            
            foreach (long number in numbers)
            {
                if (number >= previous)
                {
                    previous = number;
                }
                else
                {
                    long diff = previous - number;
                    total += diff;
                    maxDiff = Math.Max(maxDiff, diff);
                }
            }
            
            Console.WriteLine(total + maxDiff);
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
        StyleHelper.Title("K-Sort");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}