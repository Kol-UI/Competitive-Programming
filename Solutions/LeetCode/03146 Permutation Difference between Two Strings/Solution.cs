// Permutation Difference between Two Strings

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.PermutationDifferencebetweenTwoStrings
{
    public class Solution
    {
        public int FindPermutationDifference(string s, string t)
        {
            var charPositions = GetCharPositions(s);
            int differenceSum = 0;

            for (int i = 0; i < t.Length; i++)
            {
                differenceSum += Math.Abs(charPositions[t[i]] - i);
            }

            return differenceSum;
        }

        private Dictionary<char, int> GetCharPositions(string s)
        {
            var positions = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                positions[s[i]] = i;
            }

            return positions;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Permutation Difference between Two Strings");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}