// Make Array Zero by Subtracting Equal Amounts


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MakeArrayZerobySubtractingEqualAmounts
{
    public class Solution
    {
        public static int MinimumOperations(int[] nums)
        {
            return nums.Distinct().Count(x => x != 0);
        }
    }
    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinimumOperations(new int[]{1,5,0,3,5}), 3),
                ResultTester.CheckResult<int>(Solution.MinimumOperations(new int[]{0}), 0),
            };
            return results;
        }
    }
}