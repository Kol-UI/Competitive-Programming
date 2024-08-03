// Max Area of Island

/*
You are given an m x n binary matrix grid. An island is a group of 1's (representing land) connected 4-directionally (horizontal or vertical.) You may assume all four edges of the grid are surrounded by water.

The area of an island is the number of cells with a value 1 in the island.

Return the maximum area of an island in grid. If there is no island, return 0.

 

Example 1:

Input: grid = [[0,0,1,0,0,0,0,1,0,0,0,0,0],[0,0,0,0,0,0,0,1,1,1,0,0,0],[0,1,1,0,1,0,0,0,0,0,0,0,0],[0,1,0,0,1,1,0,0,1,0,1,0,0],[0,1,0,0,1,1,0,0,1,1,1,0,0],[0,0,0,0,0,0,0,0,0,0,1,0,0],[0,0,0,0,0,0,0,1,1,1,0,0,0],[0,0,0,0,0,0,0,1,1,0,0,0,0]]
Output: 6
Explanation: The answer is not 11, because the island must be connected 4-directionally.

Example 2:

Input: grid = [[0,0,0,0,0,0,0,0]]
Output: 0
*/


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaxAreaofIsland
{
    public class Solution
    {
        public static int MaxAreaOfIsland(int[][] grid)
        {
            int n = grid.Length;
            int m = grid[0].Length;
            int ans = 0;
            
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if(grid[i][j] == 1)
                    {
                        int area = 0;
                        dfs(grid, i, j, n, m,ref area);
                        ans = Math.Max(ans, area);
                    }
                }
            }
            
            return ans;
        }


        private static void dfs(int[][]  grid, int i, int j, int n, int m, ref int area)
        {
            area++;
            grid[i][j] = 0;
            
            if(isValid(i+1, j, n, m, grid))
            {
                dfs(grid, i+1, j, n, m,ref area);
            }
            if(isValid(i-1, j, n, m, grid))
            {
                dfs(grid, i-1, j, n, m,ref area);
            }
            if(isValid(i, j+1, n, m, grid))
            {
                dfs(grid, i, j+1, n, m, ref area);
            }
            if(isValid(i, j-1, n, m, grid))
            {
                dfs(grid, i, j-1, n, m, ref area);
            }
        }
    
        private static bool isValid(int i, int j, int n, int m, int[][] grid)
        {
            if(i >= 0 && i < n && j >= 0 && j < m && grid[i][j] == 1)
            {
                return true;
            }
            return false;
        }
    }

    public class Test
    {
        public static bool[] TestMaxAreaofIsland()
        {
            int[][] grid695_1 = new int[][]
            {
                new int[] { 0,0,1,0,0,0,0,1,0,0,0,0,0 },
                new int[] { 0,0,0,0,0,0,0,1,1,1,0,0,0 },
                new int[] { 0,1,1,0,1,0,0,0,0,0,0,0,0 },
                new int[] { 0,1,0,0,1,1,0,0,1,0,1,0,0 },
                new int[] { 0,1,0,0,1,1,0,0,1,1,1,0,0 },
                new int[] { 0,0,0,0,0,0,0,0,0,0,1,0,0 },
                new int[] { 0,0,0,0,0,0,0,1,1,0,0,0,0 }
            };

            int[][] grid695_2 = new int[][]
            {
                new int[] { 0,0,0,0,0,0,0,0 }
            };

            int output1_695 = 6;
            int output2_695 = 0;

            int result1 = Solution.MaxAreaOfIsland(grid695_1);
            int result2 = Solution.MaxAreaOfIsland(grid695_2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, output1_695),
                ResultTester.CheckResult<int>(result2, output2_695)
            };

            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Max Aray of Island");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestMaxAreaofIsland());
        }
    }
}