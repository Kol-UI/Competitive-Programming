// Sort Matrix by Diagonals
namespace CompetitiveProgramming.LeetCode.SortMatrixbyDiagonals;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[][] SortMatrix(int[][] grid)
    {
        for (int i = 0; i < grid.Length - 1; i++)
        {
            var items = GetDiagItems(i, grid);
            items = items.OrderByDescending(p => p).ToList();
            ReplaceDiag(i, items, grid);
        }
        for (int i = 1; i < grid[0].Length - 1; i++)
        {
            var items = GetDiagItems2(i, grid);
            items.Sort();
            ReplaceDiag2(i, items, grid);
        }
        return grid;
    }

    private void ReplaceDiag2(int index, List<int> items, int[][] grid)
    {
        for (int i = index; i < grid[0].Length; i++)
        {
            grid[i - index][i] = items[i - index];
        }
    }

    private List<int> GetDiagItems2(int index, int[][] grid)
    {
        var rs = new List<int>();
        for (int i = index; i < grid[0].Length; i++)
        {
            rs.Add(grid[i - index][i]);
        }
        return rs;
    }

    private void ReplaceDiag(int index, List<int> items, int[][] grid)
    {
        for (int i = grid.Length - 1; i >= index ; i--)
        {
            grid[i][i - index] = items[i - index];
        }
    }

    private List<int> GetDiagItems(int index, int[][] grid)
    {
        var rs = new List<int>();
        for (int i = index; i < grid.Length; i++)
        {
            rs.Add(grid[i][i - index]);
        }
        return rs;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sort Matrix by Diagonals");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}