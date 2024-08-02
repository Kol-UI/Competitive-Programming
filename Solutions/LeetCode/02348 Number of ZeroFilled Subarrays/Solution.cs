using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofZeroFilledSubarrays
{
    /*
        Given an integer array nums, return the number of subarrays filled with 0.

        A subarray is a contiguous non-empty sequence of elements within an array.

        Example 1:
        Input: nums = [1,3,0,0,2,0,0,4]
        Output: 6
        Explanation: 
        There are 4 occurrences of [0] as a subarray.
        There are 2 occurrences of [0,0] as a subarray.
        There is no occurrence of a subarray with a size more than 2 filled with 0. Therefore, we return 6.
        
        Example 2:
        Input: nums = [0,0,0,2,0,0]
        Output: 9
        Explanation:
        There are 5 occurrences of [0] as a subarray.
        There are 3 occurrences of [0,0] as a subarray.
        There is 1 occurrence of [0,0,0] as a subarray.
        There is no occurrence of a subarray with a size more than 3 filled with 0. Therefore, we return 9.
        Example 3:

        Input: nums = [2,10,2019]
        Output: 0
        Explanation: There is no subarray filled with 0. Therefore, we return 0.
    */

    public class Solution
    {
        public static long ZeroFilledSubarray(int[] nums)
        {
            long ans = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                int j = i;
                while(j < nums.Length && nums[j] == 0)j++;
                int len = j - i;
                ans += SequanceSum(len);
                i = j;
            }
            return ans;
        }

        private static long SequanceSum(int n)
        {
            return ((long)n*(long)(n+1))/(long)2;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Case 1
            int[] arrayCase1_2348 = { 1, 3, 0, 0, 2, 0, 0, 4 };
            long case1_2348Result = Solution.ZeroFilledSubarray(arrayCase1_2348);

            // Case 2
            int[] arrayCase2_2348 = { 0, 0, 0, 2, 0, 0 };
            long case2_2348Result = Solution.ZeroFilledSubarray(arrayCase2_2348);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(case1_2348Result, 6),
                ResultTester.CheckResult<long>(case2_2348Result, 9)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Number of ZeroFilled Subarrays");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}