// First Letter to Appear Twice


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FirstLettertoAppearTwice
{
    public class Solution
    {
        public static char RepeatedCharacter(string s)
        {
            int[] charCounts = new int[26];
            
            foreach (var c in s)
            {
                charCounts[c -'a']++;
                if (charCounts[c -'a'] == 2) return c;
            }

            return default;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<char>(Solution.RepeatedCharacter("abccbaacz"), 'c'),
                ResultTester.CheckResult<char>(Solution.RepeatedCharacter("abcdd"), 'd'),
            };
            return results;
        }
    }
}