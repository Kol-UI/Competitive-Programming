// Valid Word

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ValidWord
{
    public class Solution
    {
        public bool IsValid(string word)
        {
            if (word.Length < 3) return false;

            bool hasDigitOrLetter = false;
            bool hasVowel = false;
            bool hasConsonant = false;

            foreach (char ch in word)
            {
                if (IsSpecialCharacter(ch)) return false;

                if (char.IsLetterOrDigit(ch))
                {
                    hasDigitOrLetter = true;

                    if (IsVowel(ch)) hasVowel = true;
                    else if (char.IsLetter(ch)) hasConsonant = true;
                }
            }

            return hasDigitOrLetter && hasVowel && hasConsonant;
        }

        private bool IsSpecialCharacter(char ch)
        {
            return ch == '@' || ch == '#' || ch == '$';
        }

        private bool IsVowel(char ch)
        {
            return "aeiouAEIOU".IndexOf(ch) >= 0;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Valid Word");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}