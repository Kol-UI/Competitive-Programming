// Count Subarrays With Score Less Than K
namespace CompetitiveProgramming.LeetCode.CountSubarraysWithScoreLessThanK;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long CountSubarrays(int[] nums, long k)
    {
        int n = nums.Length;
        long res = 0, total = 0;
        for (int i = 0, j = 0; j < n; j++)
        {
            total += nums[j];
            while (i <= j && total * (j - i + 1) >= k)
            {
                total -= nums[i];
                i++;
            }
            res += j - i + 1;
        }
        return res;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Subarrays With Score Less Than K");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}