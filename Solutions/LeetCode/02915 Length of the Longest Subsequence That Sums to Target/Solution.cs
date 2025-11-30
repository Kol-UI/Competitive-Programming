// Length of the Longest Subsequence That Sums to Target
namespace CompetitiveProgramming.LeetCode.LengthoftheLongestSubsequenceThatSumstoTarget;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int LengthOfLongestSubsequence(IList<int> nums, int target)
    {
        int len = nums.Count;
        int[] dp = Enumerable.Repeat(-1, target + 1).ToArray();
        dp[0] = 0;

        for (int i = 0; i < len; i++)
        {
            if (nums[i] > target)
                continue;

            for (int j = target - nums[i]; j >= 0; j--)
            {
                if (dp[j] == -1)
                    continue;

                dp[j + nums[i]] = Math.Max(dp[j + nums[i]], dp[j] + 1);
            }
        }

        return dp[target];
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.LengthOfLongestSubsequence([1,2,3,4,5], 9), 3),
            ResultTester.CheckResult<int>(solution.LengthOfLongestSubsequence([4,1,3,2,1,5], 7), 4),
            ResultTester.CheckResult<int>(solution.LengthOfLongestSubsequence([1,1,5,4,5], 3), -1),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Length of the Longest Subsequence That Sums to Target");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}