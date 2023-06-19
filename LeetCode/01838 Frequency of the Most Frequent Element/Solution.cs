// Frequency of the Most Frequent Element

/*
The frequency of an element is the number of times it occurs in an array.

You are given an integer array nums and an integer k. In one operation, you can choose an index of nums and increment the element at that index by 1.

Return the maximum possible frequency of an element after performing at most k operations.

 

Example 1:

Input: nums = [1,2,4], k = 5
Output: 3
Explanation: Increment the first element three times and the second element two times to make nums = [4,4,4].
4 has a frequency of 3.

Example 2:

Input: nums = [1,4,8,13], k = 5
Output: 2
Explanation: There are multiple optimal solutions:
- Increment the first element three times to make nums = [4,4,8,13]. 4 has a frequency of 2.
- Increment the second element four times to make nums = [1,8,8,13]. 8 has a frequency of 2.
- Increment the third element five times to make nums = [1,4,13,13]. 13 has a frequency of 2.

Example 3:

Input: nums = [3,9,6], k = 2
Output: 1
*/

using System;
namespace CompetitiveProgramming.LeetCode.FrequencyoftheMostFrequentElement
{
    public class Solution
    {
        public static int MaxFrequency(int[] nums, int k)
        {
            int n = nums.Length;
            int result = 1;

            if (n == 1) return result;

            Array.Sort(nums);
            HashSet<int> hs = new HashSet<int>();

            for (int i = n - 1; i >- 1; i--)
            {
                if (hs.Contains(nums[i])) continue;
                int current = CountUpForK(nums, i, k);
                result = Math.Max(result, current);
                hs.Add(nums[i]);
            }

            return result;
        }

        public static int CountUpForK(int[] nums, int pos, int k)
        {
            int sum = 1;
            for (int u = pos - 1; u >- 1; u--)
            {
                if (nums[pos] - nums[u] <= k)
                {
                    sum += 1;
                    k = k - (nums[pos] - nums[u]);
                }
                else break;
            }
            return sum;
        }
    }
}