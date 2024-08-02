// Make The String Great


using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MakeTheStringGreat
{
    public class Solution
    {
        public static string MakeGood(string s)
        {
            var sb = new StringBuilder();
            foreach (var c in s)
                if (sb.Length > 0 && Math.Abs(sb[^1]-c) == 32)
                        sb.Length--;
                    else
                        sb.Append(c);
            return sb.ToString();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.MakeGood("leEeetcode"), "leetcode"),
                ResultTester.CheckResult<string>(Solution.MakeGood("abBAcC"), ""),
                ResultTester.CheckResult<string>(Solution.MakeGood("s"), "s"),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1544");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}