// Buddy Strings

/*
Given two strings s and goal, return true if you can swap two letters in s so the result is equal to goal, otherwise, return false.

Swapping letters is defined as taking two indices i and j (0-indexed) such that i != j and swapping the characters at s[i] and s[j].

For example, swapping at indices 0 and 2 in "abcd" results in "cbad".
 

Example 1:

Input: s = "ab", goal = "ba"
Output: true
Explanation: You can swap s[0] = 'a' and s[1] = 'b' to get "ba", which is equal to goal.
Example 2:

Input: s = "ab", goal = "ab"
Output: false
Explanation: The only letters you can swap are s[0] = 'a' and s[1] = 'b', which results in "ba" != goal.
Example 3:

Input: s = "aa", goal = "aa"
Output: true
Explanation: You can swap s[0] = 'a' and s[1] = 'a' to get "aa", which is equal to goal.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BuddyStrings
{
    public class Solution
    {
        public static bool BuddyStrings(string s, string goal)
        {
            if (s.Length != goal.Length || s.Length < 2 || goal.Length < 2)
            return false;

            if (s.Equals(goal))
            {
                HashSet<char> uniqueChars = new HashSet<char>(s);
                return uniqueChars.Count < s.Length;
            }

            List<int> diffIndices = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != goal[i])
                    diffIndices.Add(i);
                if (diffIndices.Count > 2)
                    return false;
            }

            if (diffIndices.Count != 2)
                return false;

            return s[diffIndices[0]] == goal[diffIndices[1]] && s[diffIndices[1]] == goal[diffIndices[0]];
        }
    }

    public class Test
    {
        public static bool[] TestCase()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.BuddyStrings("ab", "ba"), true),
                ResultTester.CheckResult<bool>(Solution.BuddyStrings("ab", "ab"), false),
                ResultTester.CheckResult<bool>(Solution.BuddyStrings("aa", "aa"), true),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Buddy Strings");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCase());
        }
    }
}