// Wiggle Subsequence

/*
A wiggle sequence is a sequence where the differences between successive numbers strictly alternate between positive and negative. The first difference (if one exists) may be either positive or negative. A sequence with one element and a sequence with two non-equal elements are trivially wiggle sequences.

For example, [1, 7, 4, 9, 2, 5] is a wiggle sequence because the differences (6, -3, 5, -7, 3) alternate between positive and negative.
In contrast, [1, 4, 7, 2, 5] and [1, 7, 4, 5, 5] are not wiggle sequences. The first is not because its first two differences are positive, and the second is not because its last difference is zero.
A subsequence is obtained by deleting some elements (possibly zero) from the original sequence, leaving the remaining elements in their original order.

Given an integer array nums, return the length of the longest wiggle subsequence of nums.


Example 1:

Input: nums = [1,7,4,9,2,5]
Output: 6
Explanation: The entire sequence is a wiggle sequence with differences (6, -3, 5, -7, 3).
Example 2:

Input: nums = [1,17,5,10,13,15,10,5,16,8]
Output: 7
Explanation: There are several subsequences that achieve this length.
One is [1, 17, 10, 13, 10, 16, 8] with differences (16, -7, 3, -3, 6, -8).
Example 3:

Input: nums = [1,2,3,4,5,6,7,8,9]
Output: 2
*/

using System;
namespace CompetitiveProgramming.LeetCode.WiggleSubsequence
{
    public class Solution
    {
        public static int WiggleMaxLength(int[] nums)
        {
            var dpUp = new (int len, int val)[nums.Length];
            var dpDn = new (int len, int val)[nums.Length];

            dpUp[0] = (1, nums[0]);
            dpDn[0] = (1, nums[0]);

            for (int i = 1, i0 = 0; i < nums.Length; i++, i0++)
            {
                if (nums[i] < dpUp[i0].val)
                    dpDn[i] = (dpUp[i0].len + 1, nums[i]);

                if (dpDn[i0].len > dpDn[i].len)
                    dpDn[i] = dpDn[i0];
                else if (dpDn[i0].len == dpDn[i].len)
                    dpDn[i] = (dpDn[i0].len, Math.Min(dpDn[i].val, dpDn[i0].val));
                
                if (nums[i] > dpDn[i0].val)
                    dpUp[i] = (dpDn[i0].len + 1, nums[i]);

                if (dpUp[i0].len > dpUp[i].len)
                    dpUp[i] = dpUp[i0];
                else if(dpUp[i0].len == dpUp[i].len)
                    dpUp[i] = (dpUp[i0].len, Math.Max(dpUp[i].val, dpUp[i0].val));
            }

            return Math.Max(dpUp[^1].len, dpDn[^1].len);
        }
    }
}