// Lexicographically Smallest Palindromic Permutation Greater Than Target
namespace CompetitiveProgramming.LeetCode.LexicographicallySmallestPalindromicPermutationGreaterThanTarget;

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string LexPalindromicPermutation(string s, string target)
    {
        int n = s.Length;
        if (n == 1) return string.Compare(s, target) > 0 ? s : "";
        int[] count = new int[26];
        foreach (char c in s) count[c - 'a']++;
        string oddChar = "";
        StringBuilder prefix = new StringBuilder();

        for (int i = 0; i < 26; i++)
        {
            if (count[i] % 2 == 1)
            {
                if (oddChar != "") return "";
                oddChar = ((char)('a' + i)).ToString();
            }
            count[i] /= 2;
        }

        for (int i = 0; i < n / 2; i++)
        {
            bool found = false;
            for (int j = 0; j < 26; j++)
            {
                if (count[j] == 0) continue;
                count[j]--;
                if (Check(prefix.ToString(), (char)('a' + j), count, oddChar, target))
                {
                    prefix.Append((char)('a' + j));
                    found = true;
                    break;
                }
                else count[j]++;
            }

            if (!found) return "";
            if (prefix[i] > target[i])
            {
                StringBuilder left = new StringBuilder(prefix.ToString());
                for (int j = 0; j < 26; j++)
                    left.Append(new string((char)('a' + j), count[j]));
                char[] leftArr = left.ToString().ToCharArray();
                Array.Reverse(leftArr);
                return left.ToString() + oddChar + new string(leftArr);
            }
        }

        char[] prefixArr = prefix.ToString().ToCharArray();
        Array.Reverse(prefixArr);
        return prefix.ToString() + oddChar + new string(prefixArr);
    }

    private bool Check(string prefix, char c, int[] count, string oddChar, string target)
    {
        StringBuilder left = new StringBuilder(prefix);
        left.Append(c);
        for (int i = 25; i >= 0; i--)
            left.Append(new string((char)('a' + i), count[i]));

        char[] leftArr = left.ToString().ToCharArray();
        Array.Reverse(leftArr);
        string palindrome = left.ToString() + oddChar + new string(leftArr);

        return string.Compare(palindrome, target) > 0;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.LexPalindromicPermutation("baba", "abba"), "baab"),
            ResultTester.CheckResult<string>(solution.LexPalindromicPermutation("baba", "bbaa"), ""),
            ResultTester.CheckResult<string>(solution.LexPalindromicPermutation("abc", "abb"), ""),
            ResultTester.CheckResult<string>(solution.LexPalindromicPermutation("aac", "abb"), "aca"),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Lexicographically Smallest Palindromic Permutation Greater Than Target");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}