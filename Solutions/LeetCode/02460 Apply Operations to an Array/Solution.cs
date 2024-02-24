// Apply Operations to an Array


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ApplyOperationstoanArray
{
    public class Solution
    {
        public static int[] ApplyOperations(int[] nums)
        {
            int[] array = new int[nums.Length];
            int counter = 0;
            int i = 0;

            for(i = 0; i < nums.Length - 1; i++)
            {
                if(nums[i] == nums[i+1])
                {
                    array[counter] = nums[i] + nums[i+1];
                    counter++;
                    i += 1; 
                }

                else
                {
                    array[counter] = nums[i];
                    counter++;
                }
            }

            while(i < nums.Length)
            {
                array[counter] = nums[i];
                i++;
            }

            i = 0;
            counter = 0;

            for(i = 0; i < array.Length; i++)
            {
                if(array[i] != 0)
                {
                    (array[counter],array[i]) = (array[i],array[counter]);
                    counter++;
                }
            }

            return array;
            
        }
    }

    public class Test
    {

        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.ApplyOperations(new int[]{1,2,2,1,1,0}), new int[]{1,4,2,0,0,0}),
                ResultTester.CheckResult<int[]>(Solution.ApplyOperations(new int[]{0,1}), new int[]{1,0}),
            };
            return results;
        }
    }
}