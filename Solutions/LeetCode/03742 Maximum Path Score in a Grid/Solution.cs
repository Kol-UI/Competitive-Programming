// Maximum Path Score in a Grid
namespace CompetitiveProgramming.LeetCode.MaximumPathScoreinaGrid;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxPathScore(int[][] grid, int k)
    {
        int m = grid.Length, n = grid[0].Length;

        int GetScore(int val) => val;
        int GetCost(int val) => val == 0 ? 0 : 1;

        int[,,] dp = new int[m, n, k + 1];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int c = 0; c <= k; c++)
                {
                    dp[i, j, c] = -1;
                }
            }
        }

        int startCost = GetCost(grid[0][0]);
        int startScore = GetScore(grid[0][0]);

        if (startCost <= k)
            dp[0, 0, startCost] = startScore;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int cost = GetCost(grid[i][j]);
                int score = GetScore(grid[i][j]);

                for (int c = 0; c <= k; c++)
                {
                    if (i == 0 && j == 0) continue;

                    if (c < cost) continue;

                    int best = -1;

                    if (i > 0 && dp[i - 1, j, c - cost] != -1)
                        best = Math.Max(best, dp[i - 1, j, c - cost] + score);

                    if (j > 0 && dp[i, j - 1, c - cost] != -1)
                        best = Math.Max(best, dp[i, j - 1, c - cost] + score);

                    dp[i, j, c] = best;
                }
            }
        }

        int result = -1;
        for (int c = 0; c <= k; c++)
        {
            result = Math.Max(result, dp[m - 1, n - 1, c]);
        }

        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MaxPathScore([[0, 1],[2, 0]], 1), 2),
            ResultTester.CheckResult<int>(solution.MaxPathScore([[0, 1],[1, 2]], 1), -1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Path Score in a Grid");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}