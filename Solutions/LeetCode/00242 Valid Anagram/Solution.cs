using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ValidAnagram
{
    public class Solution
    {
        // Given two strings s and t, return true if t is an anagram of s, and false otherwise.
        // An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

        // Example 1:

        // Input: s = "anagram", t = "nagaram"
        // Output: true

        // Example 2:

        // Input: s = "rat", t = "car"
        // Output: false

        public static bool IsAnagram(string s, string t)
        {
            var so = s.OrderBy(c => c);
            var to = t.OrderBy(c => c);
            return so.SequenceEqual(to);
        }
    }

    public class Solution2
    {
        public bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length) return false;
            
            char[] ss = s.ToCharArray();
            char[] tt = t.ToCharArray();

            Array.Sort(ss);
            Array.Sort(tt);

            return new string(ss) == new string(tt);
        }
    }

    public class Test
    {
        public static bool[] TestValidAnagram()
        {
            Solution2 sol = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.IsAnagram("anagram", "nagaram"), true),
                ResultTester.CheckResult<bool>(Solution.IsAnagram("rat", "car"), false),
                ResultTester.CheckResult<bool>(sol.IsAnagram("anagram", "nagaram"), true),
                ResultTester.CheckResult<bool>(sol.IsAnagram("rat", "car"), false)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Valid Anagram");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestValidAnagram());
        }
    }
}