// Length of Longest Subarray With at Most K Frequency


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LengthofLongestSubarrayWithatMostKFrequency
{
    public class Solution
    {
        public static int MaxSubarrayLength(int[] nums, int k)
        {
            int ans = 0;
            int start = 0;
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            for (int end = 0; end < nums.Length; end++)
            {
                int num = nums[end];
                if (!frequency.ContainsKey(num))
                    frequency[num] = 0;
                frequency[num]++;

                while (frequency.ContainsKey(num) && frequency[num] > k)
                {
                    int leftNum = nums[start];
                    frequency[leftNum]--;
                    if (frequency[leftNum] == 0)
                        frequency.Remove(leftNum);
                    start++;
                }

                ans = Math.Max(ans, end - start + 1);
            }

            return ans;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MaxSubarrayLength(new int[]{1,2,3,1,2,3,1,2}, 2), 6),
                ResultTester.CheckResult<int>(Solution.MaxSubarrayLength(new int[]{1,2,1,2,1,2,1,2}, 1), 2),
                ResultTester.CheckResult<int>(Solution.MaxSubarrayLength(new int[]{5,5,5,5,5,5,5}, 4), 4),
            };
            return results;
        }
    }
}