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
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

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

    public class Test
    {
        public static bool[] TestCountNegativeNumbersinaSortedMatrix()
        {
            // Case 1
            int[][] grid1_1351 = new int[][]
            {
                new int[] { 4,3,2,-1 },
                new int[] { 3,2,1,-1 },
                new int[] { 1,1,-1,-2 },
                new int[] { -1,-1,-2,-3 }
            };
            int result1_1351 = Solution.CountNegatives(grid1_1351);

            // Case 2
            int[][] grid2_1351 = new int[][]
            {
                new int[] { 3,2 },
                new int[] { 1,0 }
            };
            int result2_1351 = Solution.CountNegatives(grid2_1351);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_1351, 8),
                ResultTester.CheckResult<int>(result2_1351, 0)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Negative Numbers in a Sorted Matrix");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCountNegativeNumbersinaSortedMatrix());
        }
    }
}