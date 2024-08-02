// Sum of All Subset XOR Totals


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SumofAllSubsetXORTotals
{
    public class Solution
    {
        public static int SubsetXORSum(int[] nums)
        {
            int value = 0;

            foreach (int num in nums)
            {
                value |= num;
            }

            return value << (nums.Length - 1);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.SubsetXORSum(new int[]{1,3}), 6),
                ResultTester.CheckResult<int>(Solution.SubsetXORSum(new int[]{5,1,6}), 28),
                ResultTester.CheckResult<int>(Solution.SubsetXORSum(new int[]{3,4,5,6,7,8}), 480),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Sum of All Subset XOR Totals");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}