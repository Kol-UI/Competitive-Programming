// Count the Number of Good Subarrays
namespace CompetitiveProgramming.LeetCode.CounttheNumberofGoodSubarrays;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
    public long CountGood(int[] nums, int k) {
        
        long result = 0;
        int left = 0, right = 0, validSubarray = 0, n = nums.Length;
        Dictionary<int,int> dic = new Dictionary<int,int>();
        
        while(right < n)
        {
            validSubarray += dic.GetValueOrDefault(nums[right], 0);
            dic[nums[right]] = dic.GetValueOrDefault(nums[right], 0) + 1;

            while(validSubarray >= k)
            {
                result += n - right;
                validSubarray -= dic[nums[left]] - 1;
                dic[nums[left]]--;
                left++;
            }

            right++;
        }

        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count the Number of Good Subarrays");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}