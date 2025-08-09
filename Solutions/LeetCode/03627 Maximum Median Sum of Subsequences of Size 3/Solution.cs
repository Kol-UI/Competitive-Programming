// Maximum Median Sum of Subsequences of Size 3
namespace CompetitiveProgramming.LeetCode.MaximumMedianSumofSubsequencesofSize3;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MaximumMedianSum(int[] nums)
    {
        var length = nums.Length;
        var b = length / 3;
        var result = 0L;

        Array.Sort(nums);

        for (int i = 1; i <= b; i++)
        {
            result += nums[length - i * 2];
        }

        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Median Sum of Subsequences of Size 3");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}