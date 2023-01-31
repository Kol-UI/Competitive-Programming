using System;

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

        public int OrangesRotting(int[][] grid)
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

        public bool HasFreshOranges(int[][] grid)
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
}

