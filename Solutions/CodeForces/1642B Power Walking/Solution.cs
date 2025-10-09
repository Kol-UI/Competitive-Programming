// Power Walking
namespace CompetitiveProgramming.CodeForces.PowerWalking;
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
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<long> uniqueNumbers = new HashSet<long>();
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            foreach (long number in numbers)
            {
                uniqueNumbers.Add(number);
            }
            
            int distinctCount = uniqueNumbers.Count;
            
            for (int position = 1; position <= n; position++)
            {
                long value = position > distinctCount ? position : distinctCount;
                Console.Write(value + " ");
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
        StyleHelper.Title("Power Walking");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}