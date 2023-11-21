// Count Nice Pairs in an Array

/*
You are given an array nums that consists of non-negative integers. Let us define rev(x) as the reverse of the non-negative integer x. For example, rev(123) = 321, and rev(120) = 21. A pair of indices (i, j) is nice if it satisfies all of the following conditions:

0 <= i < j < nums.length
nums[i] + rev(nums[j]) == nums[j] + rev(nums[i])
Return the number of nice pairs of indices. Since that number can be too large, return it modulo 109 + 7.

 

Example 1:

Input: nums = [42,11,1,97]
Output: 2
Explanation: The two pairs are:
 - (0,3) : 42 + rev(97) = 42 + 79 = 121, 97 + rev(42) = 97 + 24 = 121.
 - (1,2) : 11 + rev(1) = 11 + 1 = 12, 1 + rev(11) = 1 + 11 = 12.

Example 2:

Input: nums = [13,10,35,24,76]
Output: 4
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CountNicePairsinanArray
{
    public class Solution
    {
        public static int CountNicePairs(int[] nums)
        {
            var dictionaryNums = CreateDictionary(nums);
            var resultLong = 0L;
            int divisor = 2;

            foreach (var item in dictionaryNums)
            {
                resultLong += item.Value * (long)(item.Value - 1) / divisor;
                resultLong %= 1_000_000_007;
            }

            var result = (int) resultLong;
            return result;
        }

        private static Dictionary<long, int> CreateDictionary(int[] nums)
        {
            var result = new Dictionary<long, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var key = nums[i] - Revert(nums[i]);
                if (!result.ContainsKey(key)) 
                {
                    result.Add(key, 0);
                }
                result[key]++;
            }

            return result;
        }
        private static long Revert(int num)
        {
            var result = 0L;

            while (num > 0)
            {
                result *= 10;
                result += num % 10;
                num /= 10;
            }
            
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1 = {42,11,1,97};
            int[] nums2 = {13,10,35,24,76};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CountNicePairs(nums1), 2),
                ResultTester.CheckResult<int>(Solution.CountNicePairs(nums2), 4),
            };
            return results;
        }
    }
}