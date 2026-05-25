// Cosmic Path Optimization
namespace CompetitiveProgramming.Kattis.CosmicPathOptimization;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        int T_sum = 0;

        for (int i = 0; i < m; i++)
        {
            int x = int.Parse(input[i]);
            T_sum += x;
        }

        Console.WriteLine(T_sum / m);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Cosmic Path Optimization");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}