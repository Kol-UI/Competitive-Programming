using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RottingOranges
{
	public class Solution
    {
        //You are given an m x n grid where each cell can have one of three values:

        //0 representing an empty cell,
        //1 representing a fresh orange, or
        //2 representing a rotten orange.
        //Every minute, any fresh orange that is 4-directionally adjacent to a rotten orange becomes rotten.

        //Return the minimum number of minutes that must elapse until no cell has a fresh orange. If this is impossible, return -1.

        /*
        Example 1:


        Input: grid = [[2,1,1],[1,1,0],[0,1,1]]
        Output: 4


        Example 2:

        Input: grid = [[2,1,1],[0,1,1],[1,0,1]]
        Output: -1
        Explanation: The orange in the bottom left corner (row 2, column 0) is never rotten, because rotting only happens 4-directionally.
        
        
        Example 3:

        Input: grid = [[0,2]]
        Output: 0
        Explanation: Since there are already no fresh oranges at minute 0, the answer is just 0.
        */

        public static int OrangesRotting(int[][] grid)
        {
            var minutes = 0;
            var hashSet = new HashSet<string>();

            while (HasFreshOranges(grid))
            {
                for (int i = 0; i < grid.Length; ++i)
                {
                    for (int j = 0; j < grid[0].Length; ++j)
                    {

                        if (grid[i][j] == 2 && !hashSet.Contains($"{i}{j}"))
                        {

                            if ((i + 1) < grid.Length && grid[i + 1][j] == 1)
                            {
                                grid[i + 1][j] = 2;
                                hashSet.Add($"{i + 1}{j}");
                            }

                            if ((i - 1) >= 0 && grid[i - 1][j] == 1)
                            {
                                grid[i - 1][j] = 2;
                                hashSet.Add($"{i - 1}{j}");
                            }

                            if ((j + 1) < grid[0].Length && grid[i][j + 1] == 1)
                            {
                                grid[i][j + 1] = 2;
                                hashSet.Add($"{i}{j + 1}");
                            }

                            if ((j - 1) >= 0 && grid[i][j - 1] == 1)
                            {
                                grid[i][j - 1] = 2;
                                hashSet.Add($"{i}{j - 1}");
                            }
                        }
                    }
                }
                if (hashSet.Count() == 0)
                    return -1;

                hashSet.Clear();
                minutes++;
            }

            return minutes;
        }

        public static bool HasFreshOranges(int[][] grid)
        {

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {

                    if (grid[i][j] == 1)
                        return true;
                }
            }

            return false;
        }
    }

    public class Test
    {
        public static bool[] TestRottingOranges()
        {
            int[][] grid1 = new int[][]
            {
                new int[] {2, 1, 1},
                new int[] {1, 1, 0},
                new int[] {0, 1, 1}
            };

            int[][] grid2 = new int[][]
            {
                new int[] {2, 1, 1},
                new int[] {0, 1, 1},
                new int[] {1, 0, 1}
            };

            int[][] grid3 = new int[][]
            {
                new int[] {0, 2}
            };

            int expected1 = 4;
            int expected2 = -1;
            int expected3 = 0;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.OrangesRotting(grid1), expected1),
                ResultTester.CheckResult<int>(Solution.OrangesRotting(grid2), expected2),
                ResultTester.CheckResult<int>(Solution.OrangesRotting(grid3), expected3)
            };

            return results;
        }
    }
}

