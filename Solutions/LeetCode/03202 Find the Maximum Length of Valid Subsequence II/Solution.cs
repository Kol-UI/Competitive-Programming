// Find the Maximum Length of Valid Subsequence II
namespace CompetitiveProgramming.LeetCode.FindtheMaximumLengthofValidSubsequenceII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaximumLength(int[] nums, int k)
    {
        var len = nums.Length;
        if (len < 2) return 0;
        var res = 1;
        var last = new int[k];
        for (var i = 0; i < k; ++i) last[i] = -1;
        last[nums[0] % k] =  0;
        var dp = new int[k][];
        for (var i = 0; i < k; ++i) dp[i] = new int[k];
        
        for (var i = 1; i < len; ++i)
        {
            var num = nums[i] % k;
            for (var target = 0; target < k; ++target)
            {
                var r = (num > target ? (target + k) : target) - num;
                if ((num == r && last[num] > -1) || last[r] > last[num])
                {
                    dp[target][num] = dp[target][r] + 1;
                    res = Math.Max(res, dp[target][num]);
                }
            }
            last[num] = i;
        }
            
        return res + 1;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find the Maximum Length of Valid Subsequence II");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}