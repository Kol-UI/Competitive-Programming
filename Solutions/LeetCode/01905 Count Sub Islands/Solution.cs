// Count Sub Islands

/*
You are given two m x n binary matrices grid1 and grid2 containing only 0's (representing water) and 1's (representing land). An island is a group of 1's connected 4-directionally (horizontal or vertical). Any cells outside of the grid are considered water cells.

An island in grid2 is considered a sub-island if there is an island in grid1 that contains all the cells that make up this island in grid2.

Return the number of islands in grid2 that are considered sub-islands.

 

Example 1:


Input: grid1 = [[1,1,1,0,0],[0,1,1,1,1],[0,0,0,0,0],[1,0,0,0,0],[1,1,0,1,1]], grid2 = [[1,1,1,0,0],[0,0,1,1,1],[0,1,0,0,0],[1,0,1,1,0],[0,1,0,1,0]]
Output: 3
Explanation: In the picture above, the grid on the left is grid1 and the grid on the right is grid2.
The 1s colored red in grid2 are those considered to be part of a sub-island. There are three sub-islands.


Example 2:


Input: grid1 = [[1,0,1,0,1],[1,1,1,1,1],[0,0,0,0,0],[1,1,1,1,1],[1,0,1,0,1]], grid2 = [[0,0,0,0,0],[1,1,1,1,1],[0,1,0,1,0],[0,1,0,1,0],[1,0,0,0,1]]
Output: 2 
Explanation: In the picture above, the grid on the left is grid1 and the grid on the right is grid2.
The 1s colored red in grid2 are those considered to be part of a sub-island. There are two sub-islands.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CountSubIslands
{
    public class Solution 
    {
        public static int CountSubIslands(int[][] grid1, int[][] grid2) 
        {
            int count = 0;
            for (int i = 0; i < grid2.Length; i++)
            {
                for (int j = 0; j < grid2[i].Length; j++)
                {
                    if (grid2[i][j] != 0)
                    {
                        count += FloodFill(grid2, i, j);
                    }
                }
            }  

            return count;

            int FloodFill(int[][] mtx, int i, int j)
            {
                if(i < 0 || i >= mtx.Length || j < 0 || j >= mtx[i].Length || mtx[i][j] == 0)
                    return 1;

                mtx[i][j] = 0;
                
                return grid1[i][j] * FloodFill(mtx, i + 1, j) * 
                    FloodFill(mtx, i - 1, j) *  FloodFill(mtx, i, j + 1) * FloodFill(mtx, i, j - 1);
            }
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] grid1_Case1 = new int[][]
            {
                new int[] { 1, 1, 1, 0, 0 },
                new int[] { 0, 1, 1, 1, 1 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 0, 1, 1 }
            };

            int[][] grid2_Case1 = new int[][]
            {
                new int[] { 1, 1, 1, 0, 0 },
                new int[] { 0, 0, 1, 1, 1 },
                new int[] { 0, 1, 0, 0, 0 },
                new int[] { 1, 0, 1, 1, 0 },
                new int[] { 0, 1, 0, 1, 0 }
            };

            int[][] grid1_Case2 = new int[][]
            {
                new int[] { 1, 0, 1, 0, 1 },
                new int[] { 1, 1, 1, 1, 1 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 1 },
                new int[] { 1, 0, 1, 0, 1 }
            };

            int[][] grid2_Case2 = new int[][]
            {
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 1 },
                new int[] { 0, 1, 0, 1, 0 },
                new int[] { 0, 1, 0, 1, 0 },
                new int[] { 1, 0, 0, 0, 1 }
            };

            int result1 = Solution.CountSubIslands(grid1_Case1, grid2_Case1);
            int result2 = Solution.CountSubIslands(grid1_Case2, grid2_Case2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 3),
                ResultTester.CheckResult<int>(result2, 2)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Count Sub Islands");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}