// Twisted Mirror Path Count
namespace CompetitiveProgramming.LeetCode.TwistedMirrorPathCount;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int UniquePaths(int[][] grid)
    {
        const int MOD = 1000000007;
        int m = grid.Length;
        int n = grid[0].Length;

        int[,,] f = new int[m, n, 2];
        f[0, 0, 0] = 1;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i > 0) {
                    if (grid[i - 1][j] == 0)
                    {
                        f[i, j, 0] = (f[i - 1, j, 0] + f[i - 1, j, 1]) % MOD;
                    }
                    else
                    {
                        f[i, j, 0] = f[i - 1, j, 1];
                    }
                }

                if (j > 0)
                {
                    if (grid[i][j - 1] == 0)
                    {
                        f[i, j, 1] = (f[i, j - 1, 0] + f[i, j - 1, 1]) % MOD;
                    }
                    else
                    {
                        f[i, j, 1] = f[i, j - 1, 0];
                    }
                }
            }
        }

        return (f[m - 1, n - 1, 0] + f[m - 1, n - 1, 1]) % MOD;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.UniquePaths([[0,1,0],[0,0,1],[1,0,0]]), 5),
            ResultTester.CheckResult<int>(solution.UniquePaths([[0,0],[0,0]]), 2),
            ResultTester.CheckResult<int>(solution.UniquePaths([[0,1,1],[1,1,0]]), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Twisted Mirror Path Count");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}