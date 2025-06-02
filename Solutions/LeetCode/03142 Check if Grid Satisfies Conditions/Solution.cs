// Check if Grid Satisfies Conditions
namespace CompetitiveProgramming.LeetCode.CheckifGridSatisfiesConditions;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool SatisfiesConditions(int[][] grid)
    {
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (i < grid.Length - 1 && grid[i][j] != grid[i + 1][j]) return false;
                if (j < grid[i].Length - 1 && grid[i][j] == grid[i][j + 1]) return false;
            }
        }
        return true;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();

        int[][] grid1 = new int[][]
        {
            new int[] {1, 0, 2},
            new int[] {1, 0, 2}
        };

        int[][] grid2 = new int[][]
        {
            new int[] {1, 1, 1},
            new int[] {0, 0, 0}
        };

        int[][] grid3 = new int[][]
        {
            new int[] {1},
            new int[] {2},
            new int[] {3}
        };

        bool[] results = new bool[]
        {
            ResultTester.CheckResult<bool>(solution.SatisfiesConditions(grid1), true),
            ResultTester.CheckResult<bool>(solution.SatisfiesConditions(grid2), false),
            ResultTester.CheckResult<bool>(solution.SatisfiesConditions(grid3), false),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check if Grid Satisfies Conditions");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}