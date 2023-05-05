// Unique Paths

/*
There is a robot on an m x n grid. The robot is initially located at the top-left corner (i.e., grid[0][0]). The robot tries to move to the bottom-right corner (i.e., grid[m - 1][n - 1]). The robot can only move either down or right at any point in time.

Given the two integers m and n, return the number of possible unique paths that the robot can take to reach the bottom-right corner.

The test cases are generated so that the answer will be less than or equal to 2 * 109.

 

Example 1:

Input: m = 3, n = 7
Output: 28

Example 2:

Input: m = 3, n = 2
Output: 3
Explanation: From the top-left corner, there are a total of 3 ways to reach the bottom-right corner:
1. Right -> Down -> Down
2. Down -> Down -> Right
3. Down -> Right -> Down
*/

using System;
namespace CompetitiveProgramming.LeetCode.UniquePaths
{
    public class Solution
    {
        public static int UniquePaths(int m, int n)
        {
            int[,] dp = new int[m + 1, n + 1];
            dp[1, 0] = 1;

            for(int r = 1; r <= m; r++)
            {
                for(int c = 1; c <= n; c++)
                {
                    dp[r, c] = dp[r - 1, c] + dp[r, c - 1];
                }
            }
            return dp[m,n];
        }
    }
}