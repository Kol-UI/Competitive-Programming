// Minimize String Length


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MinimizeStringLength
{
    public class Solution
    {
        public static int MinimizedStringLength(string s)
        {
            return s.ToHashSet().Count;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinimizedStringLength("aaabc"), 3),
                ResultTester.CheckResult<int>(Solution.MinimizedStringLength("cbbd"), 3),
                ResultTester.CheckResult<int>(Solution.MinimizedStringLength("dddaaa"), 2),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2716");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}