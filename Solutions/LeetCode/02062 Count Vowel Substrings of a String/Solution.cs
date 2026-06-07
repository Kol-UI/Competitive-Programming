// Count Vowel Substrings of a String
namespace CompetitiveProgramming.LeetCode.CountVowelSubstringsofaString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountVowelSubstrings(string word)
    {
        int result = 0;
        string v = "aeiou";
        HashSet<char> hs = [];

        for (int i = 0; i < word.Length; i++)
        {

            if (!v.Contains(word[i]))
            {
                continue;
            }

            hs.Clear();
            hs.Add(word[i]);
            for (int j = i + 1; j < word.Length; j++)
            {

                if (!v.Contains(word[j]))
                {
                    break;
                }

                hs.Add(word[j]);

                if (hs.Count >= 5)
                {
                    result += 1;
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
            ResultTester.CheckResult<int>(solution.CountVowelSubstrings("aeiouu"), 2),
            ResultTester.CheckResult<int>(solution.CountVowelSubstrings("unicornarihan"), 0),
            ResultTester.CheckResult<int>(solution.CountVowelSubstrings("cuaieuouac"), 7),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Vowel Substrings of a String");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}