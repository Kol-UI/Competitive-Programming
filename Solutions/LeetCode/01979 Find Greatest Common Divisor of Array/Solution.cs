// Find Greatest Common Divisor of Array

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindGreatestCommonDivisorofArray
{
    public class Solution
    {
        public int FindGCD(int[] nums)
        {
            int minValue = nums.Min();
            int maxValue = nums.Max();
            return CalculateGCD(minValue, maxValue);
        }

        private int CalculateGCD(int a, int b)
        {
            return b % a == 0 ? a : CalculateGCD(b % a, a);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Greatest Common Divisor of Array");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}