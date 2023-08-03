using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SingleNumber
{
	public class Solution
	{
        //Given a non-empty array of integers nums, every element appears twice except for one.Find that single one.
        //You must implement a solution with a linear runtime complexity and use only constant extra space.

        //Example 1:

        //Input: nums = [2, 2, 1]
        //Output: 1

        //Example 2:

        //Input: nums = [4, 1, 2, 1, 2]
        //Output: 4

        //Example 3:

        //Input: nums = [1]
        //Output: 1

        public static int SingleNumber(int[] nums)
        {
            return nums.GroupBy(x => x).Where(x => x.Count() == 1).FirstOrDefault()!.Key;
        }
    }

    public class Test
    {
        public static bool[] TestSingleNumber()
        {
            // Case 1
            int[] numsCase1_136 = { 2, 2, 1 };
            int Case1_136_Result = Solution.SingleNumber(numsCase1_136);

            // Case 2
            int[] numsCase2_136 = { 4, 1, 2, 1, 2 };
            int Case2_136_Result = Solution.SingleNumber(numsCase2_136);

            // Case 3
            int[] numsCase3_136 = { 1 };
            int Case3_136_Result = Solution.SingleNumber(numsCase3_136);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_136_Result, 1),
                ResultTester.CheckResult<int>(Case2_136_Result, 4),
                ResultTester.CheckResult<int>(Case3_136_Result, 1)
            };
            return results;
        }
    }
}

