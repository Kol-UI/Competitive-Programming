using System;
using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindAllAnagramsinaString
{
    public class Solution
    {
        // Given two strings s and p, return an array of all the start indices of p's anagrams in s. You may return the answer in any order.
        // An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

        // Example 1:

        // Input: s = "cbaebabacd", p = "abc"
        // Output: [0,6]
        // Explanation:
        // The substring with start index = 0 is "cba", which is an anagram of "abc".
        // The substring with start index = 6 is "bac", which is an anagram of "abc".
        
        // Example 2:

        // Input: s = "abab", p = "ab"
        // Output: [0,1,2]
        // Explanation:
        // The substring with start index = 0 is "ab", which is an anagram of "ab".
        // The substring with start index = 1 is "ba", which is an anagram of "ab".
        // The substring with start index = 2 is "ab", which is an anagram of "ab".

        public static IList<int> FindAnagrams(string s, string p)
        {
            int n = s.Length, m = p.Length;
            var res = new List<int>();
            if (m > n) return res;
            var countP = CountCharacter(p);
            
            var k = new StringBuilder();
            for(int i = 0; i < m; i++)
            {
                k.Append(s[i]);
            }
            var window = k.ToString();
            var countWindow = CountCharacter(window);
            if (IsAnagram(countP, countWindow)) res.Add(0);
            
            for (int i = m; i < n; i++)
            {
                window += s[i];
                countWindow[window[m]-'a']++;
                countWindow[window[0] - 'a']--;
                window = window.Remove(0,1);
                if(IsAnagram(countP,countWindow)) res.Add(i-m+1);
            }

            return res;
        }

        private static int[] CountCharacter(string s)
        {
            var count = new int[26];
            for(int i = 0; i < s.Length; i++)
            {
                count[s[i] - 'a']++;
            }
            return count;
        }

        private static bool IsAnagram(int[]a, int[] b)
        {
            for(int i = 0; i < 26; i++)
            {
                if (a[i] != b[i]) return false;
            }
            return true;
        }
    }

    public class Test
    {
        public static bool[] TestFindAllAnagramsinaString()
        {
            IList<int> list1 = new List<int> { 0, 6 };
            IList<int> list2 = new List<int> { 0, 1, 2 };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<int>>(Solution.FindAnagrams("cbaebabacd", "abc"), list1),
                ResultTester.CheckResult<IList<int>>(Solution.FindAnagrams("abab", "ab"), list2)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find All Anagrams in a String");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestFindAllAnagramsinaString());
        }
    }
}