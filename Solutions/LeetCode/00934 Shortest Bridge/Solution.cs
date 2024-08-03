// Shortest Bridge

/*
You are given an n x n binary matrix grid where 1 represents land and 0 represents water.
An island is a 4-directionally connected group of 1's not connected to any other 1's. There are exactly two islands in grid.
You may change 0's to 1's to connect the two islands to form one island.
Return the smallest number of 0's you must flip to connect the two islands.

 

Example 1:

Input: grid = [[0,1],[1,0]]
Output: 1

Example 2:

Input: grid = [[0,1,0],[0,0,0],[0,0,1]]
Output: 2

Example 3:

Input: grid = [[1,1,1,1,1],[1,0,0,0,1],[1,0,1,0,1],[1,0,0,0,1],[1,1,1,1,1]]
Output: 1
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ShortestBridge
{
    public class Solution
    {
        public static int ShortestBridge(int[][] grid)
        {
            List<List<int>> is1 = new List<List<int>>();
            List<List<int>> is2 = new List<List<int>>();

            bool flag = true;
            int n = grid.Length;

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(grid[i][j] == 1)
                    {
                        if(flag)
                        {
                            traverse(grid, i, j, is1);
                            flag = false;
                        }
                        else
                        {
                            traverse(grid, i, j, is2);
                            break;
                        }
                    }
                }
            }

            int min = 10000000;
            foreach(var list in is1)
            {
                foreach(var list2 in is2)
                {
                    int x = Math.Abs(list[0] - list2[0]);
                    int y = Math.Abs(list[1] - list2[1]);
                    min = Math.Min(min, x + y - 1);
                }
            }
            return min;
        }
        
        public static void traverse(int[][] grid,int i,int j,List<List<int>> island)
        {
            grid[i][j] = 2;

            List<int> t = new List<int>();

            t.Add(i);
            t.Add(j);
            island.Add(t);

            if(i + 1 < grid.Length && grid[i+1][j] == 1) traverse(grid, i + 1, j, island);

            if(i - 1 >= 0 && grid[i-1][j] == 1) traverse(grid, i - 1, j, island);
            
            if(j > 0 && grid[i][j-1] == 1) traverse(grid, i, j - 1, island);

            if(j < grid.Length-1 && grid[i][j+1] == 1) traverse(grid, i, j + 1, island);
        }
    }

    public class Test
    {
        public static bool[] TestShortestBridge()
        {
            int[][] case1 = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1, 0 }
            };

            int[][] case2 = new int[][]
            {
                new int[] { 0,1,0 },
                new int[] { 0,0,0 },
                new int[] { 0,0,1 }
            };

            int[][] case3 = new int[][]
            {
                new int[] { 1,1,1,1,1 },
                new int[] { 1,0,0,0,1 },
                new int[] { 1,0,1,0,1 },
                new int[] { 1,0,0,0,1 },
                new int[] { 1,1,1,1,1 }
            };

            int result1 = LeetCode.ShortestBridge.Solution.ShortestBridge(case1);
            int result2 = LeetCode.ShortestBridge.Solution.ShortestBridge(case2);
            int result3 = LeetCode.ShortestBridge.Solution.ShortestBridge(case3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 1),
                ResultTester.CheckResult<int>(result2, 2),
                ResultTester.CheckResult<int>(result3, 1)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shortest Bridge");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestShortestBridge());
        }
    }
}