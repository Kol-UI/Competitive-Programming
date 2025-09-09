// Number of People Aware of a Secret
namespace CompetitiveProgramming.LeetCode.NumberofPeopleAwareofaSecret;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int PeopleAwareOfSecret(int n, int delay, int forget)
    {
        int MOD = 1000000007;
        long[] dp = new long[n + 1];
        dp[1] = 1;

        for (int day = 2; day <= n; day++)
        {
            for (int prev = Math.Max(1, day - forget + 1); prev <= day - delay; prev++)
            {
                dp[day] = (dp[day] + dp[prev]) % MOD;
            }
        }

        long result = 0;
        for (int day = n - forget + 1; day <= n; day++)
        {
            if (day >= 1)
            {
                result = (result + dp[day]) % MOD;
            }
        }

        return (int)result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Number of People Aware of a Secret");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}