// Construct Product Matrix
namespace CompetitiveProgramming.LeetCode.ConstructProductMatrix;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[][] ConstructProductMatrix(int[][] grid)
    {
        var result = InitResult(grid);
        var lefts = CreateLeft(grid);
        var rights = CreateRight(grid);
        for (int i = 0; i < result.Length; i++)
        {
            for (int j = 0; j < result[i].Length; j++)
            {
                var item = lefts[i * grid[i].Length + j] * rights[i * grid[i].Length + j];
                item %= 12345;
                result[i][j] = (int)item;
            }
        }
        return result;
    }
    private long[] CreateLeft(int[][] grid)
    {
        var result = new long[grid.Length * grid[0].Length];
        result[0] = 1;
        for (int i = 1; i < result.Length; i++)
        {
            var value = result[i - 1] * grid[(i - 1) / grid[0].Length][(i - 1) % grid[0].Length];
            value %= 12345;
            result[i] = value;
        }
        return result;
    }
    private long[] CreateRight(int[][] grid)
    {
        var result = new long[grid.Length * grid[0].Length];
        result[result.Length - 1] = 1;
        for (int i = result.Length - 2; i >= 0; i--)
        {
            var value = result[i + 1] * grid[(i + 1) / grid[0].Length][(i + 1) % grid[0].Length];
            value %= 12345;
            result[i] = value;
        }
        return result;
    }
    private int[][] InitResult(int[][] grid)
    {
        var result = new int[grid.Length][];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = new int[grid[i].Length];
        }
        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Construct Product Matrix");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}