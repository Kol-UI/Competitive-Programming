// Sort Array By Parity


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SortArrayByParity
{
    public class Solution
    {
        public static int[] SortArrayByParity(int[] nums)
        {
            int i = 0, j = nums.Length - 1;
            
            while (i < j)
            {
                while (i < j && nums[i] % 2 == 0)
                {
                    i++;
                }
                
                while (i < j && nums[j] % 2 == 1)
                {
                    j--;
                }
                
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
            
            return nums;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] case1 = {3,1,2,4};
            int[] case2 = {0};
            int[] result1 = {4,2,1,3};
            int[] result2 = {0};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.SortArrayByParity(case1), result1),
                ResultTester.CheckResult<int[]>(Solution.SortArrayByParity(case2), result2),
            };
            return results;
        }
    }
}