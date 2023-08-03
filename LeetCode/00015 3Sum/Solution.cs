// 3Sum

/*
Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

Notice that the solution set must not contain duplicate triplets.

 

Example 1:

Input: nums = [-1,0,1,2,-1,-4]
Output: [[-1,-1,2],[-1,0,1]]
Explanation: 
nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
The distinct triplets are [-1,0,1] and [-1,-1,2].
Notice that the order of the output and the order of the triplets does not matter.

Example 2:

Input: nums = [0,1,1]
Output: []
Explanation: The only possible triplet does not sum up to 0.

Example 3:

Input: nums = [0,0,0]
Output: [[0,0,0]]
Explanation: The only possible triplet sums up to 0.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ThreeSum
{
    public class Solution
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            
            int i = 0;
            int left = 0;
            int right = 0;
            int sum = 0;

            Array.Sort(nums);
            
            for(i = 0; i < nums.Length - 2; i++)
            {
                if(i > 0 && nums[i] == nums[i - 1]) continue;

                left = i + 1;
                right = nums.Length - 1;

                while(left < right)
                {
                    sum = nums[i] + nums[left] + nums[right];
                    if(sum == 0)
                    {
                        result.Add(new List<int>{nums[i], nums[left], nums[right]});
                        left++;
                        while(left < right && nums[left] == nums[left - 1])
                        {
                            left++;
                        }
                    }

                    else if(sum > 0) right--;
                    else left++;
                }
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestThreeSum()
        {
            int[] nums1 = { 0,1,1 };
            int[] nums2 = { 0,0,0 };
            IList<IList<int>> output1 = new List<IList<int>>
            {
                new List<int> {0, 0, 0}
            };

            IList<IList<int>> output2 = new List<IList<int>>{};


            IList<IList<int>> result1 = LeetCode.ThreeSum.Solution.ThreeSum(nums1);
            IList<IList<int>> result2 = LeetCode.ThreeSum.Solution.ThreeSum(nums2);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<IList<int>>>(result1, output2),
                ResultTester.CheckResult<IList<IList<int>>>(result2, output1)
            };
            return results;
        }
    }
}
