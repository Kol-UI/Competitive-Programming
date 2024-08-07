// Reverse Vowels of a String

/*
Given a string s, reverse only all the vowels in the string and return it.

The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.


Example 1:

Input: s = "hello"
Output: "holle"

Example 2:

Input: s = "leetcode"
Output: "leotcede"
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ReverseVowelsofaString
{
    public class Solution
    {
        public static string ReverseVowels(string s)
        {
            var vowels = "aeiouAEIOU";
            var extract = s.Where(c => vowels.Contains(c)).Reverse().ToArray();
            var res = s.ToCharArray();
            int v = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    res[i] = extract[v++];
                }
            }

            return new string(res);
        }
    }

    public class Test
    {
        public static bool[] TestReverseVowelsofaString()
        {
            string Case1_345 = Solution.ReverseVowels("hello");
            string Case2_345 = Solution.ReverseVowels("leetcode");

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Case1_345, "holle"),
                ResultTester.CheckResult<string>(Case2_345, "leotcede")
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse Vowels of a String");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestReverseVowelsofaString());
        }
    }
}