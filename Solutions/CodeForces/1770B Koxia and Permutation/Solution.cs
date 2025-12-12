// Koxia and Permutation
namespace CompetitiveProgramming.CodeForces.KoxiaandPermutation;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());
        
        for (int test = 0; test < testCases; test++)
        {
            long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long count = input[0];
            long skip = input[1];
            
            long low = 1;
            long high = count;
            List<long> sequence = new List<long>();
            
            for (int i = 1; i <= count; i++)
            {
                if (i % 2 == 1)
                {
                    sequence.Add(high);
                    high--;
                }
                else
                {
                    sequence.Add(low);
                    low++;
                }
            }
            
            Console.WriteLine(string.Join(" ", sequence));
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
        StyleHelper.Title("Koxia and Permutation");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}