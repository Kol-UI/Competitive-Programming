// Phoenix and Puzzle
namespace CompetitiveProgramming.CodeForces.PhoenixandPuzzle;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        HashSet<long> s = new HashSet<long>();
        for (long p = 1; p < 100000; p++) s.Add(p * p);

        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            bool condition = (n % 2 == 0 && s.Contains(n / 2)) || (n % 4 == 0 && s.Contains(n / 4));
            Console.WriteLine(condition ? "YES" : "NO");
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Phoenix and Puzzle");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}