// Difference Between Element Sum and Digit Sum of an Array


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.DifferenceBetweenElementSumandDigitSumofanArray
{
    public class Solution
    {
        public static int DifferenceOfSum(int[] nums)
        {
            int sum1 = 0;
            int sum2 = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum1 += nums[i];

                while(nums[i] != 0)
                {
                    sum2 += nums[i] % 10;
                    nums[i] /= 10;
                }
            }
            return Math.Abs(sum1 - sum2);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.DifferenceOfSum(new int[]{1,15,6,3}), 9),
                ResultTester.CheckResult<int>(Solution.DifferenceOfSum(new int[]{1,2,3,4}), 0),
            };

            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2535");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}