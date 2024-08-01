// Number of Islands

/*
Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.

An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

 

Example 1:

Input: grid = [
  ["1","1","1","1","0"],
  ["1","1","0","1","0"],
  ["1","1","0","0","0"],
  ["0","0","0","0","0"]
]
Output: 1

Example 2:

Input: grid = [
  ["1","1","0","0","0"],
  ["1","1","0","0","0"],
  ["0","0","1","0","0"],
  ["0","0","0","1","1"]
]
Output: 3
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofIslands
{
    public class Solution
    {
        public static int NumIslands(char[][] grid)
        {
            bool[][] visited = new bool[grid.Length][];

            for(int i = 0; i < grid.Length; i++)
                visited[i] = new bool[grid[i].Length];

            int islands = 0;

            for(int i = 0; i < grid.Length; i++)
            {
                for(int j = 0; j < grid[i].Length; j++)
                {
                    if(!visited[i][j] && grid[i][j] == '1')
                    {
                        islands++;
                        VisitCell(i,j);
                    }
                }
            }

            void VisitCell(int row, int col)
            {
                if(row < 0 || row >= grid.Length || col < 0 || col >= grid[row].Length
                || visited[row][col] || grid[row][col] == '0')
                {
                    return;
                }
                
                visited[row][col] = true;
                VisitCell(row - 1, col);
                VisitCell(row, col - 1);
                VisitCell(row + 1, col);
                VisitCell(row, col + 1);
            }

            return islands;
        }
    }

    public class Test
    {
        public static bool[] TestHappyNumber()
        {
            char[][] grid1 = new char[][]
            {
                new char[] { '1', '1', '1', '1', '0' },
                new char[] { '1', '1', '0', '1', '0' },
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '0', '0', '0', '0', '0' }
            };
            char[][] grid2 = new char[][]
            {
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '0', '0', '1', '0', '0' },
                new char[] { '0', '0', '0', '1', '1' }
            };

            int result1 = Solution.NumIslands(grid1);
            int result2 = Solution.NumIslands(grid2);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 1),
                ResultTester.CheckResult<int>(result2, 3)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Islands");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestHappyNumber());
        }
    }
}