// Find the Minimum Area to Cover All Ones I
namespace CompetitiveProgramming.LeetCode.FindtheMinimumAreatoCoverAllOnesI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinimumArea(int[][] grid) 
    {
        var ver = new int[grid.Length];
        var hor = new int[grid[0].Length];
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    ver[i]++;
                    hor[j]++;
                }
            }
        }
        var verMult = grid.Length;
        var top = 0;
        while (ver[top] == 0)
        {
            top++;
            verMult--;
        }
        var bottom = ver.Length - 1;
        while (ver[bottom] == 0)
        {
            bottom--;
            verMult--;
        }
        var horMult = grid[0].Length;
        var left = 0;
        while (hor[left] == 0)
        {
            left++;
            horMult--;
        }
        var right = hor.Length - 1;
        while (hor[right] == 0)
        {
            right--;
            horMult--;
        }
        var rs = verMult * horMult;
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
            new int[] { 0, 1, 0 },
            new int[] { 1, 0, 1 }
        };
        int[][] grid2 = new int[][]
        {
            new int[] { 1, 0 },
            new int[] { 0, 0 }
        };
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MinimumArea(grid1), 6),
            ResultTester.CheckResult<int>(solution.MinimumArea(grid2), 1)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find the Minimum Area to Cover All Ones I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}