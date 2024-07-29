// Find if Digit Game Can Be Won

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindifDigitGameCanBeWon
{
    public class Solution
    {
        public bool CanAliceWin(int[] numbers)
        {
            int smallSum = 0;
            int largeSum = 0;

            foreach (var number in numbers)
            {
                if (number < 10)
                {
                    smallSum += number;
                }
                else
                {
                    largeSum += number;
                }
            }

            return smallSum != largeSum;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find if Digit Game Can Be Won");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}