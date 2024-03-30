// Subarrays with K Different Integers



using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SubarrayswithKDifferentIntegers
{
    public class Solution
    {
        public static int Check(int[] nums, Dictionary<int, int> d, int start, int k)
        {
            Dictionary<int, int> dict = new (d);
            int count = 0;
            while (dict.Count == k)
            {
                count++;
                dict[nums[start]]--;
                if (dict[nums[start]] == 0)
                {
                    dict.Remove(nums[start]);
                }
                start++;
            }
            return count;
        }
        
        public static int SubarraysWithKDistinct(int[] nums, int k)
        {
            int count = 0;
            int start = 0;
            Dictionary<int, int> m = new ();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!m.ContainsKey(nums[i]))
                {
                    m[nums[i]] = 0;
                }
                m[nums[i]]++;
                if (m.Count == k)
                {
                    count += Check(nums, m, start, k);
                }
                else if (m.Count > k)
                {
                    while (m.Count > k)
                    {
                        m[nums[start]]--;
                        if (m[nums[start]] == 0)
                        {
                            m.Remove(nums[start]);
                        }
                        start++;
                    }
                    count += Check(nums, m, start, k);
                }
            }
            return count;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.SubarraysWithKDistinct(new int[]{1,2,1,2,3}, 2), 7),
                ResultTester.CheckResult<int>(Solution.SubarraysWithKDistinct(new int[]{1,2,1,3,4}, 3), 3),
            };
            return results;
        }
    }
}