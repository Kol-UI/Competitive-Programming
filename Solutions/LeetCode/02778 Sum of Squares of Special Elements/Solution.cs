// Sum of Squares of Special Elements 


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.SumofSquaresofSpecialElements
{
    public class Solution
    {
        public static int SumOfSquares(int[] nums) => nums.Where((item, index) => nums.Length % (index + 1) == 0).Sum(item => item * item);
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.SumOfSquares(new int[] {1,2,3,4}), 21),
                ResultTester.CheckResult<int>(Solution.SumOfSquares(new int[] {2,7,1,19,18,3}), 63),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2778");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}