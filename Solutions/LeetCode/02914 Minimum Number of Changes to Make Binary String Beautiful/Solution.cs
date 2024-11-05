// Minimum Number of Changes to Make Binary String Beautiful

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumNumberofChangestoMakeBinaryStringBeautiful
{
    public class Solution
    {
        public int MinChanges(string s)
        {
            int countChanges = 0;
            for (int i = 0; i < s.Length; i += 2)
            {
                if (s[i] != s[i + 1])
                {
                    countChanges++;
                }
            }
            return countChanges;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.MinChanges("1001"), 2),
                ResultTester.CheckResult<int>(solution.MinChanges("10"), 1),
                ResultTester.CheckResult<int>(solution.MinChanges("0000"), 0)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Number of Changes to Make Binary String Beautiful");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}