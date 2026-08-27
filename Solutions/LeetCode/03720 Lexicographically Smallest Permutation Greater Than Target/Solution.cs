// Lexicographically Smallest Permutation Greater Than Target
namespace CompetitiveProgramming.LeetCode.LexicographicallySmallestPermutationGreaterThanTarget;

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string LexGreaterPermutation(string s, string target)
    {
        int[] count = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            count[s[i] - 'a']++;
            count[target[i] - 'a']--;
        }

        char[] t = target.ToCharArray();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            int b = t[i] - 'a';
            count[b]++;
            if (count.Min() < 0) continue;
            for (int j = b + 1; j < 26; j++)
            {
                if (count[j] > 0)
                {
                    count[j]--;
                    t[i] = (char)('a' + j);
                    return new string(t, 0, i + 1) + GetMinString(count);
                }
            }
        }

        return "";
    }

    private string GetMinString(int[] count)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < 26; i++)
        {
            result.Append(new string((char)('a' + i), count[i]));
        }
        return result.ToString();
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.LexGreaterPermutation("abc", "bba"), "bca"),
            ResultTester.CheckResult<string>(solution.LexGreaterPermutation("leet", "code"), "eelt"),
            ResultTester.CheckResult<string>(solution.LexGreaterPermutation("baba", "bbaa"), ""),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Lexicographically Smallest Permutation Greater Than Target");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}