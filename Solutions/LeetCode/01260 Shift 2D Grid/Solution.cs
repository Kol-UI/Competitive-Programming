// Shift 2D Grid

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ShiftTwoDGrid
{
    public class Solution
    {
        public IList<IList<int>> ShiftGrid(int[][] grid, int k) => grid
            .SelectMany(row => row)
            .Concat(grid.SelectMany(row => row))
            .Skip(grid.Length * grid[0].Length - k % (grid.Length * grid[0].Length))
            .Take(grid.Length * grid[0].Length)
            .Chunk(grid[0].Length)
            .ToList<IList<int>>();
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shift 2D Grid");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}