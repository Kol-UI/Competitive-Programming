// Lexicographically Smallest Palindrome


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.LexicographicallySmallestPalindrome
{
    public class Solution
    {
        public static string MakeSmallestPalindrome(string s)
        {
            char[] Arrchar = s.ToArray();

            for (int i = 0, j = s.Length - 1; j >= s.Length / 2; j--, i++)
            {
                if (s[i] != s[j])
                {
                    if (s[i] < s[j])
                    {
                        Arrchar[j] = s[i];

                        continue;
                    }

                    Arrchar[i] = s[j];
                }
            }

            return new string(Arrchar);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.MakeSmallestPalindrome("egcfe"), "efcfe"),
                ResultTester.CheckResult<string>(Solution.MakeSmallestPalindrome("abcd"), "abba"),
                ResultTester.CheckResult<string>(Solution.MakeSmallestPalindrome("seven"), "neven"),
            };
            return results;
        }
    }
}