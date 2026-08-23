// Oooh I See
namespace CompetitiveProgramming.Kattis.OoohISee;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8601

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int r = int.Parse(firstLine[0]);
        int c = int.Parse(firstLine[1]);

        string[] grid = new string[r];
        for (int i = 0; i < r; i++)
            grid[i] = Console.ReadLine();

        List<(int, int)> ans = new List<(int, int)>();

        for (int i = 1; i < r - 1; i++)
        {
            for (int j = 1; j < c - 1; j++)
            {
                if (grid[i][j] == '0')
                {
                    bool bad = false;
                    for (int ni = i - 1; ni <= i + 1; ni++)
                    {
                        for (int nj = j - 1; nj <= j + 1; nj++)
                        {
                            if ((ni, nj) != (i, j) && grid[ni][nj] != 'O')
                            {
                                bad = true;
                                break;
                            }
                        }
                        if (bad) break;
                    }
                    if (!bad)
                        ans.Add((i + 1, j + 1));
                }
            }
        }

        if (ans.Count == 0)
        {
            Console.WriteLine("Oh no!");
        }
        else if (ans.Count == 1)
        {
            Console.WriteLine($"{ans[0].Item1} {ans[0].Item2}");
        }
        else
        {
            Console.WriteLine($"Oh no! {ans.Count} locations");
        }
    }
}

#pragma warning restore CS8601
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Oooh I See");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}