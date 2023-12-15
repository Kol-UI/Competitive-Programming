// Spiral Matrix II

/*
Given a positive integer n, generate an n x n matrix filled with elements from 1 to n2 in spiral order.

 

Example 1:

Input: n = 3
Output: [[1,2,3],[8,9,4],[7,6,5]]

Example 2:

Input: n = 1
Output: [[1]]
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SpiralMatrixII
{
    public class Solution
    {
        public static int[][] GenerateMatrix(int n)
        {
            int num = 1;
            int[][] result = new int[n][];

            for (int i = 0; i < n; i++) result[i] = new int[n];

            for (int i = 0, j = n - 1; i <= j; i++, j--)
            {
                for (int k = i; k <= j; k++) result[i][k] = num++;
                for (int k = i + 1; k <= j; k++) result[k][j] = num++;
                for (int k = j - 1; k >= i; k--) result[j][k] = num++;
                for (int k = j - 1; k > i; k--) result[k][i] = num++;
            }
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestSpiralMatrixII()
        {
            int[][] expected1 = new int[][]
            {
                new int[] {1, 2, 3},
                new int[] {8, 9, 4},
                new int[] {7, 6, 5}
            };
            int[][] expected2 = new int[][]
            {
                new int[] {1},
            };
            int[][] result1 = Solution.GenerateMatrix(3);
            int[][] result2 = Solution.GenerateMatrix(1);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[][]>(result1, expected1),
                ResultTester.CheckResult<int[][]>(result2, expected2)
            };
            return results;
        }
    }
}