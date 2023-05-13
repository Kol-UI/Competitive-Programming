// Nearest Exit from Entrance in Maze

/*
You are given an m x n matrix maze (0-indexed) with empty cells (represented as '.') and walls (represented as '+'). You are also given the entrance of the maze, where entrance = [entrancerow, entrancecol] denotes the row and column of the cell you are initially standing at.

In one step, you can move one cell up, down, left, or right. You cannot step into a cell with a wall, and you cannot step outside the maze. Your goal is to find the nearest exit from the entrance. An exit is defined as an empty cell that is at the border of the maze. The entrance does not count as an exit.

Return the number of steps in the shortest path from the entrance to the nearest exit, or -1 if no such path exists.

 

Example 1:

Input: maze = [["+","+",".","+"],[".",".",".","+"],["+","+","+","."]], entrance = [1,2]
Output: 1
Explanation: There are 3 exits in this maze at [1,0], [0,2], and [2,3].
Initially, you are at the entrance cell [1,2].
- You can reach [1,0] by moving 2 steps left.
- You can reach [0,2] by moving 1 step up.
It is impossible to reach [2,3] from the entrance.
Thus, the nearest exit is [0,2], which is 1 step away.

Example 2:

Input: maze = [["+","+","+"],[".",".","."],["+","+","+"]], entrance = [1,0]
Output: 2
Explanation: There is 1 exit in this maze at [1,2].
[1,0] does not count as an exit since it is the entrance cell.
Initially, you are at the entrance cell [1,0].
- You can reach [1,2] by moving 2 steps right.
Thus, the nearest exit is [1,2], which is 2 steps away.

Example 3:


Input: maze = [[".","+"]], entrance = [0,0]
Output: -1
Explanation: There are no exits in this maze.
*/

using System;
namespace CompetitiveProgramming.LeetCode.NearestExitfromEntranceinMaze
{
    public class Solution
    {
        public static int NearestExit(char[][] maze, int[] entrance)
        {
            var m = maze.Length;
            var n = maze[0].Length;

            var eRow = entrance[0];
            var eCol = entrance[1];

            var queue = new Queue<(int, int, int)>();
            var visited = new bool[m, n];

            var res = Int32.MaxValue;

            queue.Enqueue((eRow, eCol, 0));

            while (queue.Count > 0)
            {
                var (i, j, distance) = queue.Dequeue();

                if (visited[i, j])
                {
                    continue;
                }

                visited[i, j] = true;

                if (!(i == eRow && j == eCol) && maze[i][j] == '.' && (i == 0 || j == 0 || i == m - 1 || j == n - 1))
                {
                    res = Math.Min(res, distance);
                    continue;
                }


                if (i > 0 && maze[i - 1][j] == '.')
                {
                    queue.Enqueue((i - 1, j, distance + 1));
                }

                if (i < m - 1 && maze[i + 1][j] == '.')
                {
                    queue.Enqueue((i + 1, j, distance + 1));
                }

                if (j > 0 && maze[i][j - 1] == '.')
                {
                    queue.Enqueue((i, j - 1, distance + 1));
                }

                if (j < n - 1 && maze[i][j + 1] == '.')
                {
                    queue.Enqueue((i, j + 1, distance + 1));
                }

            }

            return res == Int32.MaxValue ? -1: res;
        }
    }
}