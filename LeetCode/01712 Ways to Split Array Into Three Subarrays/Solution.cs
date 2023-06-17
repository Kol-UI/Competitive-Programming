// Ways to Split Array Into Three Subarrays

/*
A split of an integer array is good if:

The array is split into three non-empty contiguous subarrays - named left, mid, right respectively from left to right.
The sum of the elements in left is less than or equal to the sum of the elements in mid, and the sum of the elements in mid is less than or equal to the sum of the elements in right.
Given nums, an array of non-negative integers, return the number of good ways to split nums. As the number may be too large, return it modulo 109 + 7.

 

Example 1:

Input: nums = [1,1,1]
Output: 1
Explanation: The only good way to split nums is [1] [1] [1].

Example 2:

Input: nums = [1,2,2,2,5,0]
Output: 3
Explanation: There are three good ways of splitting nums:
[1] [2] [2,2,5,0]
[1] [2,2] [2,5,0]
[1,2] [2,2] [5,0]

Example 3:

Input: nums = [3,2,1]
Output: 0
Explanation: There is no good way to split nums.
*/

using System;
namespace CompetitiveProgramming.LeetCode.WaystoSplitArrayIntoThreeSubarrays
{
    public class Solution
    {
        public static int WaysToSplit(int[] nums)
        {
            var result = 0;
            var mod = 1000000007;
            var n = nums.Length;

            for (var i = 1; i < n; i++)
            {
                nums[i] += nums[i - 1];
            }

            for (var i = 0; i < n - 2; i++)
            {
                var start = -1;
                var end = -1;
                var low = i + 1;
                var high = n - 2;

                while (low <= high)
                {
                    var mid = low + (high - low) / 2;

                    if (nums[mid] - nums[i] >= nums[i])
                    {
                        start = mid;
                        high = mid - 1;
                    }
                    else
                        low = mid + 1;
                }

                if (start == -1) continue;
                high = n - 2;

                while (low <= high)
                {
                    var mid = low + (high - low) / 2;

                    if (nums[mid] - nums[i] > nums[n - 1] - nums[mid])
                        high = mid - 1;
                    else
                    {
                        end = mid;
                        low = mid + 1;
                    }
                }

                if (end == -1) continue;
                result = (result + (end - start + 1)) % mod;
            }        

            return result;
        }
    }
}