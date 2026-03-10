// Find All Possible Stable Binary Arrays II
namespace CompetitiveProgramming.LeetCode.FindAllPossibleStableBinaryArraysII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int NumberOfStableArrays(int zero, int one, int limit)
    {
        const int MOD = 1000000007;
        int[][][] dp = new int[zero + 1][][];
        for (int i = 0; i <= zero; i++)
        {
            dp[i] = new int[one + 1][];
            for (int j = 0; j <= one; j++)
            {
                dp[i][j] = new int[2];
                for (int lastBit = 0; lastBit <= 1; lastBit++)
                {
                    if (i == 0)
                    {
                        if (lastBit == 0 || j > limit)
                        {
                            dp[i][j][lastBit] = 0;
                        }
                        else
                        {
                            dp[i][j][lastBit] = 1;
                        }
                    }
                    else if (j == 0)
                    {
                        if (lastBit == 1 || i > limit)
                        {
                            dp[i][j][lastBit] = 0;
                        }
                        else
                        {
                            dp[i][j][lastBit] = 1;
                        }
                    }
                    else if (lastBit == 0)
                    {
                        dp[i][j][lastBit] = dp[i - 1][j][0] + dp[i - 1][j][1];
                        if (i > limit)
                        {
                            dp[i][j][lastBit] -= dp[i - limit - 1][j][1];
                        }
                    }
                    else
                    {
                        dp[i][j][lastBit] = dp[i][j - 1][0] + dp[i][j - 1][1];
                        if (j > limit)
                        {
                            dp[i][j][lastBit] -= dp[i][j - limit - 1][0];
                        }
                    }
                    dp[i][j][lastBit] %= MOD;
                    if (dp[i][j][lastBit] < 0)
                    {
                        dp[i][j][lastBit] += MOD;
                    }
                }
            }
        }
        return (dp[zero][one][0] + dp[zero][one][1]) % MOD;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.NumberOfStableArrays(1,1,2), 2),
            ResultTester.CheckResult<int>(solution.NumberOfStableArrays(1,2,1), 1),
            ResultTester.CheckResult<int>(solution.NumberOfStableArrays(3,3,2), 14),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find All Possible Stable Binary Arrays II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}