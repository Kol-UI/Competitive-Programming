// Shortest Path to Get All Keys

/*
You are given an m x n grid grid where:

'.' is an empty cell.
'#' is a wall.
'@' is the starting point.
Lowercase letters represent keys.
Uppercase letters represent locks.
You start at the starting point and one move consists of walking one space in one of the four cardinal directions. You cannot walk outside the grid, or walk into a wall.

If you walk over a key, you can pick it up and you cannot walk over a lock unless you have its corresponding key.

For some 1 <= k <= 6, there is exactly one lowercase and one uppercase letter of the first k letters of the English alphabet in the grid. This means that there is exactly one key for each lock, and one lock for each key; and also that the letters used to represent the keys and locks were chosen in the same order as the English alphabet.

Return the lowest number of moves to acquire all keys. If it is impossible, return -1.

 

Example 1:


Input: grid = ["@.a..","###.#","b.A.B"]
Output: 8
Explanation: Note that the goal is to obtain all the keys not to open all the locks.



Example 2:


Input: grid = ["@..aA","..B#.","....b"]
Output: 6



Example 3:


Input: grid = ["@Aa"]
Output: -1
*/

using System;
namespace CompetitiveProgramming.LeetCode.ShortestPathtoGetAllKeys
{
    public class Solution
    {
        static int[][] directions = new int[][]
        {
            new int[] { -1, 0 },
            new int[] { 1, 0 },
            new int[] { 0, -1 },
            new int[] { 0, 1 }
        };
        public static int ShortestPathAllKeys(string[] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int totalKeys = 0;
            int startX = -1;
            int startY = -1;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == '@')
                    {
                        startX = i;
                        startY = j;
                    }
                    else if (char.IsLower(grid[i][j]))
                    {
                        totalKeys++;
                    }
                }
            }

            var queue = new Queue<(int, int, int)>();
            var visited = new HashSet<(int, int, int)>();

            queue.Enqueue((startX, startY, 0));
            visited.Add((startX, startY, 0));

            int steps = 0;

            while (queue.Count > 0)
            {
                int size = queue.Count;

                for (int i = 0; i < size; i++)
                {
                    var (x, y, state) = queue.Dequeue();

                    if (state == (1 << totalKeys) - 1)
                    {
                        return steps;
                    }

                    for (int j = 0; j < 4; j++)
                    {
                        int newX = x + directions[j][0];
                        int newY = y + directions[j][1];
                        int newState = state;

                        if (newX >= 0 && newX < m && newY >= 0 && newY < n && grid[newX][newY] != '#')
                        {
                            char c = grid[newX][newY];

                            if (char.IsLower(c))
                            {
                                newState |= (1 << (c - 'a'));
                            }

                            if (char.IsUpper(c) && ((state >> (c - 'A')) & 1) == 0)
                            {
                                continue;
                            }

                            if (!visited.Contains((newX, newY, newState)))
                            {
                                visited.Add((newX, newY, newState));
                                queue.Enqueue((newX, newY, newState));
                            }
                        }
                    }
                }

                steps++;
            }

            return -1;
        }
    }
}