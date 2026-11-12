// Light Up
namespace CompetitiveProgramming.Kattis.LightUp;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8601
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Solution
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] grid = new string[n];
        for (int i = 0; i < n; i++) grid[i] = Console.ReadLine();

        var bulbs = new List<(int, int)>();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                char c = grid[i][j];
                if (c == '.') continue;
                if (c == 'X') continue;
                if (c == '?') { bulbs.Add((i, j)); continue; }

                int need = c - '0';
                int have = 0;
                foreach (var (ni, nj) in new (int, int)[] { (i - 1, j), (i + 1, j), (i, j - 1), (i, j + 1) })
                {
                    if (ni < 0 || ni >= n || nj < 0 || nj >= n) continue;
                    if (grid[ni][nj] == '?') have++;
                }

                if (have != need)
                {
                    Console.WriteLine(0);
                    return;
                }
            }
        }

        bool[,] lit = new bool[n, n];

        foreach (var (bi, bj) in bulbs)
        {
            foreach (var (di, dj) in new (int, int)[] { (-1, 0), (1, 0), (0, -1), (0, 1) })
            {
                int i = bi + di;
                int j = bj + dj;

                while (i >= 0 && i < n && j >= 0 && j < n)
                {
                    if (grid[i][j] == '?')
                    {
                        Console.WriteLine(0);
                        return;
                    }
                    if (grid[i][j] != '.') break;
                    lit[i, j] = true;

                    i += di;
                    j += dj;
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] == '.' && !lit[i, j])
                {
                    Console.WriteLine(0);
                    return;
                }
            }
        }

        Console.WriteLine(1);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8601
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Light Up");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}