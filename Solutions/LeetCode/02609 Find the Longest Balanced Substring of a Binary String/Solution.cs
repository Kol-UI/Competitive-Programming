// Find the Longest Balanced Substring of a Binary String


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.FindtheLongestBalancedSubstringofaBinaryString
{
    public class Solution
    {
        public static int FindTheLongestBalancedSubstring(string s) 
        {
            int max = 0;
            int zeros = 0;
            int ones = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (ones == 0 && s[i] == '0')
                {
                    zeros++;
                }
                else if (s[i] == '1' && zeros > 0)
                {
                    ones++;
                }
                else if (s[i] == '0' && zeros > 0 && ones > 0)
                {
                    max = Math.Max(max, Math.Min(zeros, ones) * 2);
                    zeros = 1;
                    ones = 0;
                }
            }

            return Math.Max(max, Math.Min(zeros, ones) * 2);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.FindTheLongestBalancedSubstring("01000111"), 6),
                ResultTester.CheckResult<int>(Solution.FindTheLongestBalancedSubstring("00111"), 4),
                ResultTester.CheckResult<int>(Solution.FindTheLongestBalancedSubstring("111"), 0),
            };
            return results;
        }
    }
}