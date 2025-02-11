// Maximum Number of Fish in a Grid

namespace CompetitiveProgramming.LeetCode.MaximumNumberofFishinaGrid;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int FindMaxFish(int[][] grid)
    {
        int m = grid.Length, n = grid[0].Length, answer = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] > 0)
                {
                    answer = Math.Max(DFS(grid, i, j), answer);
                }
            }
        }
        return answer;
    }

    private int DFS(int[][] grid, int i, int j)
    {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] == 0) return 0;
        int fish = grid[i][j];
        grid[i][j] = 0;
        return fish + DFS(grid, i + 1, j) + DFS(grid, i - 1, j) + DFS(grid, i, j + 1) + DFS(grid, i, j - 1);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Number of Fish in a Grid");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}