// Count Islands With Total Value Divisible by K
namespace CompetitiveProgramming.LeetCode.CountIslandsWithTotalValueDivisiblebyK;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountIslands(int[][] grid, int k)
    {
        int m = grid.Length, n = grid[0].Length;
        bool[,] visited = new bool[m,n];
        int[] dirs = new[] { 0, 1, 0, -1, 0 };
        int res = 0;
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(grid[i][j] == 0 || visited[i,j])
                    continue;

                int sum = 0;
                Queue<(int, int)> que = new();
                que.Enqueue((i,j));
                while(que.Count > 0)
                {
                    int qLen = que.Count;
                    for(int q = 0; q < qLen; q++)
                    {
                        (int x, int y) = que.Dequeue();
                        if(visited[x,y])
                            continue;

                        visited[x,y] = true;
                        sum += grid[x][y];
                        for(int d = 0; d < 4; d++)
                        {
                            int newX = x+dirs[d], newY = y+dirs[d+1];
                            if(newX < 0 || newY < 0 || newX >= m || newY >= n || visited[newX, newY] || grid[newX][newY] == 0)
                                continue;

                            que.Enqueue((newX, newY));
                        }
                    }
                }

                if(sum % k == 0)
                    res++;
            }
        }

        return res;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Islands With Total Value Divisible by K");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}