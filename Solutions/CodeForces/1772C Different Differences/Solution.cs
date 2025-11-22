// Different Differences
namespace CompetitiveProgramming.CodeForces.DifferentDifferences;
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
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long k = input[0];
            long n = input[1];
            
            long[] sequence = new long[k + 1];
            sequence[1] = 1;
            long increment = 1;
            
            for (long position = 2; position <= k; position++)
            {
                if (increment < 0)
                {
                    sequence[position] = sequence[position - 1] + 1;
                    continue;
                }
                
                long nextValue = sequence[position - 1] + increment;
                if (n - nextValue < k - position)
                {
                    sequence[position] = sequence[position - 1] + 1;
                    increment = -1;
                }
                else
                {
                    sequence[position] = nextValue;
                    increment++;
                }
            }
            
            for (long position = 1; position <= k; position++)
            {
                Console.Write(sequence[position] + " ");
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
        StyleHelper.Title("Different Differences");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}