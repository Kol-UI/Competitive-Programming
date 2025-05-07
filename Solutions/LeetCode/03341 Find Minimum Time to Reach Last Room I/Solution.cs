// Find Minimum Time to Reach Last Room I
namespace CompetitiveProgramming.LeetCode.FindMinimumTimetoReachLastRoomI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution 
{
    public int MinTimeToReach(int[][] moveTime) 
    {
        int[] dx = new int[] {0, 1, 0, -1};
        int[] dy = new int[] {1, 0, -1, 0};
        int n = moveTime.Length, m = moveTime[0].Length;

        var minHeap = new PriorityQueue<(int r, int c, int t), int>();
        minHeap.Enqueue((0, 0, 0), 0);

        bool[,] seen = new bool[n, m];
        seen[0, 0] = true;
        while (minHeap.Count > 0) 
        {
            (int x, int y, int t) = minHeap.Dequeue();
            if (x == n - 1 && y == m - 1)
                return t;
            
            for (int k = 0; k < 4; k++) 
            {
                int x1 = x + dx[k];
                int y1 = y + dy[k];
                if (x1 < 0 || y1 < 0 || x1 >= n || y1 >= m || seen[x1, y1])
                    continue;
                
                var time = moveTime[x1][y1];
                int newTime = Math.Max(t, time) + 1;

                minHeap.Enqueue((x1, y1, newTime), newTime);
                seen[x1, y1] = true;
            }
        }
        return -1;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();

        int[][] moveTime1 = new int[][]
        {
            new int[] {0, 4},
            new int[] {4, 4}
        };

        int[][] moveTime2 = new int[][]
        {
            new int[] {0, 0, 0},
            new int[] {0, 0, 0}
        };

        int[][] moveTime3 = new int[][]
        {
            new int[] {0, 1},
            new int[] {1, 2}
        };

        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MinTimeToReach(moveTime1), 6),
            ResultTester.CheckResult<int>(solution.MinTimeToReach(moveTime2), 3),
            ResultTester.CheckResult<int>(solution.MinTimeToReach(moveTime3), 3),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find Minimum Time to Reach Last Room I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}