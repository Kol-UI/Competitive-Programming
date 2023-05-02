// Count Negative Numbers in a Sorted Matrix

/*
Given a m x n matrix grid which is sorted in non-increasing order both row-wise and column-wise, return the number of negative numbers in grid.

 

Example 1:

Input: grid = [[4,3,2,-1],[3,2,1,-1],[1,1,-1,-2],[-1,-1,-2,-3]]
Output: 8
Explanation: There are 8 negatives number in the matrix.

Example 2:

Input: grid = [[3,2],[1,0]]
Output: 0
*/


using System;
namespace CompetitiveProgramming.LeetCode.CountNegativeNumbersinaSortedMatrix
{
    public class Solution
    {
        public static int CountNegatives(int[][] grid)
        {
            var count = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                count += grid[i].Count(n => n < 0);
            }
            return count;
        }
    }
}