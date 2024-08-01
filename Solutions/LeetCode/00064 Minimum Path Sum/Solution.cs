using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumPathSum
{
    /*
        Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right, which minimizes the sum of all numbers along its path.
        Note: You can only move either down or right at any point in time.

        Example 1:
        Input: grid = [[1,3,1],[1,5,1],[4,2,1]]
        Output: 7
        Explanation: Because the path 1 → 3 → 1 → 1 → 1 minimizes the sum.
        
        Example 2:
        Input: grid = [[1,2,3],[4,5,6]]
        Output: 12
    */
    public class Solution
    {
        public static int MinPathSum(int[][] grid)
        {
            for(int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        continue;
                    }

                    if (i == 0)
                    {
                        grid[i][j] += grid[i][j - 1];
                        continue;
                    }

                    if (j == 0)
                    {
                        grid[i][j] += grid[i - 1][j];
                        continue;
                    }

                    grid[i][j] += Math.Min(grid[i][j - 1], grid[i - 1][j]);
                }
            }

            return grid[grid.Length - 1][grid[0].Length - 1];
        }
    }

    public class Test
    {
        public static bool[] TestMinimumPathSum()
        {
            // Case 1
            int[][] grid64Case1 = new int[][]
            {
                new int[] { 1, 3, 1 },
                new int[] { 1, 5, 1 },
                new int[] { 4, 2, 1 }
            };
            int result64Case1 = Solution.MinPathSum(grid64Case1);

            // Case 2
            int[][] grid64Case2 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 }
            };
            int result64Case2 = Solution.MinPathSum(grid64Case2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result64Case1, 7),
                ResultTester.CheckResult<int>(result64Case2, 12)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Path Sum");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestMinimumPathSum());
        }
    }
}