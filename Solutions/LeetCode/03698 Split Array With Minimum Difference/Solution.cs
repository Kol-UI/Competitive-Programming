// Split Array With Minimum Difference
namespace CompetitiveProgramming.LeetCode.SplitArrayWithMinimumDifference;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long SplitArray(int[] nums)
    {
        int len = nums.Length;
        long[] leftIncre = new long[len], rightDecre = new long[len];

        for (int i = 0; i < len; i++)
        {
            leftIncre[i] = -1;
            rightDecre[i] = -1;
        }

        leftIncre[0] = nums[0];
        rightDecre[len - 1] = nums[len - 1];
        for (int i = 1; i < len; i++)
        {
            if (nums[i] > nums[i - 1])
                leftIncre[i] = nums[i] + leftIncre[i - 1];
            else
                break;
        }

        for (int i = len - 2; i >= 0; i--)
        {
            if (nums[i] > nums[i + 1])
                rightDecre[i] = nums[i] + rightDecre[i + 1];
            else
                break;
        }

        long result = long.MaxValue;
        for (int i = 0; i < len; i++)
        {
            long left = leftIncre[i];
            long right = (i == len - 1 ? 0 : rightDecre[i + 1]);
            if (left < 0)
                break;

            if (right > 0)
                result = Math.Min(result, Math.Abs(left - right));
        }

        return result == long.MaxValue ? -1 : result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.SplitArray([1,3,2]), 2),
            ResultTester.CheckResult<long>(solution.SplitArray([1,2,4,3]), 4),
            ResultTester.CheckResult<long>(solution.SplitArray([3,1,2]), -1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Split Array With Minimum Difference");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}