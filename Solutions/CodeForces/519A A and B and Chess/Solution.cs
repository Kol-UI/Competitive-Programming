// A and B and Chess
namespace CompetitiveProgramming.CodeForces.AandBandChess;
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
        const int N = 8;
        int total = 0;
        Dictionary<char, int> value = new Dictionary<char, int>
        {
            {'q', -9}, {'r', -5}, {'b', -3}, {'n', -3}, {'p', -1}, {'k', 0},
            {'Q', 9}, {'R', 5}, {'B', 3}, {'N', 3}, {'P', 1}, {'K', 0}
        };

        for (int p = 0; p < N; p++)
        {
            string row = Console.ReadLine()!;
            foreach (char c in row)
            {
                if (c != '.') total += value[c];
            }
        }

        if (total > 0) Console.WriteLine("White");
        else if (total < 0) Console.WriteLine("Black");
        else Console.WriteLine("Draw");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("A and B and Chess");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}