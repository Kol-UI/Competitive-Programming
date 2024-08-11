// Minimum Number of Days to Disconnect Island

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumNumberofDaystoDisconnectIsland
{
    public class Solution
    {
        private static readonly int[] xDirections = { 0, 0, -1, 1 };
        private static readonly int[] yDirections = { -1, 1, 0, 0 };

        public int MinDays(int[][] grid)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;

            if (GetIslandCount(grid) != 1)
                return 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        grid[i][j] = 0;

                        if (GetIslandCount(grid) != 1)
                            return 1;

                        grid[i][j] = 1;
                    }
                }
            }

            return 2;
        }

        private int GetIslandCount(int[][] grid)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;
            var visited = InitializeVisited(rows, cols);
            int islandCount = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == 1 && !visited[i][j])
                    {
                        PerformDFS(grid, i, j, visited);
                        islandCount++;
                    }
                }
            }

            return islandCount;
        }

        private void PerformDFS(int[][] grid, int row, int col, bool[][] visited)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;
            var stack = new Stack<(int, int)>();
            stack.Push((row, col));
            visited[row][col] = true;

            while (stack.Count > 0)
            {
                var (currentRow, currentCol) = stack.Pop();

                for (int k = 0; k < 4; k++)
                {
                    int newRow = currentRow + xDirections[k];
                    int newCol = currentCol + yDirections[k];

                    if (IsValidCell(grid, newRow, newCol, visited))
                    {
                        stack.Push((newRow, newCol));
                        visited[newRow][newCol] = true;
                    }
                }
            }
        }

        private bool IsValidCell(int[][] grid, int row, int col, bool[][] visited)
        {
            return row >= 0 && col >= 0 && row < grid.Length && col < grid[0].Length && !visited[row][col] && grid[row][col] == 1;
        }

        private bool[][] InitializeVisited(int rows, int cols)
        {
            var visited = new bool[rows][];
            for (int i = 0; i < rows; i++)
            {
                visited[i] = new bool[cols];
            }
            return visited;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Number of Days to Disconnect Island");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
        }
    }
}