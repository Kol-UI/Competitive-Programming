// Count Non-Decreasing Subarrays After K Operations
namespace CompetitiveProgramming.LeetCode.CountNonDecreasingSubarraysAfterKOperations;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
    public long CountNonDecreasingSubarrays(int[] nums, int k) {
        int n = nums.Length;

        long res = (long)(1+n)*n/2;

        for(int i = 0; i < n-1; i++)
        {
            int preMax = nums[i], idx = i+1;
            int opt = 0;
            while(idx < n && opt <= k)
            {
                int diff = nums[idx]-preMax;
                if(diff >= 0)
                    preMax = nums[idx];
                else
                    opt -= diff;

                if(opt > k)
                    break;

                idx++;
            }

            if(idx >= n) return res;
   
            res -= (n-idx);
        }

        return res;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.CountNonDecreasingSubarrays([6,3,1,2,4,4], 7), 17),
            ResultTester.CheckResult<long>(solution.CountNonDecreasingSubarrays([6,3,1,3,6], 4), 12),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Non-Decreasing Subarrays After K Operations");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}