// Separate Black and White Balls

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SeparateBlackandWhiteBalls
{
    public class Solution
    {
        public long MinimumSteps(string s)
        {
            long result = 0;
            long ones = 0;

            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1') ones++;
                else result += ones;
            }
            return result;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Separate Black and White Balls");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}