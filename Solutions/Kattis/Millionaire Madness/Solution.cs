// Millionaire Madness
namespace CompetitiveProgramming.Kattis.MillionaireMadness;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int m = int.Parse(firstLine[1]);

        int[][] grid = new int[n][];
        for (int i = 0; i < n; i++)
        {
            string[] row = Console.ReadLine().Split();
            grid[i] = new int[m];
            for (int j = 0; j < m; j++)
            {
                grid[i][j] = int.Parse(row[j]);
            }
        }

        int[][] vis = new int[n][];
        for (int i = 0; i < n; i++)
        {
            vis[i] = new int[m];
        }

        var pq = new SortedSet<(int cst, int i, int j)>();
        int mx = 0;
        pq.Add((0, 0, 0));

        while (pq.Count > 0)
        {
            var (cst, i, j) = pq.Min;
            pq.Remove(pq.Min);

            mx = Math.Max(mx, cst);
            if (i == n - 1 && j == m - 1) break;

            if (vis[i][j] == 1) continue;
            vis[i][j] = 1;

            int[] di = { -1, 1, 0, 0 };
            int[] dj = { 0, 0, -1, 1 };

            for (int d = 0; d < 4; d++)
            {
                int ni = i + di[d];
                int nj = j + dj[d];
                if (ni < 0 || ni >= n || nj < 0 || nj >= m || vis[ni][nj] == 1) continue;
                int dst = Math.Max(0, grid[ni][nj] - grid[i][j]);
                pq.Add((dst, ni, nj));
            }
        }

        Console.WriteLine(mx);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Millionaire Madness");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}