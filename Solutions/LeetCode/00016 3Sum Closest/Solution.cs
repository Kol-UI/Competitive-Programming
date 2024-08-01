// 3Sum Closest

/*
Given an integer array nums of length n and an integer target, find three integers in nums such that the sum is closest to target.

Return the sum of the three integers.

You may assume that each input would have exactly one solution.

 

Example 1:

Input: nums = [-1,2,1,-4], target = 1
Output: 2
Explanation: The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).

Example 2:

Input: nums = [0,0,0], target = 1
Output: 0
Explanation: The sum that is closest to the target is 0. (0 + 0 + 0 = 0).
*/

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ThreeSumClosest
{
    public class Solution
    {
        public static int ThreeSumClosest(int[] nums, int target)
        {
            int n = nums.Length;
            int minAns = int.MaxValue;
            int result = 0;
            Array.Sort(nums);

            for(int i = 0; i < n - 2; i++)
            {
                int left = i + 1;
                int right = n - 1;
                while(left < right)
                {
                    int values = nums[i] + nums[left] + nums[right];
                    int diffOfValAndTarget = Math.Abs(values - target);
                    if(minAns > diffOfValAndTarget)
                        {
                            result = values;
                            minAns = diffOfValAndTarget;
                        }
                        if(values > target) right--;
                        else left++;
                    }
            }
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestThreeSumClosest()
        {
            int[] nums1 = {-1,2,1,-4};
            int target1 = 1;
            int[] nums2 = {0,0,0};
            int target2 = 1;
            int result1 = Solution.ThreeSumClosest(nums1, target1);
            int result2 = Solution.ThreeSumClosest(nums2, target2);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 2),
                ResultTester.CheckResult<int>(result2, 0)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("3Sum Closest");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestThreeSumClosest());
        }
    }
}