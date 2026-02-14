// Largest Magic Square
namespace CompetitiveProgramming.LeetCode.LargestMagicSquare;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int LargestMagicSquare(int[][] grid)
    {
        var max = 0;
        var m = grid.Length;
        var n = grid[0].Length;

        for (var i = 0; i < m - max; i++)
        for (var j = 0; j < n - max; j++)
        for (var k = Math.Min(m - i, n - j); k > max; k--)
        {
            if (IsMagicSquare(grid, i, j, k))
                max = k;
        }

        return max;
    }

    private bool IsMagicSquare(int[][] grid, int i, int j, int k)
    {
        var diag1 = 0;
        var diag2 = 0;

        for (var x = 0; x < k; x++)
        {
            var y = k - x - 1;
            diag1 += grid[i + x][j + x];
            diag2 += grid[i + y][j + x];
        }

        if (diag1 != diag2)
            return false;

        Span<int> rows = stackalloc int[k];
        Span<int> cols = stackalloc int[k];

        for (var row = 0; row < k; row++)
        {
            for (var col = 0; col < k; col++)
            {
                rows[row] += grid[i + row][j + col];
                cols[col] += grid[i + row][j + col];
            }

            if (rows[row] != diag1)
                return false;
        }

        return cols.IndexOfAnyExcept(diag1) == -1;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Largest Magic Square");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}