// Delete Greatest Value in Each Row


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DeleteGreatestValueinEachRow
{
    public class Solution
    {
        public static int DeleteGreatestValue(int[][] grid)
        {
            int currentColumnLength = grid[0].Length;
            int[] currentMaxNumber = new int[currentColumnLength];
            
            for (int i = 0; i < grid.Length; i++)
            {
                Array.Sort(grid[i]);
                for (int j = 0; j < currentColumnLength; j++)
                {
                    if (currentMaxNumber[j] < grid[i][j])
                    {
                        currentMaxNumber[j] = grid[i][j];
                    }
                }
            }

            return currentMaxNumber.Sum();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] matrix1 = new int[][]
            {
                new int[] {1, 2, 4},
                new int[] {3, 3, 1}
            };

            int[][] matrix2 = new int[][]
            {
                new int[] {10},
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.DeleteGreatestValue(matrix1), 8),
                ResultTester.CheckResult<int>(Solution.DeleteGreatestValue(matrix2), 10),
            };
            return results;
        }
    }
}