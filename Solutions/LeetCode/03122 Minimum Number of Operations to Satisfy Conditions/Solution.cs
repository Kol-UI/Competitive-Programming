// Minimum Number of Operations to Satisfy Conditions
namespace CompetitiveProgramming.LeetCode.MinimumNumberofOperationstoSatisfyConditions;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
    public int MinimumOperations(int[][] grid) {
        var rs = int.MaxValue;
        var dic = new Dictionary<(int col, int notCh), int>();
        for (int ch = 0; ch <= 9; ch++)
        {
            var rs0 = MinimumOperations((0, ch), dic, grid);
            rs = Math.Min(rs, rs0);
        }
        return rs;
    }
    private int MinimumOperations((int col, int notCh) key, Dictionary<(int col, int notCh), int> dic, int[][] grid)
    {
        if (dic.ContainsKey(key)) return dic[key];
        var rs = int.MaxValue;
        if (key.col < grid[0].Length - 1)
        {
            for (int ch = 0; ch <= 9; ch++)
            {
                if (ch != key.notCh)
                {
                    var rs0 = 0;
                    for (int i = 0; i < grid.Length; i++)
                    {
                        if (grid[i][key.col] != ch) rs0++;
                    }
                    rs0 += MinimumOperations((key.col + 1, ch), dic, grid);
                    rs = Math.Min(rs, rs0);
                }
            }
        }
        else
        {
            for (int ch = 0; ch <= 9; ch++)
            {
                if (ch != key.notCh)
                {
                    var rs0 = 0;
                    for (int i = 0; i < grid.Length; i++)
                    {
                        if (grid[i][key.col] != ch) rs0++;
                    }
                    rs = Math.Min(rs, rs0);
                }
            }
        }
        if (!dic.ContainsKey(key)) dic.Add(key, rs);
        return rs;
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
            ResultTester.CheckResult<int>(solution.MinimumOperations(grid1), 0),
            ResultTester.CheckResult<int>(solution.MinimumOperations(grid2), 3),
            ResultTester.CheckResult<int>(solution.MinimumOperations(grid3), 2),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Number of Operations to Satisfy Conditions");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}