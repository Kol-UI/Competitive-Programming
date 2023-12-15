// Unique Paths II

/*
You are given an m x n integer array grid. There is a robot initially located at the top-left corner (i.e., grid[0][0]). The robot tries to move to the bottom-right corner (i.e., grid[m - 1][n - 1]). The robot can only move either down or right at any point in time.

An obstacle and space are marked as 1 or 0 respectively in grid. A path that the robot takes cannot include any square that is an obstacle.

Return the number of possible unique paths that the robot can take to reach the bottom-right corner.

The testcases are generated so that the answer will be less than or equal to 2 * 109.

 

Example 1:

Input: obstacleGrid = [[0,0,0],[0,1,0],[0,0,0]]
Output: 2
Explanation: There is one obstacle in the middle of the 3x3 grid above.
There are two ways to reach the bottom-right corner:
1. Right -> Right -> Down -> Down
2. Down -> Down -> Right -> Right


Example 2:

Input: obstacleGrid = [[0,1],[0,0]]
Output: 1
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.UniquePathsII
{
    public class Solution
    {
        public static int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int m = obstacleGrid.Length;
            int n = obstacleGrid[0].Length;
            int[][] dp = new int[m][];
            dp[0] = new int[n];

            dp[0][0] = 1;
            if (obstacleGrid[m-1][n-1] == 1)
            {
                return 0;
            }

            for (int i = 1; i < m; i++)
            {
                dp[i] = new int[n];

                dp[i][0] = 1;
                if (obstacleGrid[i-1][0]==1|| dp[i - 1][0] == 0)
                {
                    dp[i][0] = 0;
                }
            }

            for (int i = 1; i < n; i++)
            {
                dp[0][i] = 1;
                if (obstacleGrid[0][i - 1] == 1 || dp[0][i-1] == 0)
                {
                    dp[0][i] = 0;
                }
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (obstacleGrid[i - 1][j] == 1)
                    {
                        dp[i - 1][j] = 0;
                    }
                    if (obstacleGrid[i][j - 1] == 1)
                    {
                        dp[i][j - 1] = 0;
                    }
                    dp[i][j] = dp[i - 1][j] + dp[i][j - 1];
                }

            }

            return dp[m - 1][n - 1];
        }
    }

    public class Test
    {
        public static bool[] TestUniquePathsII()
        {
            int[][] obstacleGrid1 = new int[][]
            {
                new int[] { 0,0,0 },
                new int[] { 0,1,0 },
                new int[] { 0,0,0 }
            };

            int[][] obstacleGrid2 = new int[][]
            {
                new int[] { 0,1 },
                new int[] { 0,0 }
            };

            int output1_63 = 2;
            int output2_63 = 1;

            int result1_63 = Solution.UniquePathsWithObstacles(obstacleGrid1);
            int result2_63 = Solution.UniquePathsWithObstacles(obstacleGrid2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_63, output1_63),
                ResultTester.CheckResult<int>(result2_63, output2_63)
            };
            return results;
        }
    }
}
