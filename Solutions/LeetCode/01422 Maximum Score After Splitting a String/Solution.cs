// Maximum Score After Splitting a String




using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MaximumScoreAfterSplittingaString
{
    public class Solution
    {
        public static int MaxScore(string s)
        {
            int currentLeftSide = s[0]=='0' ? 1 : 0;
            int currentRightSide = 0;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == '1')
                {
                    currentRightSide++;
                }
            }
            int result = currentLeftSide + currentRightSide;

            for (int i = 1; i < s.Length-1; i++)
            {
                if (s[i] == '0')
                {
                    currentLeftSide++;
                }
                else if (s[i] == '1')
                {
                    currentRightSide--;
                }

                if(currentLeftSide+currentRightSide>result)
                {
                    result = currentLeftSide + currentRightSide;
                }
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
                ResultTester.CheckResult<int>(Solution.MaxScore("011101"), 5),
                ResultTester.CheckResult<int>(Solution.MaxScore("00111"), 5),
                ResultTester.CheckResult<int>(Solution.MaxScore("1111"), 3),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1422");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}