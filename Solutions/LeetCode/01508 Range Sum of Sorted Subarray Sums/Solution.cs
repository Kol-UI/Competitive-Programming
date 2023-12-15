// Range Sum of Sorted Subarray Sums

/*
You are given the array nums consisting of n positive integers. You computed the sum of all non-empty continuous subarrays from the array and then sorted them in non-decreasing order, creating a new array of n * (n + 1) / 2 numbers.

Return the sum of the numbers from index left to index right (indexed from 1), inclusive, in the new array. Since the answer can be a huge number return it modulo 109 + 7.

 

Example 1:

Input: nums = [1,2,3,4], n = 4, left = 1, right = 5
Output: 13 
Explanation: All subarray sums are 1, 3, 6, 10, 2, 5, 9, 3, 7, 4. After sorting them in non-decreasing order we have the new array [1, 2, 3, 3, 4, 5, 6, 7, 9, 10]. The sum of the numbers from index le = 1 to ri = 5 is 1 + 2 + 3 + 3 + 4 = 13. 

Example 2:

Input: nums = [1,2,3,4], n = 4, left = 3, right = 4
Output: 6
Explanation: The given array is the same as example 1. We have the new array [1, 2, 3, 3, 4, 5, 6, 7, 9, 10]. The sum of the numbers from index le = 3 to ri = 4 is 3 + 3 = 6.

Example 3:

Input: nums = [1,2,3,4], n = 4, left = 1, right = 10
Output: 50
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RangeSumofSortedSubarraySums
{
    public class Solution
    {
        public static int RangeSum(int[] nums, int n, int left, int right)
        {
            var sums = new long[n * (n + 1) / 2];
            var mod = 1000000007;
            var p = 0;
            var sum = nums[0];

            for (var i = 1; i < n; i++) 
            {
                sum += nums[i];
                nums[i] = sum;
            }

            for (var i = 0; i < n; i++)
            {
                sums[p++] = nums[i] - ((i > 0) ? nums[i - 1] : 0);
                if (i > 0) sums[p++] = nums[i];

                for (var j = i - 2; j >= 0; j--)
                {
                    sums[p++] = nums[i] - nums[j]; 
                }
            }

            Array.Sort(sums);

            long res = 0;
            for (var i = left - 1; i < right; i++)
            {
                res += (sums[i] % mod);
            }

            return (int)(res % mod);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1 = {1,2,3,4};
            int n1 = 4;
            int left1 = 1;
            int right1 = 5;

            int[] nums2 = {1,2,3,4};
            int n2 = 4;
            int left2 = 3;
            int right2 = 4;

            int[] nums3 = {1,2,3,4};
            int n3 = 4;
            int left3 = 1;
            int right3 = 10;

            int result1 = Solution.RangeSum(nums1, n1, left1, right1);
            int result2 = Solution.RangeSum(nums2, n2, left2, right2);
            int result3 = Solution.RangeSum(nums3, n3, left3, right3);
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 13),
                ResultTester.CheckResult<int>(result2, 6),
                ResultTester.CheckResult<int>(result3, 50)
            };
            return results;
        }
    }
}