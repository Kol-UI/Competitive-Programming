// Cherry Pickup II


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CherryPickupII
{
    public class Solution
    {
        public static int CherryPickup(int[][] grid)
        {
            return DFS(0, 0, grid[0].Length - 1, grid, new Dictionary<string, int>());
        }

        public static int DFS(int row, int col1, int col2, int[][] grid, Dictionary<string, int> cache)
        {
            if(col1 == col2 || col1 < 0 || col1 >= grid[0].Length || col2 < 0 || col2 >= grid[0].Length)
                return 0;

            if(row == grid.Length - 1)
                return grid[row][col1] + grid[row][col2];
            
            if(cache.ContainsKey(row + "-" + col1 + "-" +col2))
                return cache[row + "-" + col1 + "-" + col2];

            int result = 0;

            for(int i = col1 - 1; i <= col1 + 1; i++)
            {
                if(i < 0 || i >= grid[0].Length)
                    continue;
                
                for(int j = col2 - 1; j <= col2 + 1; j++)
                {
                    if(j < 0 || j >= grid[0].Length)
                        continue;
                    
                    result = Math.Max(result, DFS(row + 1, i, j, grid, cache));
                }
            }

            cache.Add(row + "-" + col1 + "-" + col2, result + grid[row][col1] + grid[row][col2]);
            return result + grid[row][col1] + grid[row][col2];
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] matrix1 = new int[][]
            {
                new int[] {3,1,1},
                new int[] {2,5,1},
                new int[] {1,5,5},
                new int[] {2,1,1}
            };

            int[][] matrix2 = new int[][]
            {
                new int[] {1,0,0,0,0,0,1},
                new int[] {2,0,0,0,0,3,0},
                new int[] {2,0,9,0,0,0,0},
                new int[] {0,3,0,5,4,0,0},
                new int[] {1,0,2,3,0,0,6}
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CherryPickup(matrix1), 24),
                ResultTester.CheckResult<int>(Solution.CherryPickup(matrix2), 28),
            };
            return results;
        }
    }
}