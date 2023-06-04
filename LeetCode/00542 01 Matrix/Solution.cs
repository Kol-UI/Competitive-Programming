// 01 Matrix

/*
Given an m x n binary matrix mat, return the distance of the nearest 0 for each cell.

The distance between two adjacent cells is 1.

 

Example 1:


Input: mat = [[0,0,0],[0,1,0],[0,0,0]]
Output: [[0,0,0],[0,1,0],[0,0,0]]


Example 2:


Input: mat = [[0,0,0],[0,1,0],[1,1,1]]
Output: [[0,0,0],[0,1,0],[1,2,1]]
*/

using System;
namespace CompetitiveProgramming.LeetCode.ZeroOneMatrix
{
    public class Solution
    {
        public static int[][] UpdateMatrix(int[][] mat)
        {
            var rows = mat.Length;
            var cols = mat[0].Length;

            int[,] directions = { { 1, 0 }, { -1, 0 }, { 0, 1 }, { 0, -1 } };
            var result = Enumerable.Range(0, rows).Select(_ => Enumerable.Repeat(int.MaxValue, cols).ToArray()).ToArray();
            var queue = new Queue<(int x, int y)>();

            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    if (mat[y][x] == 0)
                    {
                        result[y][x] = 0;
                        queue.Enqueue((x, y));
                    }
                }
            }

            while (queue.Any())
            {
                var current = queue.Dequeue();

                for (int i = 0; i < directions.GetLength(0); i++)
                {
                    var xd = current.x + directions[i, 0];
                    var yd = current.y + directions[i, 1];

                    if (xd >= 0 && xd < cols && yd >= 0 && yd < rows
                        && result[yd][xd] > result[current.y][current.x] + 1)
                    {
                        result[yd][xd] = result[current.y][current.x] + 1;

                        queue.Enqueue((xd, yd));
                    }
                }
            }

            return result;
        }
    }
}
