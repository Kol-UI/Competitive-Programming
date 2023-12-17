// Find Missing and Repeated Values



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.FindMissingandRepeatedValues
{
    public class Solution
    {
        public static int[] FindMissingAndRepeatedValues(int[][] grid)
        {
            int gridSize = grid.Length;
            int firstValue = 0;
            int secondValue = 0;
            
            Dictionary<int, int> valueCounts = new Dictionary<int, int>();
            
            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    int value = grid[row][col];
                    if (valueCounts.ContainsKey(value))
                    {
                        valueCounts[value]++;
                    }
                    else
                    {
                        valueCounts[value] = 1;
                    }
                }
            }
            
            for (int i = 1; i <= gridSize * gridSize; i++)
            {
                if (!valueCounts.ContainsKey(i))
                {
                    secondValue = i;
                }
                if (valueCounts.ContainsKey(i) && valueCounts[i] == 2)
                {
                    firstValue = i;
                }
            }
            
            return new int[2] { firstValue, secondValue };
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] grid1 = new int[][]
            {
                new int[] {1, 3},
                new int[] {2, 2}
            };

            int[][] grid2 = new int[][]
            {
                new int[] {9, 1, 7},
                new int[] {8, 9, 2},
                new int[] {3, 4, 6}
            };

            int[] expected1 = {2,4};
            int[] expected2 = {9,5};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.FindMissingAndRepeatedValues(grid1), expected1),
                ResultTester.CheckResult<int[]>(Solution.FindMissingAndRepeatedValues(grid2), expected2),
            };
            return results;
        }
    }
}