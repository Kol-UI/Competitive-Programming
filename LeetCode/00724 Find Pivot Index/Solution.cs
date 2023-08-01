// Find Pivot Index

/*
Given an array of integers nums, calculate the pivot index of this array.

The pivot index is the index where the sum of all the numbers strictly to the left of the index is equal to the sum of all the numbers strictly to the index's right.

If the index is on the left edge of the array, then the left sum is 0 because there are no elements to the left. This also applies to the right edge of the array.

Return the leftmost pivot index. If no such index exists, return -1.

 

Example 1:

Input: nums = [1,7,3,6,5,6]
Output: 3
Explanation:
The pivot index is 3.
Left sum = nums[0] + nums[1] + nums[2] = 1 + 7 + 3 = 11
Right sum = nums[4] + nums[5] = 5 + 6 = 11

Example 2:

Input: nums = [1,2,3]
Output: -1
Explanation:
There is no index that satisfies the conditions in the problem statement.

Example 3:

Input: nums = [2,1,-1]
Output: 0
Explanation:
The pivot index is 0.
Left sum = 0 (no elements to the left of index 0)
Right sum = nums[1] + nums[2] = 1 + -1 = 0
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindPivotIndex
{
    public class Solution
    {
        public static int PivotIndex(int[] nums)
        {
            if (nums.Length == 0) return -1;
            if (nums.Length == 1) return 0;

            var prefixSum = new int[nums.Length];
            var postfixSum = new int[nums.Length];

            postfixSum[nums.Length-1] = nums[nums.Length-1];
            for(var i = nums.Length - 2; i >= 0; i--)
            {
                postfixSum[i] = postfixSum[i+1] + nums[i];
            }

            prefixSum[0] = nums[0];
            for(var i = 1; i < nums.Length; i++)
            {
                prefixSum[i] = prefixSum[i-1] + nums[i];
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if (prefixSum[i] == postfixSum[i])
                {
                    return i;
                }
            }

            return -1;
        }
    }

    public class Test
    {
        public static bool[] TestFindPivotIndex()
        {
            int[] nums1 = {1,7,3,6,5,6};
            int[] nums2 = {1,2,3};
            int[] nums3 = {2,1,-1};

            int result1 = Solution.PivotIndex(nums1);
            int result2 = Solution.PivotIndex(nums2);
            int result3 = Solution.PivotIndex(nums3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 3),
                ResultTester.CheckResult<int>(result2, -1),
                ResultTester.CheckResult<int>(result3, 0)
            };

            return results;
        }
    }
}