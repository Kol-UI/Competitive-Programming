// Shortest Completing Word
namespace CompetitiveProgramming.LeetCode.ShortestCompletingWord;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string ShortestCompletingWord(string licensePlate, string[] words)
    {
        var target = CountWord(licensePlate.ToLower());
        var result = string.Empty;
        foreach (var word in words)
        {
            if (word.Length < result.Length || result.Length == 0)
            {
                var current = CountWord(word);
                var match = true;
                for (int i = 0; i < 26; i++)
                {
                    if (current[i] < target[i])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                    result = word;
            }
        }

        return result;
    }

    private int[] CountWord(string word)
    {
        var count = new int[26];
        foreach (var ch in word)
            if (char.IsLetter(ch)) count[ch - 'a']++;

        return count;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.ShortestCompletingWord("1s3 PSt",["step","steps","stripe","stepple"]), "steps"),
            ResultTester.CheckResult<string>(solution.ShortestCompletingWord("1s3 456",["looks","pest","stew","show"]), "pest"),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Shortest Completing Word");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}