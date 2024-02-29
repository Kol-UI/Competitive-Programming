// Largest Positive Integer That Exists With Its Negative


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LargestPositiveIntegerThatExistsWithItsNegative
{
    public class Solution
    {
        public static int FindMaxK(int[] nums)
        {
            Array.Sort(nums);
            int result = -1;

            for (int i = nums.Length-1; i > 0;i--)
            {
                for (int j = 0 ; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j]==0)
                    {
                        result = Math.Max(nums[i], nums[j]);
                        break;
                    }
                }
                if(result>0)
                {
                    break;
                }
            }
            
            return result;

        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.FindMaxK(new int[]{-1,2,-3,3}), 3),
                ResultTester.CheckResult<int>(Solution.FindMaxK(new int[]{-1,10,6,7,-7,1}), 7),
                ResultTester.CheckResult<int>(Solution.FindMaxK(new int[]{-10,8,6,7,-2,-3}), -1),
            };
            return results;
        }
    }
}