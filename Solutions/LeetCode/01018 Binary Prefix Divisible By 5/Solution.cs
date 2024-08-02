// Binary Prefix Divisible By 5


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BinaryPrefixDivisibleByFive
{
    public class Solution
    {
        public static IList<bool> PrefixesDivBy5(int[] nums)
        {
            var result = new List<bool>();
            var num = 0;
            foreach (var n in nums)
            {
                num = (num * 2 + n) % 5;
                result.Add(num == 0);
            }

            return result;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Binary prefix Divisible By 5");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}