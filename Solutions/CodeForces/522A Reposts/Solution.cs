// Reposts
namespace CompetitiveProgramming.CodeForces.Reposts;
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
        string initial = "polycarp";
        Dictionary<string, long> rank = new Dictionary<string, long>();
        rank[initial] = 1;

        long n = long.Parse(Console.ReadLine());
        long length = 0;

        for (long i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string to = input[0].ToLower();
            string action = input[1];
            string from = input[2].ToLower();

            rank[to] = rank[from] + 1;
            if (rank[to] > length) length = rank[to];
        }

        Console.WriteLine(length);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Reposts");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}