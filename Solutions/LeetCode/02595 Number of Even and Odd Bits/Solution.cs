// Number of Even and Odd Bits


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.NumberofEvenandOddBits
{
    public class Solution
    {
        public static int[] EvenOddBit(int n)
        {
            var result = new int[2];
            var count = 0;

            while (n != 0)
            {
                result[count++ % 2] += n & 1;
                n >>= 1;
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
                ResultTester.CheckResult<int[]>(Solution.EvenOddBit(17), new int[]{2,0}),
                ResultTester.CheckResult<int[]>(Solution.EvenOddBit(2), new int[]{0,1}),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Number of Even and Off Bits");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}