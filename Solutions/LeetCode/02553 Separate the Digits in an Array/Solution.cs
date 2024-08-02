// Separate the Digits in an Array

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.SeparatetheDigitsinanArray
{
    public class Solution
    {
        public static int[] SeparateDigits(int[] nums)
        {
            static IEnumerable<int> Digits(int value)
            {
                for (; value > 0; value /= 10)
                    yield return value % 10;
            }    

            return nums
                .SelectMany(item => Digits(item).Reverse())
                .ToArray();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.SeparateDigits(new int[]{13,25,83,77}), new int[]{1,3,2,5,8,3,7,7}),
                ResultTester.CheckResult<int[]>(Solution.SeparateDigits(new int[]{7,1,3,9}), new int[]{7,1,3,9}),
            };

            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2553");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}