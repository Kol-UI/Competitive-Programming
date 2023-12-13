// Maximum Product of Two Elements in an Array



using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumProductofTwoElementsinanArray
{
    public class Solution
    {
        public static int MaxProduct(int[] nums)
        {
            int max1 = 0;
            int max2 = 0;

            foreach (var num in nums)
            {
                if (num > max1)
                {
                    max2 = max1;
                    max1 = num;
                }
                else if (num > max2)
                {
                    max2 = num;
                }
            }

            return (max1 - 1) * (max2 - 1);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1 = {3,4,5,2};
            int[] nums2 = {1,5,4,5};
            int[] nums3 = {3,7};
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MaxProduct(nums1), 12),
                ResultTester.CheckResult<int>(Solution.MaxProduct(nums2), 16),
                ResultTester.CheckResult<int>(Solution.MaxProduct(nums3), 12),
            };
            return results;
        }
    }
}