// The Lakes
namespace CompetitiveProgramming.CodeForces.TheLakes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static int Dfs(int x, int y, long[,] grid)
    {
        if (x < 0 || x >= grid.GetLength(0) || y < 0 || y >= grid.GetLength(1) || grid[x, y] == 0)
            return 0;
        int cur = (int)grid[x, y];
        grid[x, y] = 0;
        return cur + Dfs(x - 1, y, grid) + Dfs(x + 1, y, grid) + Dfs(x, y - 1, grid) + Dfs(x, y + 1, grid);
    }

    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0], m = nm[1];
            long[,] grid = new long[n, m];
            for (int i = 0; i < n; i++)
            {
                long[] row = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
                for (int j = 0; j < m; j++) grid[i, j] = row[j];
            }
            int mx = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    int cur = Dfs(i, j, grid);
                    if (cur > mx) mx = cur;
                }
            Console.WriteLine(mx);
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
        StyleHelper.Title("The Lakes");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}