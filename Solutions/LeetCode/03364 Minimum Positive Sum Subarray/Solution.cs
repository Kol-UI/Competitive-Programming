// Minimum Positive Sum Subarray
namespace CompetitiveProgramming.LeetCode.MinimumPositiveSumSubarray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinimumSumSubarray(IList<int> nums, int l, int r)
    {
        var leftSums = GetLeftSums(nums);
        var result = int.MaxValue;
        for (int i = 0; i <= nums.Count - l; i++)
        {
            for (int j = i + l - 1; j <= Math.Min(i + r - 1, nums.Count - 1); j++)
            {
                var result0 = leftSums[i] - leftSums[j + 1];
                if (result0 > 0) result = Math.Min(result, result0);
            }
        }
        if (result == int.MaxValue) result = -1;
        return result;
    }

    private int[] GetLeftSums(IList<int> nums)
    {
        var result = new int[nums.Count + 1];
        result[result.Length - 2] = nums[nums.Count - 1];
        for (int i = result.Length - 2; i >= 0; i--)
        {
            result[i] = nums[i] + result[i + 1];
        }
        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinimumSumSubarray([3, -2, 1, 4], 2, 3), 1),
            ResultTester.CheckResult<int>(solution.MinimumSumSubarray([-2, 2, -3, 1], 2, 3), -1),
            ResultTester.CheckResult<int>(solution.MinimumSumSubarray([1, 2, 3, 4], 2, 4), 3),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Positive Sum Subarray");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}