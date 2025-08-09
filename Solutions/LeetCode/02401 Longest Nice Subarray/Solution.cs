// Longest Nice Subarray
namespace CompetitiveProgramming.LeetCode.LongestNiceSubarray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int LongestNiceSubarray(int[] nums)
    {
        int l = 0 , r = 1, ans = 1;
        int value = nums[0];
        while(l < nums.Length)
        {
            while(r < nums.Length && (value & nums[r]) == 0)
            {
                value |= nums[r];
                ans = Math.Max(ans, r - l + 1);
                r++;
            } 
            value &= ~nums[l];
            l++;
        }
        
        return ans;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.LongestNiceSubarray(new int[]{1,3,8,48,10}), 3),
            ResultTester.CheckResult<int>(solution.LongestNiceSubarray(new int[]{3,1,5,11,13}), 1),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Longest Nice Subarray");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
} 