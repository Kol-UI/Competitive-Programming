// Maximum Number of Jumps to Reach the Last Index
namespace CompetitiveProgramming.LeetCode.MaximumNumberofJumpstoReachtheLastIndex;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaximumJumps(int[] nums, int target)
    {
        var dp = new int[nums.Length];
        dp[0] = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (dp[i] == 0) continue;
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (Math.Abs(nums[j] - nums[i]) <= target)
                {
                    dp[j] = Math.Max(dp[j], dp[i] + 1);
                }
            }
        }

        return dp[^1] > 0 ? dp[^1] - 1 : -1;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MaximumJumps([1,3,6,4,1,2], 2), 3),
            ResultTester.CheckResult<int>(solution.MaximumJumps([1,3,6,4,1,2], 3), 5),
            ResultTester.CheckResult<int>(solution.MaximumJumps([1,3,6,4,1,2], 0), -1),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Number of Jumps to Reach the Last Index");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}