// Rotate String

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RotateString
{
    public class Solution
    {
        public bool RotateString(string s, string goal)
        {
            if (s.Length != goal.Length)
            {
                return false;
            }
            string concatenated = s + s;
            return concatenated.Contains(goal);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(solution.RotateString("abcde", "cdeab"), true),
                ResultTester.CheckResult<bool>(solution.RotateString("abcde", "abced"), false)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Rotate String");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}