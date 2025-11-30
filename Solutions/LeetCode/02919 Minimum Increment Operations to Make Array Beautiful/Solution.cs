// Minimum Increment Operations to Make Array Beautiful
namespace CompetitiveProgramming.LeetCode.MinimumIncrementOperationstoMakeArrayBeautiful;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MinIncrementOperations(int[] nums, int k)
    {
        int len = nums.Length;
        long[] dp = new long[3];
        foreach (int cur in nums)
        {
            long curDP = Math.Min(dp[0], Math.Min(dp[1], dp[2])) + (cur < k ? k - cur : 0);
            dp[0] = dp[1];
            dp[1] = dp[2];
            dp[2] = curDP;
        }

        return Math.Min(dp[0], Math.Min(dp[1], dp[2]));
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<long>(solution.MinIncrementOperations([2,3,0,0,2], 4), 3),
            ResultTester.CheckResult<long>(solution.MinIncrementOperations([0,1,3,3], 5), 2),
            ResultTester.CheckResult<long>(solution.MinIncrementOperations([1,1,2], 1), 0),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Increment Operations to Make Array Beautiful");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}