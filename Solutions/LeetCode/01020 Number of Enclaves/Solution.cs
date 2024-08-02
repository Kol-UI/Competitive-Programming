// 1020. Number of Enclaves

/*
You are given an m x n binary matrix grid, where 0 represents a sea cell and 1 represents a land cell.

A move consists of walking from one land cell to another adjacent (4-directionally) land cell or walking off the boundary of the grid.

Return the number of land cells in grid for which we cannot walk off the boundary of the grid in any number of moves.

Example 1:

Input: grid = [[0,0,0,0],[1,0,1,0],[0,1,1,0],[0,0,0,0]]
Output: 3
Explanation: There are three 1s that are enclosed by 0s, and one 1 that is not enclosed because its on the boundary.

Example 2:


Input: grid = [[0,1,1,0],[0,0,1,0],[0,0,1,0],[0,0,0,0]]
Output: 0
Explanation: All 1s are either on the boundary or can reach the boundary.
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofEnclaves
{
    public class Solution
    {
        public static int NumEnclaves(int[][] grid)
        {
            int count = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if ((i == 0 || j == 0 || i == grid.Length - 1 || j == grid[i].Length - 1) && grid[i][j] == 1) //if cell is boundary and land
                    {
                        VisitLands(grid, i, j);
                    }
                }
            }
            count = grid.Sum(i => i.Count(z => z == 1));
            return count;
        }
        private static void VisitLands(int[][] grid, int i, int j)
        {
            if(i < 0 || j < 0 || i >= grid.Length || j >= grid[i].Length) return;
            if (grid[i][j] == 0)
            {
                return;
            }
            grid[i][j] = 0;
            VisitLands(grid, i+1, j);
            VisitLands(grid, i-1, j);
            VisitLands(grid, i, j+1);
            VisitLands(grid, i, j-1);
        }
    }

    public class Test
    {
        public static bool[] TestNumberofEnclaves()
        {
            // Case 1
            int[][] Grid1020_1 = new int[][]
            {
                new int[]{0,0,0,0},
                new int[]{1,0,1,0},
                new int[]{0,1,1,0},
                new int[]{0,0,0,0}
            };
            int Result1020_1 = Solution.NumEnclaves(Grid1020_1);

            // Case 2
            int[][] Grid1020_2 = new int[][]
            {
                new int[]{0,1,1,0},
                new int[]{0,0,1,0},
                new int[]{0,0,1,0},
                new int[]{0,0,0,0}
            };
            int Result1020_2 = Solution.NumEnclaves(Grid1020_2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Result1020_1, 3),
                ResultTester.CheckResult<int>(Result1020_2, 0)
            };

            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Number of Enclaves");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestNumberofEnclaves());
        }
    }
}