// Minimum Sum of Four Digit Number After Splitting Digits

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumSumofFourDigitNumberAfterSplittingDigits
{
    public class Solution
    {
        public static int MinimumSum(int num)
        {
            var sortedDigits = num.ToString().OrderBy(x => x).Select(x => x - '0').ToArray();
            var num1 = sortedDigits[0] * 10 + sortedDigits[2];
            var num2 = sortedDigits[1] * 10 + sortedDigits[3];

            return num1 + num2;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinimumSum(2932), 52),
                ResultTester.CheckResult<int>(Solution.MinimumSum(4009), 13),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Sum of Four Digit Number After Splitting Digits");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}