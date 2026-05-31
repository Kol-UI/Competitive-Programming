// Cyclically Rotating a Grid
namespace CompetitiveProgramming.LeetCode.CyclicallyRotatingaGrid;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

class IdxTransformer
{
    public int TotalRows{get; init;}
    public int TotalCols{get; init;}
    public static int GetCycleSizeOf(int rows, int cols)
    {
        return (rows + cols - 2) * 2;
    }
    public IdxTransformer(int totalRows, int totalCols)
    {
        TotalRows = totalRows;
        TotalCols = totalCols;
    }
    public (int, int) GetLocationOf(int level, int offset)
    {
        int rows = TotalRows - 2 * level;
        int cols = TotalCols - 2 * level;
        var (r, c) = (level, level);
        offset %= GetCycleSizeOf(rows, cols);
        if (offset < rows)
        {
            return (r + offset, c);
        }
        offset -= rows - 1;
        if (offset < cols)
        {
            return (r + rows - 1, c + offset);
        }
        offset -= cols - 1;
        if (offset < rows)
        {
            return (r + rows - offset - 1, c + cols - 1);
        }
        offset -= rows - 1;
        return (r, c + cols - offset - 1);
    }
}
public class Solution
{
    public int[][] RotateGrid(int[][] grid, int k)
    {
        int m = grid.Length, n = grid[0].Length;
        int[][] rotated = new int[m][];
        for (int i = 0; i < m; ++i)
        {
            rotated[i] = new int[n];
        }

        IdxTransformer transformer = new IdxTransformer(m, n);
        for (int level = 0, totalLevels = Math.Min(m, n) / 2; level < totalLevels; ++level)
        {
            for (int offset = 0;; ++offset)
            {
                var (rFrom, cFrom) = transformer.GetLocationOf(level, offset);
                var (rTo, cTo) = transformer.GetLocationOf(level, offset + k);
                if (rotated[rTo][cTo] != 0)
                {
                    break;
                }
                rotated[rTo][cTo] = grid[rFrom][cFrom];
            }
        }
        return rotated;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[][]>(solution.RotateGrid([[40,10],[30,20]], 1), [[10,20],[40,30]]),
            ResultTester.CheckResult<int[][]>(solution.RotateGrid([[1,2,3,4],[5,6,7,8],[9,10,11,12],[13,14,15,16]], 2), [[3,4,8,12],[2,11,10,16],[1,7,6,15],[5,9,13,14]]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Cyclically Rotating a Grid");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}