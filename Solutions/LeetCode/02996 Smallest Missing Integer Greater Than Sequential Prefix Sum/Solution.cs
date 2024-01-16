// Smallest Missing Integer Greater Than Sequential Prefix Sum


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.SmallestMissingIntegerGreaterThanSequentialPrefixSum
{
    public class Solution
    {
        public static int MissingInteger(int[] nums) 
        {
            var maxSum = nums[0];

            for(var i = 1; i < nums.Length && nums[i]-1 == nums[i-1]; i++)
                maxSum += nums[i];

            var hash = new HashSet<int>(nums);

            while(hash.Contains(maxSum)) maxSum++;

            return maxSum;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MissingInteger(new int[] {1,2,3,2,5}), 6),
                ResultTester.CheckResult<int>(Solution.MissingInteger(new int[] {3,4,5,1,12,14,13}), 15),
            };
            return results;
        }
    }
}