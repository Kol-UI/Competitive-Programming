// Maximize Total Cost of Alternating Subarrays
namespace CompetitiveProgramming.LeetCode.MaximizeTotalCostofAlternatingSubarrays;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MaximumTotalCost(int[] nums)
    {
        long[] dp = new long[nums.Length+1];
        dp[0] = 0;
        dp[1] = nums[0];
        for (int i = 1;i < nums.Length; i++)
        {
            dp[i+1] = dp[i]+nums[i];
            dp[i+1] = Math.Max(dp[i-1] + nums[i-1] - nums[i], dp[i+1]);
        }
        return dp[nums.Length];
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();

        int[] nums1 = { 1, -2, 3, 4 };
        int[] nums2 = { 1, -1, 1, -1 };
        int[] nums3 = { 0 };
        int[] nums4 = { 1, -1 };

        bool[] results = new bool[]
        {
            ResultTester.CheckResult<long>(solution.MaximumTotalCost(nums1), 10),
            ResultTester.CheckResult<long>(solution.MaximumTotalCost(nums2), 4),
            ResultTester.CheckResult<long>(solution.MaximumTotalCost(nums3), 0),
            ResultTester.CheckResult<long>(solution.MaximumTotalCost(nums4), 2),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximize Total Cost of Alternating Subarrays");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}