// Longest Unequal Adjacent Groups Subsequence I


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LongestUnequalAdjacentGroupsSubsequenceI
{
    public class Solution
    {
        public static IList<string> GetLongestSubsequence(string[] words, int[] groups)
        {
            var longestSubsequence = new List<string>();
            
            longestSubsequence.Add(words[0]); 
            
            for (int i = 1; i < words.Length; i++)
            {
                if (groups[i] != groups[i - 1])
                {
                    longestSubsequence.Add(words[i]);
                }
            }
            
            return longestSubsequence;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<string>>(Solution.GetLongestSubsequence(new string[] {"e","a","b"}, new int[]{0,0,1}), new List<string> {"e", "b"}),
                ResultTester.CheckResult<IList<string>>(Solution.GetLongestSubsequence(new string[] {"a","b","c","d"}, new int[]{1,0,1,1}), new List<string> {"a","b","c"}),
            };
            return results;
        }
    }
}