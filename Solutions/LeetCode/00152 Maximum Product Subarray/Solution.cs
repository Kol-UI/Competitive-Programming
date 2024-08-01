// Maximum Product Subarray

/*
Given an integer array nums, find a subarray that has the largest product, and return the product.

The test cases are generated so that the answer will fit in a 32-bit integer.

 

Example 1:

Input: nums = [2,3,-2,4]
Output: 6
Explanation: [2,3] has the largest product 6.

Example 2:

Input: nums = [-2,0,-1]
Output: 0
Explanation: The result cannot be 2, because [-2,-1] is not a subarray.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MaximumProductSubarray
{
    public class Solution
    {
        public static int MaxProduct(int[] nums)
        {
            int n = nums.Length;
            int pos = nums[0] > 0 ? nums[0] : 0; 
            int neg = nums[0] < 0 ? nums[0] : 0; 
            int res = nums[0];

            for(int i = 1; i < n; i++)
            {
                if(nums[i] < 0)
                {
                    if(neg < 0)
                    {
                        (pos, neg) = (nums[i]*neg, pos > 0 ? nums[i]*pos : nums[i]);
                    }
                    else
                    {
                        (pos, neg) = (0, pos > 0 ? nums[i]*pos : nums[i]);
                    }
                    
                }
                else
                {
                    pos = pos > 0 ? pos*nums[i] : nums[i];
                    neg = neg*nums[i];
                }

                res = Math.Max(pos, res);
            }
            return res;
        }
    }

    public class Test
    {
        public static bool[] TestMaximumProductSubarray()
        {
            int[] nums1_152 = {2,3,-2,4};
            int[] nums2_152 = {-2,0,-1};

            int result1_152 = Solution.MaxProduct(nums1_152);
            int result2_152 = Solution.MaxProduct(nums2_152);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_152, 6),
                ResultTester.CheckResult<int>(result2_152, 0)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Product Subarray");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestMaximumProductSubarray());
        }
    }
}