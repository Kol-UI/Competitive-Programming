// Number of Paths with Max Score
namespace CompetitiveProgramming.LeetCode.NumberofPathswithMaxScore;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] PathsWithMaxScore(IList<string> board)
    {
        int m = board.Count, n = board[0].Length, mod = (int)Math.Pow(10,9)+7;
        int[,,] dp = new int[m,n,2];

        int[][] dirs = [[-1,0],[0,-1],[-1,-1]];

        Queue<int[]> que = new();
        que.Enqueue([m-1, n-1,0]);
        dp[m-1,n-1,1] = 1;
        while(que.Count > 0)
        {
            int[] cur = que.Dequeue();
            int x = cur[0], y = cur[1], sum = cur[2];
            foreach(int[] d in dirs)
            {
                int newX = x+d[0], newY = y + d[1];
                if(newX < 0 || newY < 0 || board[newX][newY] == 'X')
                    continue;

                char c = board[newX][newY];
                int newSum = sum + (c == 'E' ? 0 : c-'0');
                if(newSum > dp[newX, newY, 0])
                {
                    dp[newX, newY, 0] = newSum;
                    que.Enqueue([newX, newY, newSum]);
                    dp[newX, newY, 1] = dp[x,y,1];
                }
                else if(newSum == dp[newX, newY, 0])
                {
                    dp[newX, newY, 1] = (int)((long)(dp[newX, newY, 1] + dp[x,y,1])%mod);
                }
            }
        }

        int[] res = [dp[0,0,0],dp[0,0,1]];
        return res;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[]>(solution.PathsWithMaxScore(["E23","2X2","12S"]), [7,1]),
            ResultTester.CheckResult<int[]>(solution.PathsWithMaxScore(["E12","1X1","21S"]), [4,2]),
            ResultTester.CheckResult<int[]>(solution.PathsWithMaxScore(["E11","XXX","11S"]), [0,0]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Number of Paths with Max Score");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}