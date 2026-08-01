// Combinatorics Homework
namespace CompetitiveProgramming.CodeForces.CombinatoricsHomework;
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
            string[] input = Console.ReadLine().Split();
            List<long> v = new List<long>
            {
                long.Parse(input[0]),
                long.Parse(input[1]),
                long.Parse(input[2])
            };
            long m = long.Parse(input[3]);

            v.Sort((a, b) => b.CompareTo(a));

            long mn = v[0] - v[1] - v[2] - 1;
            if (mn < 0) mn = 0;

            long mx = v[0] + v[1] + v[2] - 3;

            Console.WriteLine((mn <= m && m <= mx) ? "YES" : "NO");
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
        StyleHelper.Title("Combinatorics Homework");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}