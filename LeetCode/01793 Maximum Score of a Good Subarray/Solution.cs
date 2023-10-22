// Maximum Score of a Good Subarray

/*
You are given an array of integers nums (0-indexed) and an integer k.

The score of a subarray (i, j) is defined as min(nums[i], nums[i+1], ..., nums[j]) * (j - i + 1). A good subarray is a subarray where i <= k <= j.

Return the maximum possible score of a good subarray.

 

Example 1:

Input: nums = [1,4,3,7,4,5], k = 3
Output: 15
Explanation: The optimal subarray is (1, 5) with a score of min(4,3,7,4,5) * (5-1+1) = 3 * 5 = 15. 

Example 2:

Input: nums = [5,5,4,5,4,1,1,1], k = 0
Output: 20
Explanation: The optimal subarray is (0, 4) with a score of min(5,5,4,5,4) * (4-0+1) = 4 * 5 = 20.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumScoreofaGoodSubarray
{
    public class Solution
    {
        public static int MaximumScore1(int[] nums, int k)
        {
            int bal = k;
            int jobb = k;
            int min_ert = nums[k];
            int max_pont = min_ert;

            while (bal > 0 || jobb < nums.Length - 1)
            {
                if (bal == 0 || (jobb < nums.Length - 1 && nums[jobb + 1] > nums[bal - 1]))
                {
                    jobb++;
                }
                else
                {
                    bal--;
                }
                
                min_ert = Math.Min(min_ert, Math.Min(nums[bal], nums[jobb]));
                max_pont = Math.Max(max_pont, min_ert * (jobb - bal + 1));
            }
            
            return max_pont;
        }

        public static int MaximumScore2(int[] nums, int k)
        {
            int res = nums[k];
            int i = k;
            int j = k;
            int min_val = nums[k];

            while (i > 0 || j < nums.Length - 1)
            {
                if (i == 0)
                {
                    j += 1;
                    min_val = Math.Min(min_val, nums[j]);
                }
                else if (j == nums.Length - 1)
                {
                    i -= 1;
                    min_val = Math.Min(min_val, nums[i]);
                }
                else if (nums[i - 1] > nums[j + 1])
                {
                    i -= 1;
                    min_val = Math.Min(min_val, nums[i]);
                }
                else
                {
                    j += 1;
                    min_val = Math.Min(min_val, nums[j]);
                }

                res = Math.Max(res, min_val * (j - i + 1));
            }

            return res;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1 = {1,4,3,7,4,5};
            int k1 = 3;
            int[] nums2 = {5,5,4,5,4,1,1,1};
            int k2 = 0;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MaximumScore1(nums1, k1), 15),
                ResultTester.CheckResult<int>(Solution.MaximumScore2(nums1, k1), 15),
                ResultTester.CheckResult<int>(Solution.MaximumScore1(nums2, k2), 20),
                ResultTester.CheckResult<int>(Solution.MaximumScore2(nums2, k2), 20),
            };
            return results;
        }
    }
}