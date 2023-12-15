// Reorganize String

/*
Given a string s, rearrange the characters of s so that any two adjacent characters are not the same.

Return any possible rearrangement of s or return "" if not possible.

 

Example 1:

Input: s = "aab"
Output: "aba"

Example 2:

Input: s = "aaab"
Output: ""
*/

using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ReorganizeString
{
    public class Solution
    {
        public static string ReorganizeString(string s)
        {
            Dictionary<char, int> freqMap = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (!freqMap.ContainsKey(c)) freqMap[c] = 0;
                freqMap[c]++;
            }

            List<char> sortedChars = new List<char>(freqMap.Keys);
            sortedChars.Sort((a, b) => freqMap[b].CompareTo(freqMap[a]));

            if (freqMap[sortedChars[0]] > (s.Length + 1) / 2) return "";

            char[] res = new char[s.Length];
            int i = 0;
            foreach (char c in sortedChars)
            {
                for (int j = 0; j < freqMap[c]; j++)
                {
                    if (i >= s.Length) i = 1;
                    res[i] = c;
                    i += 2;
                }
            }

            return new string(res);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.ReorganizeString("aab"), "aba"),
                ResultTester.CheckResult<string>(Solution.ReorganizeString("aaab"), ""),
            };

            return results;
        }
    }
}