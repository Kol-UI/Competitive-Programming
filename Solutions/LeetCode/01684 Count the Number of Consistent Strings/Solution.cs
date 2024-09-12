// Count the Number of Consistent Strings

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CounttheNumberofConsistentStrings
{
    public class Solution
    {
        public int CountConsistentStrings(string allowed, string[] words)
        {
            var allowedSet = CreateCharacterSet(allowed);
            return words.Count(word => IsStringContainsChar(word, allowedSet));
        }

        private static HashSet<char> CreateCharacterSet(string allowed)
        {
            return new HashSet<char>(allowed);
        }

        private static bool IsStringContainsChar(string word, HashSet<char> allowedSet)
        {
            return word.All(character => allowedSet.Contains(character));
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new Solution();

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.CountConsistentStrings("ab", new string[]{"ad","bd","aaab","baa","badab"}), 2),
                ResultTester.CheckResult<int>(solution.CountConsistentStrings("abc", new string[]{"a","b","c","ab","ac","bc","abc"}), 7),
                ResultTester.CheckResult<int>(solution.CountConsistentStrings("cad", new string[]{"cc","acd","b","ba","bac","bad","ac","d"}), 4),
            };

            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count the Number of Consistent Strings");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}