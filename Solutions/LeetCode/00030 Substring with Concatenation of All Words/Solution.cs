// Substring with Concatenation of All Words
namespace CompetitiveProgramming.LeetCode.SubstringwithConcatenationofAllWords;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public IList<int> FindSubstring(string s, string[] words)
    {
        List<int> result = [];
        Dictionary<string, int> wordHash = [];
        int wordLength = words[0].Length;
        int wordsCount = words.Length;
        if (string.IsNullOrEmpty(s) || wordsCount == 0 || wordLength == 0) return result;

        foreach (var w in words)
        {
            wordHash[w] = wordHash.ContainsKey(w) ? wordHash[w] + 1 : 1;
        }

        for (int i = 0; i < wordLength; i++)
        {
            int left = i;
            int count = 0;
            Dictionary<string, int> seen = [];

            for (int right = left; right <= s.Length - wordLength; right += wordLength)
            {
                string word = s.Substring(right, wordLength);
                if (wordHash.ContainsKey(word))
                {
                    seen[word] = seen.ContainsKey(word) ? seen[word] + 1 : 1;
                    count++;
                    while (seen[word] > wordHash[word])
                    {
                        string leftWord = s.Substring(left, wordLength);
                        seen[leftWord]--;
                        count--;
                        left += wordLength;
                    }
                    if (count == words.Length)
                    {
                        result.Add(left);
                    }
                }
                else
                {
                    left = right + wordLength;
                    seen.Clear();
                    count = 0;
                }
            }
        }

        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<IList<int>>(solution.FindSubstring("barfoothefoobarman", ["foo","bar"]), [0,9]),
            ResultTester.CheckResult<IList<int>>(solution.FindSubstring("wordgoodgoodgoodbestword", ["word","good","best","word"]), []),
            ResultTester.CheckResult<IList<int>>(solution.FindSubstring("barfoofoobarthefoobarman", ["bar","foo","the"]), [6,9,12]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Substring with Concatenation of All Words");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}