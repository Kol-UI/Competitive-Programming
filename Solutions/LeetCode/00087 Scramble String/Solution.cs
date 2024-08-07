using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ScrambleString
{
    /*
        We can scramble a string s to get a string t using the following algorithm:
        If the length of the string is 1, stop.
        If the length of the string is > 1, do the following:
        Split the string into two non-empty substrings at a random index, i.e., if the string is s, divide it to x and y where s = x + y.
        Randomly decide to swap the two substrings or to keep them in the same order. i.e., after this step, s may become s = x + y or s = y + x.
        Apply step 1 recursively on each of the two substrings x and y.
        Given two strings s1 and s2 of the same length, return true if s2 is a scrambled string of s1, otherwise, return false.

        Example 1:
        Input: s1 = "great", s2 = "rgeat"
        Output: true
        Explanation: One possible scenario applied on s1 is:
        "great" --> "gr/eat" // divide at random index.
        "gr/eat" --> "gr/eat" // random decision is not to swap the two substrings and keep them in order.
        "gr/eat" --> "g/r / e/at" // apply the same algorithm recursively on both substrings. divide at random index each of them.
        "g/r / e/at" --> "r/g / e/at" // random decision was to swap the first substring and to keep the second substring in the same order.
        "r/g / e/at" --> "r/g / e/ a/t" // again apply the algorithm recursively, divide "at" to "a/t".
        "r/g / e/ a/t" --> "r/g / e/ a/t" // random decision is to keep both substrings in the same order.
        The algorithm stops now, and the result string is "rgeat" which is s2.
        As one possible scenario led s1 to be scrambled to s2, we return true.
        
        Example 2:
        Input: s1 = "abcde", s2 = "caebd"
        Output: false
        
        Example 3:
        Input: s1 = "a", s2 = "a"
        Output: true
    */
    public class Solution
    {
        private static readonly Dictionary<string, bool> _memo = new();
    
        public static bool IsScramble(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            return s1 == s2 || HelperisScramble(s1, s2);
        }

        private static bool HelperisScramble(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            if (s1 == s2)
            {
                return true;
            }

            var key = s1 + "-" + s2;
            
            if (_memo.TryGetValue(key, out var cached))
            {
                return cached;
            }

            var n = s1.Length;

            for (var i = 1; i < n; i++)
            {
                if (HelperisScramble(s1[..i], s2[..i]) && HelperisScramble(s1[i..], s2[i..]))
                {
                    return _memo[key] = true;
                }

                if (HelperisScramble(s1[..i], s2[(n - i)..]) && HelperisScramble(s1[i..], s2[..(n - i)]))
                {
                    return _memo[key] = true;
                }
            }

            return _memo[key] = false;
        }
    }

    public class Test
    {
        public static bool[] TestScrambleString()
        {
            // Case 1
            string s1_87_1 = "great";
            string s2_87_1 = "rgeat";
            bool result87_1 = Solution.IsScramble(s1_87_1, s2_87_1);

            // Case 2
            string s1_87_2 = "great";
            string s2_87_2 = "rgeat";
            bool result87_2 = Solution.IsScramble(s1_87_2, s2_87_2);

            // Case 3
            string s1_87_3 = "great";
            string s2_87_3 = "rgeat";
            bool result87_3 = Solution.IsScramble(s1_87_3, s2_87_3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(result87_1, true),
                ResultTester.CheckResult<bool>(result87_2, true),
                ResultTester.CheckResult<bool>(result87_3, true),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Scramble String");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestScrambleString());
        }
    }
}