// Indian Summer
namespace CompetitiveProgramming.CodeForces.IndianSummer;
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
        int n = int.Parse(Console.ReadLine());
        HashSet<(string, string)> pairs = new HashSet<(string, string)>();
        
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            pairs.Add((input[0], input[1]));
        }
        
        Console.WriteLine(pairs.Count);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Indian Summer");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}