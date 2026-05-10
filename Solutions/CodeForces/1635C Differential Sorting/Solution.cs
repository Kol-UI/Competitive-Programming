// Differential Sorting
namespace CompetitiveProgramming.CodeForces.DifferentialSorting;
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
            
            if (a[(int)(n - 2)] > a[(int)(n - 1)])
            {
                Console.WriteLine("-1");
            }
            else if (a[(int)(n - 1)] < 0)
            {
                bool sorted = true;
                for (long p = 1; p < n; p++)
                {
                    if (a[(int)(p - 1)] > a[(int)p])
                    {
                        sorted = false;
                        break;
                    }
                }
                Console.WriteLine(sorted ? "0" : "-1");
            }
            else
            {
                Console.WriteLine(n - 2);
                for (long p = 1; p < n - 1; p++)
                {
                    Console.WriteLine($"{p} {n - 1} {n}");
                }
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
        StyleHelper.Title("Differential Sorting");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}