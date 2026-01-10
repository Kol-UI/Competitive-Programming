// GCD Compression
namespace CompetitiveProgramming.CodeForces.GCDCompression;
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
        int t = int.Parse(Console.ReadLine());
        
        for (int test = 0; test < t; test++)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> odds = new List<int>();
            List<int> evens = new List<int>();
            
            string[] numbers = Console.ReadLine().Split();
            for (int i = 0; i < 2 * n; i++)
            {
                int x = int.Parse(numbers[i]);
                if (x % 2 == 1) odds.Add(i + 1);
                else evens.Add(i + 1);
            }
            
            int pairsNeeded = n - 1;
            
            for (int i = 0; i + 1 < odds.Count && pairsNeeded > 0; i += 2)
            {
                Console.WriteLine($"{odds[i]} {odds[i + 1]}");
                pairsNeeded--;
            }
            
            for (int i = 0; i + 1 < evens.Count && pairsNeeded > 0; i += 2)
            {
                Console.WriteLine($"{evens[i]} {evens[i + 1]}");
                pairsNeeded--;
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
        StyleHelper.Title("Title");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}