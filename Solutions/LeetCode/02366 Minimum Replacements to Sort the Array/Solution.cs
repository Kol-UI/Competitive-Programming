// Minimum Replacements to Sort the Array

/*
You are given a 0-indexed integer array nums. In one operation you can replace any element of the array with any two elements that sum to it.

For example, consider nums = [5,6,7]. In one operation, we can replace nums[1] with 2 and 4 and convert nums to [5,2,4,7].
Return the minimum number of operations to make an array that is sorted in non-decreasing order.

Example 1:

Input: nums = [3,9,3]
Output: 2
Explanation: Here are the steps to sort the array in non-decreasing order:
- From [3,9,3], replace the 9 with 3 and 6 so the array becomes [3,3,6,3]
- From [3,3,6,3], replace the 6 with 3 and 3 so the array becomes [3,3,3,3,3]
There are 2 steps to sort the array in non-decreasing order. Therefore, we return 2.

Example 2:

Input: nums = [1,2,3,4,5]
Output: 0
Explanation: The array is already in non-decreasing order. Therefore, we return 0. 
*/

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumReplacementstoSorttheArray
{
    public class Solution
    {
        public static long MinimumReplacement(int[] nums)
        {
            long answer = 0;
            int lastOne = nums[nums.Length - 1];
            for(int i = nums.Length - 2; i >= 0; i--)
            {
                if(nums[i] > lastOne)
                {
                    int times = nums[i] / lastOne;
                    answer += times - 1;
                    int rest = nums[i] % lastOne;
                    if(rest != 0)
                    {
                        lastOne = nums[i] / (times + 1);                                      
                        answer++;
                    }
                }
                else
                {
                    lastOne = nums[i];
                }
            }
            return answer;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1 = {3,9,3};
            int[] nums2 = {1,2,3,4,5};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(Solution.MinimumReplacement(nums1), 2),
                ResultTester.CheckResult<long>(Solution.MinimumReplacement(nums2), 0),
            };
            return results;
        }
    }
    
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Replacements to Sort the Array");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}