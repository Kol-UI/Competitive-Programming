// Maximum OR
namespace CompetitiveProgramming.LeetCode.MaximumOR;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

#pragma warning disable CS0675
public class Solution
{
    public long MaximumOr(int[] nums, int k)
    {
        int len = nums.Length;
        long[] leftOr = new long[len], rightOr = new long[len];
        long maxOr = 0;
        for (int i = 1; i < len; i++)
        {
            leftOr[i] = leftOr[i - 1] | nums[i - 1];
        }

        for (int i = len - 2; i >= 0; i--)
        {
            rightOr[i] = rightOr[i + 1] | nums[i + 1];
        }

        int times = (int)Math.Pow(2, k);
        for (int i = 0; i < len; i++)
        {
            long cur = (long)nums[i] * times;
            cur |= leftOr[i];
            cur |= rightOr[i];
            maxOr = Math.Max(maxOr, cur);
        }

        return maxOr;
    }
}
#pragma warning restore CS0675

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.MaximumOr([12,9], 1), 30),
            ResultTester.CheckResult<long>(solution.MaximumOr([8,1,2], 2), 35),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum OR");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}