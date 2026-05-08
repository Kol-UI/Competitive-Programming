// Detect Cycles in 2D Grid
namespace CompetitiveProgramming.LeetCode.DetectCyclesinTwoDGrid;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool ContainsCycle(char[][] grid)
    {
        var moves = new int[4][]{
            [0,1],
            [1,0],
            [0,-1],
            [-1,0]
        };
        int m = grid.Length, n = grid[0].Length;
        bool[][] visited = new bool[m][];

        for (int i = 0; i < m; i++)
            visited[i] = new bool[n];

        bool solve(int r, int c, int forbiddenMove)
        {
            if (visited[r][c])
                return true;
            visited[r][c] = true;
            bool res = false;
            for (int i = 0; i < moves.Length && !res; i++)
            {
                int newR = r + moves[i][0], newC = c + moves[i][1];
                if (
                        i == forbiddenMove || newR >= m || newR < 0 || newC < 0 ||
                        newC >= n || grid[newR][newC] != grid[r][c]
                    )
                    continue;
                res |= solve(newR, newC, (i + 2) % 4);
            }
            return res;
        }

        bool ans = false;
        for (int i = 0; i < m & !ans; i++)
        {
            for (int j = 0; j < n && !ans; j++)
            {
                if (!visited[i][j])
                    ans |= solve(i, j, -1);
            }
        }
        return ans;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Detect Cycles in 2D Grid");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}