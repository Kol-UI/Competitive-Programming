// Ant on the Boundary


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.AntontheBoundary
{
    public class Solution
    {
        public static int ReturnToBoundaryCount(int[] nums)
        {
            var result = 0;
            var sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum == 0) result++;
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
                ResultTester.CheckResult<int>(Solution.ReturnToBoundaryCount(new int[]{2,3,-5}), 1),
                ResultTester.CheckResult<int>(Solution.ReturnToBoundaryCount(new int[]{3,2,-3,-4}), 0),
            };

            return results;
        }
    }
}