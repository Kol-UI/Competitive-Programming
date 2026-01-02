// Difference of GCDs
namespace CompetitiveProgramming.CodeForces.DifferenceofGCDs;
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
            long n = input[0];
            long l = input[1];
            long r = input[2];
            
            List<long> result = new List<long>();
            bool valid = true;
            
            for (long i = 1; i <= n; i++)
            {
                long value = (1 + (l - 1) / i) * i;
                if (value > r)
                {
                    valid = false;
                    break;
                }
                result.Add(value);
            }
            
            if (valid)
            {
                Console.WriteLine("YES");
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("NO");
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
        StyleHelper.Title("Difference of GCDs");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}