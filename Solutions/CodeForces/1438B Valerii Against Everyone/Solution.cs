// Valerii Against Everyone
namespace CompetitiveProgramming.CodeForces.ValeriiAgainstEveryone;
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
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            HashSet<long> uniqueNumbers = new HashSet<long>();
            bool hasDuplicate = false;
            
            foreach (long number in numbers)
            {
                if (uniqueNumbers.Contains(number))
                {
                    hasDuplicate = true;
                }
                uniqueNumbers.Add(number);
            }
            
            Console.WriteLine(hasDuplicate ? "YES" : "NO");
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
        StyleHelper.Title("Valerii Against Everyone");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}