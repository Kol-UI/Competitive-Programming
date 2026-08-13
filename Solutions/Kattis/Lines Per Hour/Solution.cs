// Lines Per Hour
namespace CompetitiveProgramming.Kattis.LinesPerHour;
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
        int lph = int.Parse(firstLine[1]);

        int tot = lph * 5;
        List<int> loc = new List<int>();

        for (int i = 0; i < n; i++)
            loc.Add(int.Parse(Console.ReadLine()));

        loc.Sort();

        int W = 0;
        foreach (int val in loc)
            W += val;

        int[,] dp = new int[n + 1, W + 1];

        for (int i = 0; i < n; i++)
        {
            for (int w = 0; w <= W; w++)
            {
                dp[i + 1, w] = dp[i, w];
                if (w >= loc[i])
                {
                    int val = dp[i, w - loc[i]] + 1;
                    if (val > dp[i + 1, w])
                        dp[i + 1, w] = val;
                }
            }
        }

        int limit = tot < W ? tot : W;
        Console.WriteLine(dp[n, limit]);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Lines Per Hour");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}