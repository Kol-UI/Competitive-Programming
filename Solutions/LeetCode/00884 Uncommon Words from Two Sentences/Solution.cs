// Uncommon Words from Two Sentences

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.UncommonWordsfromTwoSentences
{
    public class Solution
    {
        public string[] UncommonFromSentences(string s1, string s2)
        {
            var words1 = SplitSentenceIntoWords(s1);
            var words2 = SplitSentenceIntoWords(s2);

            var wordCount = CountWordOccurrences(words1, words2);

            var uncommonWords = FindWordsWithSingleOccurrence(wordCount);

            return uncommonWords.ToArray();
        }

        private List<string> SplitSentenceIntoWords(string sentence)
        {
            return sentence.Split(' ').ToList();
        }

        private Dictionary<string, int> CountWordOccurrences(List<string> words1, List<string> words2)
        {
            var wordCount = new Dictionary<string, int>();

            AddWordsToDictionary(wordCount, words1);
            AddWordsToDictionary(wordCount, words2);

            return wordCount;
        }

        private void AddWordsToDictionary(Dictionary<string, int> wordCount, List<string> words)
        {
            foreach (var word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }
        }

        private List<string> FindWordsWithSingleOccurrence(Dictionary<string, int> wordCount)
        {
            return wordCount.Where(pair => pair.Value == 1).Select(pair => pair.Key).ToList();
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Uncommon Words from Two Sentences");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}