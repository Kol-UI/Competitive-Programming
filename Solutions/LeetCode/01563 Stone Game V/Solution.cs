// Stone Game V
namespace CompetitiveProgramming.LeetCode.StoneGameV;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int StoneGameV(int[] stoneValue)
    {
        int n = stoneValue.Length;
        long[] prefix = new long[n + 1];

        for (int i = 0; i < n; i++)  prefix[i + 1] = prefix[i] + stoneValue[i];
        
        int[,] dp = new int[n, n];

        for (int len = 2; len <= n; len++)
        {
            for (int i = 0; i <= n - len; i++)
            {
                int j = i + len - 1;
                long total = prefix[j + 1] - prefix[i];
                int maxScore = 0;

                for (int mid = i; mid < j; mid++)
                {
                    long leftSum = prefix[mid + 1] - prefix[i];
                    long rightSum = total - leftSum;

                    int score;
                    if (leftSum < rightSum) score = (int)leftSum + dp[i, mid];
                    else if (leftSum > rightSum)  score = (int)rightSum + dp[mid + 1, j];
                    else  score = (int)leftSum + Math.Max(dp[i, mid], dp[mid + 1, j]);
                    
                    maxScore = Math.Max(maxScore, score);
                }

                dp[i, j] = maxScore;
            }
        }

        return dp[0, n - 1];
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.StoneGameV([6,2,3,4,5,5]), 18),
            ResultTester.CheckResult<int>(solution.StoneGameV([7,7,7,7,7,7,7]), 28),
            ResultTester.CheckResult<int>(solution.StoneGameV([4]), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Stone Game V");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}