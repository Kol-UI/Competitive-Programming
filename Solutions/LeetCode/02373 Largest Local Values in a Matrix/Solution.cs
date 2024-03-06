// Largest Local Values in a Matrix



using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LargestLocalValuesinaMatrix
{
    public class Solution
    {
        public static int[][] LargestLocal(int[][] grid)
        {
            var returnGrid = new int[grid.Length - 2][];
            for (int i = 0; i < grid.Length - 2; i++)
            {
                returnGrid[i] = new int[grid.Length - 2];
            }

            for (int i = 1; i < grid.Length - 1; i++){
                for (int j = 1; j < grid.Length - 1; j++){
                    int localMax = 0;
                    for (int temp_i = -1; temp_i <= 1; temp_i++){
                        for (int temp_j = -1; temp_j <= 1; temp_j++){
                            localMax = Math.Max(localMax, grid[i - temp_i][j - temp_j]);
                        }
                    }
                    returnGrid[i - 1][j - 1] = localMax;
                }
            }
            
            return returnGrid;
        }
    }
}