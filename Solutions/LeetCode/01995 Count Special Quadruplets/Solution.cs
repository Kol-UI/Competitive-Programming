// Count Special Quadruplets


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CountSpecialQuadruplets
{
    public class Solution
    {
        public static int CountQuadruplets(int[] nums)
        {
            int count = 0;
            for(int i = 0; i < nums.Length - 3; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    for(int k = j + 1; k < nums.Length; k++)
                    {
                        for(int l = k + 1 ; l < nums.Length; l++)
                        {
                            if(nums[i] + nums[j] + nums[k] == nums[l])
                            {
                                count++;
                            }
                        }
                    } 
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
                ResultTester.CheckResult<int>(Solution.CountQuadruplets(new int[]{1,2,3,6}), 1),
                ResultTester.CheckResult<int>(Solution.CountQuadruplets(new int[]{3,3,6,4,5}), 0),
                ResultTester.CheckResult<int>(Solution.CountQuadruplets(new int[]{1,1,1,3,5}), 4),
            };
            return results;
        }
    }
}