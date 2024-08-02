// Average Value of Even Numbers That Are Divisible by Three


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.AverageValueofEvenNumbersThatAreDivisiblebyThree
{
    public class Solution
    {
        public static int AverageValue(int[] nums)
        {
            var ints = nums.Where(x => x % 2 == 0 && x % 3 == 0);
            return ints.Any() ? (int) ints.Average() : 0;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.AverageValue(new int[]{1,3,6,10,12,15}), 9),
                ResultTester.CheckResult<int>(Solution.AverageValue(new int[]{1,2,4,7,10}), 0),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Average Value of Even Numbers That Are Divisible by Three");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}