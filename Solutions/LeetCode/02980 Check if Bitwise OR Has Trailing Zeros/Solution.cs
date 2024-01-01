// Check if Bitwise OR Has Trailing Zeros




using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.CheckifBitwiseORHasTrailingZeros
{
    public class Solution
    {
        public static bool HasTrailingZeros(int[] nums)
        {
            int count = 0;
            for(int i = 0; i < nums.Length ; i++)
            {
                
                if(HasTrailingZero(nums[i]))
                {
                    count++;
                }
                
                if(count >= 2)
                {
                    return true;
                }
            }
            
            return false;
        }
        
        private static bool HasTrailingZero(int num)
        {
            return (num & 1) == 0;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.HasTrailingZeros(new int[]{1,2,3,4,5}), true),
                ResultTester.CheckResult<bool>(Solution.HasTrailingZeros(new int[]{2,4,8,16}), true),
                ResultTester.CheckResult<bool>(Solution.HasTrailingZeros(new int[]{1,3,5,7,9}), false),
            };
            return results;
        }
    }
}