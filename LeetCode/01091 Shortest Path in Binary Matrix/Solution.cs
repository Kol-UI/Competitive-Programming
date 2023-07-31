// Shortest Path in Binary Matrix

/*
Given an n x n binary matrix grid, return the length of the shortest clear path in the matrix. If there is no clear path, return -1.

A clear path in a binary matrix is a path from the top-left cell (i.e., (0, 0)) to the bottom-right cell (i.e., (n - 1, n - 1)) such that:

All the visited cells of the path are 0.
All the adjacent cells of the path are 8-directionally connected (i.e., they are different and they share an edge or a corner).
The length of a clear path is the number of visited cells of this path.

 

Example 1:

Input: grid = [[0,1],[1,0]]
Output: 2

Example 2:

Input: grid = [[0,0,0],[1,1,0],[1,1,0]]
Output: 4

Example 3:

Input: grid = [[1,0,0],[1,1,0],[1,1,0]]
Output: -1
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ShortestPathinBinaryMatrix
{
    public class Solution
    {
        // BFS
        public static int ShortestPathBinaryMatrix(int[][] grid)
        {
            Queue<int[]> q = new();
            q.Enqueue(new int[2]{0,0});
            int length = 0;
            int n = grid.Length - 1;

            while(q.Count > 0)
            {
                int count = q.Count;
                length++;

                while(count-- > 0)
                {
                    var currentCell = q.Dequeue();
                    int row = currentCell[0];
                    int column = currentCell[1];

                    if(row < 0 || column < 0 || row > n || column > n || grid[row][column] == 1)
                    {
                        continue;
                    }

                    if(row == n && column == n)
                    {
                        return length;
                    }

                    grid[row][column] = 1;
                    
                    q.Enqueue(new int[2]{ row-1, column-1 });
                    q.Enqueue(new int[2]{ row-1, column });
                    q.Enqueue(new int[2]{ row-1, column+1 });
                    q.Enqueue(new int[2]{ row, column-1 });
                    q.Enqueue(new int[2]{ row, column+1 });
                    q.Enqueue(new int[2]{ row+1, column-1 });
                    q.Enqueue(new int[2]{ row+1, column });
                    q.Enqueue(new int[2]{ row+1, column+1 });
                }
            }

            return -1;
        }
    }


    public class Test
    {
        public static bool[] TestShortestPathinBinaryMatrix()
        {
            int[][] grid1 = new int[][]
            {
                new int[] {0, 1},
                new int[] {1, 0}
            };

            int[][] grid2 = new int[][]
            {
                new int[] {0, 0, 0},
                new int[] {1, 1, 0},
                new int[] {1, 1, 0}
            };

            int[][] grid3 = new int[][]
            {
                new int[] {1, 0, 0},
                new int[] {1, 1, 0},
                new int[] {1, 1, 0}
            };

            int expected1 = 2;
            int expected2 = 4;
            int expected3 = -1;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.ShortestPathBinaryMatrix(grid1), expected1),
                ResultTester.CheckResult<int>(Solution.ShortestPathBinaryMatrix(grid2), expected2),
                ResultTester.CheckResult<int>(Solution.ShortestPathBinaryMatrix(grid3), expected3)
            };

            return results;
        }
    }
}
