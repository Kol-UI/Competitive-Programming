// Find Minimum Time to Reach Last Room II
namespace CompetitiveProgramming.LeetCode.FindMinimumTimetoReachLastRoomII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution 
{
    public int MinTimeToReach(int[][] moveTime) 
    {
        int n = moveTime.Length, m = moveTime[0].Length;

        var minHeap = new PriorityQueue<(int r, int c, int time, bool isAdjMove), int>();

        minHeap.Enqueue((0, 0, 0, false), 0);

        bool[,] seen = new bool[n, m];
        seen[0, 0] = true;

        int[] dx = new int[]{0, 1, 0, -1};
        int[] dy = new []{1, 0, -1, 0};
        while (minHeap.Count > 0) 
        {
            (int x, int y, int time, bool isAdjMove) = minHeap.Dequeue();
            if (x == n - 1 && y == m - 1)
                return time;
            
            for (int k = 0; k < 4; k++) 
            {
                int x1 = x + dx[k];
                int y1 = y + dy[k];
                if (x1 < 0 || y1 < 0 || x1 >= n || y1 >= m || seen[x1, y1])
                    continue;
                
                int newTime = Math.Max(time, moveTime[x1][y1]) + (isAdjMove ? 2 : 1);
                minHeap.Enqueue((x1, y1, newTime, !isAdjMove), newTime);
                seen[x1, y1] = true;
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
        StyleHelper.Title("Find Minimum Time to Reach Last Room II");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}