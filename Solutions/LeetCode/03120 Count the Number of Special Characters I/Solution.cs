// Count the Number of Special Characters I


using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CounttheNumberofSpecialCharactersI
{
    public class Solution
    {
        public static int NumberOfSpecialChars(string word)
        {
            var set = new HashSet<char>(word.ToCharArray());
            var result = 0;

            foreach (char ch in set)
            {
                if (char.IsLower(ch) && set.Contains(char.ToUpper(ch))) result++;
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
                ResultTester.CheckResult<int>(Solution.NumberOfSpecialChars("aaAbcBC"), 3),
                ResultTester.CheckResult<int>(Solution.NumberOfSpecialChars("abc"), 0),
                ResultTester.CheckResult<int>(Solution.NumberOfSpecialChars("abBCab"), 1),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("3120");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}