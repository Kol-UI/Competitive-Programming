// Find the Original Typed String I

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindtheOriginalTypedStringI
{
    public class Solution
    {
        public int PossibleStringCount(string word) => 1 + word.Skip(1).Zip(word).Count(p => p.First == p.Second);
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.PossibleStringCount("abbcccc"), 5),
                ResultTester.CheckResult<int>(solution.PossibleStringCount("abcd"), 1),
                ResultTester.CheckResult<int>(solution.PossibleStringCount("aaaa"), 4)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Original Typed String I");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}