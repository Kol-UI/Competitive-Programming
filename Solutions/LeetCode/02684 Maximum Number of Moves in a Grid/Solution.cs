// Maximum Number of Moves in a Grid

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumNumberofMovesinaGrid
{
    public class Solution
    {
        public int MaxMoves(int[][] grid)
        {
            var next = new int[grid.Length];

            for (int col = grid[0].Length - 2; col >= 0; col--)
            {
                var cur = new int[grid.Length];
                for (int row = 0; row < grid.Length; row++)
                {
                    if (row > 0 && grid[row - 1][col + 1] > grid[row][col]) cur[row] = Math.Max(cur[row], 1 + next[row - 1]);
                    if (grid[row][col + 1] > grid[row][col]) cur[row] = Math.Max(cur[row], 1 + next[row]);
                    if (row + 1 < grid.Length && grid[row + 1][col + 1] > grid[row][col]) cur[row] = Math.Max(cur[row], 1 + next[row + 1]);
                }

                next = cur;
            }

            var result = 0;
            foreach (var num in next) result = Math.Max(result, num);

            return result;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Number of Moves in a Grid");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}