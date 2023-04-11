// Number of Closed Islands

/*
Given a 2D grid consists of 0s (land) and 1s (water).  An island is a maximal 4-directionally connected group of 0s and a closed island is an island totally (all left, top, right, bottom) surrounded by 1s.

Return the number of closed islands.

 

Example 1:
Input: grid = [[1,1,1,1,1,1,1,0],[1,0,0,0,0,1,1,0],[1,0,1,0,1,1,1,0],[1,0,0,0,0,1,0,1],[1,1,1,1,1,1,1,0]]
Output: 2
Explanation: 
Islands in gray are closed because they are completely surrounded by water (group of 1s).

Example 2:
Input: grid = [[0,0,1,0,0],[0,1,0,1,0],[0,1,1,1,0]]
Output: 1
Example 3:

Input: grid = [[1,1,1,1,1,1,1],
               [1,0,0,0,0,0,1],
               [1,0,1,1,1,0,1],
               [1,0,1,0,1,0,1],
               [1,0,1,1,1,0,1],
               [1,0,0,0,0,0,1],
               [1,1,1,1,1,1,1]]
Output: 2
*/
using System;
namespace CompetitiveProgramming.LeetCode.NumberofClosedIslands
{
    public class Solution
    {
        public static int ClosedIsland(int[][] grid)
        {
            int count = 0;

            for(int i = 0; i < grid.Length; i++)
                for(int j = 0; j < grid[0].Length; j++)
                    if(grid[i][j] == 0 && DFS(grid, i, j))
                        count++;      
            
            return count;
        }

        private static bool DFS(int[][] grid, int i, int j)
        {
            if(i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length) return false;
            if(grid[i][j] == 1) return true;
            
            grid[i][j] = 1;
            bool up = DFS(grid, i - 1, j);
            bool down = DFS(grid, i + 1, j);
            bool left = DFS(grid, i, j - 1);
            bool right = DFS(grid, i, j + 1);
            return up && down && left && right;
        }
    }
}