// Maximum Absolute Sum of Any Subarray
namespace CompetitiveProgramming.LeetCode.MaximumAbsoluteSumofAnySubarray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxAbsoluteSum(int[] nums)
    {
        int minPrefixSum = 0, maxPrefixSum = 0;
        int prefixSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            prefixSum += nums[i];

            minPrefixSum = Math.Min(minPrefixSum, prefixSum);
            maxPrefixSum = Math.Max(maxPrefixSum, prefixSum);
        }

        return maxPrefixSum - minPrefixSum;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Absolute Sum of Any Subarray");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}