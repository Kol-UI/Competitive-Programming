// Maximum Coins From K Consecutive Bags
namespace CompetitiveProgramming.LeetCode.MaximumCoinsFromKConsecutiveBags;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MaximumCoins(int[][] coins, int k)
    {
        int len = coins.Length;
        long totalScore = 0, curSum = 0;
        coins = coins.OrderBy(x => x[0]).ToArray();
        int j = 0;
        for (int i = 0; i < len; i++)
        {
            while (j < len && coins[j][1] - coins[i][0] < k)
            {
                long nextVal = (long)(coins[j][1] - coins[j][0] + 1) * coins[j][2];
                curSum += nextVal;
                j++;
            }
            long rest = 0;
            if (j < len)
            {
                rest = Math.Max(rest, (long)(coins[i][0] + k - 1 - coins[j][0] + 1) * coins[j][2]);
            }

            totalScore = Math.Max(totalScore, curSum + rest);
            curSum -= (long)(coins[i][1] - coins[i][0] + 1) * coins[i][2];
        }

        j = len - 1;
        curSum = 0;

        for (int i = len - 1; i >= 0; i--)
        {
            while (j >= 0 && coins[i][1] - coins[j][0] < k)
            {
                curSum += (long)(coins[j][1] - coins[j][0] + 1) * coins[j][2];
                j--;
            }

            long rest = 0;
            if (j >= 0)
            {
                rest = Math.Max(rest, (long)(coins[j][1] - (coins[i][1] - k + 1) + 1) * coins[j][2]);
            }
            totalScore = Math.Max(totalScore, curSum + rest);
            curSum -= (long)coins[i][2] * (coins[i][1] - coins[i][0] + 1);
        }

        return totalScore;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Coins From K Consecutive Bags");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}
