// Competitive Arcade Basketball
namespace CompetitiveProgramming.Kattis.CompetitiveArcadeBasketball;
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
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int p = int.Parse(firstLine[1]);
        int m = int.Parse(firstLine[2]);

        Dictionary<string, int> score = new Dictionary<string, int>();
        for (int i = 0; i < n; i++)
        {
            score[Console.ReadLine()] = 0;
        }

        bool won = false;

        for (int i = 0; i < m; i++)
        {
            string[] input = Console.ReadLine().Split();
            string name = input[0];
            int s = int.Parse(input[1]);

            if (score.ContainsKey(name))
            {
                score[name] += s;
                if (score[name] >= p)
                {
                    Console.WriteLine($"{name} wins!");
                    won = true;
                    score.Remove(name);
                }
            }
        }

        if (!won)
        {
            Console.WriteLine("No winner!");
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
        StyleHelper.Title("Competitive Arcade Basketball");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}