// Sorted Adjacent Differences
namespace CompetitiveProgramming.CodeForces.SortedAdjacentDifferences;
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
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            List<long> a = new List<long>();
            for (long p = 0; p < n; p++)
            {
                a.Add(long.Parse(input[p]));
            }
            a.Sort();
            
            long left = (n - 1) / 2;
            long right = (n + 1) / 2;
            
            while (left >= 0 || right < n)
            {
                if (left >= 0)
                {
                    Console.Write($"{a[(int)left--]} ");
                }
                if (right < n)
                {
                    Console.Write($"{a[(int)right++]} ");
                }
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
        StyleHelper.Title("Sorted Adjacent Differences");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}