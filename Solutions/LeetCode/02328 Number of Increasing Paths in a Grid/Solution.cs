// Number of Increasing Paths in a Grid

/*
You are given an m x n integer matrix grid, where you can move from a cell to any adjacent cell in all 4 directions.

Return the number of strictly increasing paths in the grid such that you can start from any cell and end at any cell. Since the answer may be very large, return it modulo 109 + 7.

Two paths are considered different if they do not have exactly the same sequence of visited cells.

 

Example 1:

Input: grid = [[1,1],[3,4]]
Output: 8
Explanation: The strictly increasing paths are:
- Paths with length 1: [1], [1], [3], [4].
- Paths with length 2: [1 -> 3], [1 -> 4], [3 -> 4].
- Paths with length 3: [1 -> 3 -> 4].
The total number of paths is 4 + 3 + 1 = 8.

Example 2:

Input: grid = [[1],[2]]
Output: 3
Explanation: The strictly increasing paths are:
- Paths with length 1: [1], [2].
- Paths with length 2: [1 -> 2].
The total number of paths is 2 + 1 = 3.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofIncreasingPathsinaGrid
{
    public class Solution
    {
        public static int CountPaths(int[][] grid)
        {
            const int MOD = 1_000_000_007;
            int[,] memo = new int[grid.Length, grid[0].Length];

            int answer = 0;
            for (int r = 0; r < grid.Length; r++)
            {
                for (int c = 0; c < grid[0].Length; c++)
                {
                    answer = (answer + DFS(-1, r, c)) % MOD;
                }
            }
            return answer;

            int DFS(int last, int row, int col)
            {
                if (row < 0 || col < 0 || row == grid.Length || col == grid[0].Length) return 0;
                if (grid[row][col] <= last) return 0;
                if (memo[row,col] > 0) return memo[row,col];

                int result = 1;
                int curr = grid[row][col];

                result = (result + DFS(curr, row, col - 1) + DFS(curr, row, col + 1)) % MOD;
                result = (result + DFS(curr, row - 1, col) + DFS(curr, row + 1, col)) % MOD;

                memo[row, col] = result;
                return result;
            }
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] grid1 = new int[][]
            {
                new int[] { 1, 1 },
                new int[] { 3, 4 }
            };
            int[][] grid2 = new int[][]
            {
                new int[] { 1 },
                new int[] { 2 }
            };

            int result1 = Solution.CountPaths(grid1);
            int result2 = Solution.CountPaths(grid2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 8),
                ResultTester.CheckResult<int>(result2, 3)
            };
            return results;
        }
    }
}