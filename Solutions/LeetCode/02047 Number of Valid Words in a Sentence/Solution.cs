// Number of Valid Words in a Sentence

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofValidWordsinaSentence
{
    public class Solution
    {
        public int CountValidWords(string sentence)
        {
            string[] words = sentence.Split();
            int validWordCount = 0;

            foreach (string word in words)
            {
                if (IsValidWord(word))
                {
                    validWordCount++;
                }
            }

            return validWordCount;
        }

        private bool IsValidWord(string word)
        {
            word = word.Trim();
            if (string.IsNullOrEmpty(word))
            {
                return false;
            }

            int hyphenCount = 0;
            for (int i = 0; i < word.Length; i++)
            {
                char currentChar = word[i];

                if (char.IsDigit(currentChar))
                {
                    return false;
                }

                if (currentChar == '-')
                {
                    if (IsInvalidHyphenPlacement(word, i, ref hyphenCount))
                    {
                        return false;
                    }
                }

                if (IsInvalidPunctuationPlacement(currentChar, i, word.Length))
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsInvalidHyphenPlacement(string word, int index, ref int hyphenCount)
        {
            if (hyphenCount > 0 || index == 0 || index == word.Length - 1)
            {
                return true;
            }

            char leftChar = word[index - 1];
            char rightChar = word[index + 1];

            if (!char.IsLetter(leftChar) || !char.IsLetter(rightChar))
            {
                return true;
            }

            hyphenCount++;
            return false;
        }

        private bool IsInvalidPunctuationPlacement(char currentChar, int index, int wordLength)
        {
            if ((currentChar == '.' || currentChar == ',' || currentChar == '!') && index != wordLength - 1)
            {
                return true;
            }

            return false;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Valid Words in a Sentence");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}