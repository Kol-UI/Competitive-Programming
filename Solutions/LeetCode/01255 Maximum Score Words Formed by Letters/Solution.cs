//Maximum Score Words Formed by Letters



using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MaximumScoreWordsFormedbyLetters
{
    public class Solution
    {
        private int backtrack(int start, int[] availableLetters, string[] words, int[] score)
        {
            if (start == words.Length) return 0;
            int wordScore = 0;
            for (int k = 0; k < words[start].Length; k++)
            {
                char letter = words[start][k];
                if (availableLetters[letter - 'a'] == 0)
                {
                    for (int j = 0; j < k; j++) availableLetters[words[start][j] - 'a']++;
                    return 0;
                }
                wordScore += score[letter - 'a'];
                availableLetters[letter - 'a']--;
            }
            int result = 0;
            for (int k = start; k < words.Length; k++) result = Math.Max(result, backtrack(k + 1, availableLetters, words, score));
            for (int k = 0; k < words[start].Length; k++) availableLetters[words[start][k] - 'a']++;
            return wordScore + result;
        }

        public int MaxScoreWords(string[] words, char[] letters, int[] score)
        {
            int[] lettersFreq = new int[26];
            for (int k = 0; k < letters.Length; k++) lettersFreq[letters[k] - 'a']++;
            int result = 0;
            for (int k = 0; k < words.Length; k++) result = Math.Max(result, backtrack(k, lettersFreq, words, score));
            return result;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("1255");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
        }
    }
}