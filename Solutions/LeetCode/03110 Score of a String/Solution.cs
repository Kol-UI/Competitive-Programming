// Score of a String

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ScoreofaString
{
    public class Solution
    {
        public static int ScoreOfString(string s)
        {
            var score = 0;
            
            for (var i = 1; i < s.Length; i++)
            {
                score += Math.Abs(s[i] - s[i - 1]);
            }

            return score;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.ScoreOfString("hello"), 13),
                ResultTester.CheckResult<int>(Solution.ScoreOfString("zaz"), 50),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Score of a String");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}