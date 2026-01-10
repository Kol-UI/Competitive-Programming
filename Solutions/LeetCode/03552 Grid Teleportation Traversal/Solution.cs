// Grid Teleportation Traversal
namespace CompetitiveProgramming.LeetCode.GridTeleportationTraversal;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinMoves(string[] matrix)
    {
        int m = matrix.Length, n = matrix[0].Length;
        if (matrix[0][0] == '#' || matrix[m - 1][n - 1] == '#')
            return -1;

        List<int[]>[] chars = new List<int[]>[26];
        bool[,] visited = new bool[m, n];
        PriorityQueue<(int, int), int> pq = new();
        pq.Enqueue((0, 0), 0);
        int[] dir = [0, 1, 0, -1, 0];
        int res = int.MaxValue;

        for (int i = 0; i < 26; i++)
        {
            chars[i] = new List<int[]>();
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                char c = matrix[i][j];
                if (c >= 'A' && c <= 'Z')
                    chars[c - 'A'].Add([i, j]);
            }
        }

        int visitedChars = 0;
        while (pq.TryDequeue(out var cur, out int step))
        {
            int x = cur.Item1, y = cur.Item2;
            if (step >= res)
                continue;

            char curC = matrix[x][y];
            if (curC >= 'A' && curC <= 'Z')
            {
                int curId = curC - 'A';
                if ((visitedChars & (1 << curId)) == 0)
                {
                    visitedChars |= (1 << curId);
                    foreach (int[] id in chars[curId])
                    {
                        pq.Enqueue((id[0], id[1]), step);
                        visited[id[0], id[1]] = true;
                    }
                }
            }

            if (x == m - 1 && y == n - 1)
            {
                res = Math.Min(res, step);
                continue;
            }

            for (int i = 0; i < 4; i++)
            {
                int nextX = x + dir[i], nextY = y + dir[i + 1];
                if (nextX < 0 || nextX >= m || nextY < 0 || nextY >= n || visited[nextX, nextY] || matrix[nextX][nextY] == '#' || step >= res - 1)
                    continue;

                pq.Enqueue((nextX, nextY), step + 1);
                visited[nextX, nextY] = true;
            }
        }

        return res == int.MaxValue ? -1 : res;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MinMoves(["A..",".A.","..."]), 2),
            ResultTester.CheckResult<int>(solution.MinMoves([".#...",".#.#.",".#.#.","...#."]), 13)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Grid Teleportation Traversal");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC  , Test.TestCases());
    }
}