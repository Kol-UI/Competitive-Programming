// Minimum Operations to Make Columns Strictly Increasing
namespace CompetitiveProgramming.LeetCode.MinimumOperationstoMakeColumnsStrictlyIncreasing;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinimumOperations(int[][] grid)
    {
        int n = grid.Length;
        int m = grid[0].Length;
        int total = 0;
        for (int x = 0; x < m; x++)
        {
            int last = grid[0][x];
            for (int y = 1; y < n; y++)
            {
                int val = grid[y][x];
                if (val <= last)
                {
                    int op = last - val + 1;
                    total += op;
                    last++;
                }
                else last = val;
            }
        }

        return total;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Operations to Make Columns Strictly Increasing");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}