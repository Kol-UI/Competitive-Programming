// Swim in Rising Water
namespace CompetitiveProgramming.LeetCode.SwiminRisingWater;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int SwimInWater(int[][] grid)
    {
        var pq = new PriorityQueue<(int h, int x, int y), int>();
        int m = grid.Length;
        bool[,] visited = new bool[m,m];
        int[] directions = {1, 0, -1, 0 ,1};
        pq.Enqueue((grid[0][0], 0, 0), grid[0][0]);
        visited[0, 0] = true;
       
        while(pq.Count > 0)
        {
            var (h, x, y) = pq.Dequeue();
            if(x == m-1 && y == m-1) return h;
            for(int d=0; d<4; d++)
            {
                int nx = x+directions[d], ny = y+directions[d+1];
                if(nx < 0 ||ny < 0||nx > m-1||ny > m -1||visited[nx, ny]) continue;
                visited[nx, ny] = true;
                int newH = Math.Max(h, grid[nx][ny]);
                pq.Enqueue((newH, nx, ny), newH);
            }
        }
        return -1;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Swim in Rising Water");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}