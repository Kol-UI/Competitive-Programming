// Right Triangles
namespace CompetitiveProgramming.LeetCode.RightTriangles;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long NumberOfRightTriangles(int[][] grid)
    {
        (long[] verArr, long[] horArr) = CreateAuxArrays(grid);
        var result = 0L;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    result += (verArr[i] - 1) * (horArr[j] - 1);
                }
            }
        }
        return result;
    }

    private (long[] verArr, long[] horArr) CreateAuxArrays(int[][] grid)
    {
        var verArr = new long[grid.Length];
        var horArr = new long[grid[0].Length];
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                verArr[i] += grid[i][j];
                horArr[j] += grid[i][j];
            }
        }
        return (verArr, horArr);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Right Triangles");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}