// Island Perimeter

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.IslandPerimeter
{
    public class Solution
    {
        public static int IslandPerimeter(int[][] grid)
        {
            int perimeter = 0;
            int rows = grid.Length;
            int cols = grid[0].Length;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        perimeter += 4;

                        perimeter -= IsNeighbor(grid, i - 1, j);
                        perimeter -= IsNeighbor(grid, i + 1, j);
                        perimeter -= IsNeighbor(grid, i, j - 1);
                        perimeter -= IsNeighbor(grid, i, j + 1);
                    }
                }
            }
            return perimeter;
        }

        private static int IsNeighbor(int[][] grid, int i, int j)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] == 0)
                return 0;
            return 1;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] matrix1 = new int[][]
            {
                new int[] { 0, 1, 0, 0 },
                new int[] { 1, 1, 1, 0 },
                new int[] { 0, 1, 0, 0 },
                new int[] { 1, 1, 0, 0 }
            };

            int[][] matrix2 = new int[][]
            {
                new int[] { 1 }
            };

            int[][] matrix3 = new int[][]
            {
                new int[] { 1, 0 },
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.IslandPerimeter(matrix1), 16),
                ResultTester.CheckResult<int>(Solution.IslandPerimeter(matrix2), 4),
                ResultTester.CheckResult<int>(Solution.IslandPerimeter(matrix3), 4),
            };
            return results;
        }
    }
}