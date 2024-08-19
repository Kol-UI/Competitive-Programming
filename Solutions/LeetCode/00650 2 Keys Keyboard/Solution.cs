// 2 Keys Keyboard

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.TwoKeysKeyboard
{
    public class Solution
    {
        public static int MinSteps(int n)
        {
            if (n == 1)
            {
                return 0;
            }

            return CalculateMinSteps(1, 1, 1, n);
        }

        private static int CalculateMinSteps(int currentCount, int copiedCount, int currentStep, int target)
        {
            if (currentCount > target)
            {
                return int.MaxValue;
            }

            if (currentCount == target)
            {
                return currentStep;
            }

            return Math.Min(
                CalculateMinSteps(2 * currentCount, currentCount, currentStep + 2, target),
                CalculateMinSteps(currentCount + copiedCount, copiedCount, currentStep + 1, target)
            );
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinSteps(3), 3),
                ResultTester.CheckResult<int>(Solution.MinSteps(1), 0)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("2 Keys Keyboard");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}