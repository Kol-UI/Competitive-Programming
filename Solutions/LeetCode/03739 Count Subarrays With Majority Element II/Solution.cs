// Count Subarrays With Majority Element II
namespace CompetitiveProgramming.LeetCode.CountSubarraysWithMajorityElementII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long CountMajoritySubarrays(int[] nums, int target)
    {
        int n = nums.Length;
        int[] pre = new int[n * 2 + 1];
        pre[n] = 1;
        int cnt = n;
        long ans = 0, presum = 0;
        for (int i = 0; i < n; ++i)
        {
            if (nums[i] == target)
            {
                presum += pre[cnt];
                ++cnt;
                ++pre[cnt];
            }
            else
            {
                --cnt;
                presum -= pre[cnt];
                ++pre[cnt];
            }
            ans += presum;
        }
        return ans;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.CountMajoritySubarrays([1,2,2,3], 2), 5),
            ResultTester.CheckResult<long>(solution.CountMajoritySubarrays([1,1,1,1], 1), 10),
            ResultTester.CheckResult<long>(solution.CountMajoritySubarrays([1,2,3], 4), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Subarrays With Majority Element II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}