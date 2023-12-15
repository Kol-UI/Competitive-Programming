// Check if One String Swap Can Make Strings Equal

/*
You are given two strings s1 and s2 of equal length. A string swap is an operation where you choose two indices in a string (not necessarily different) and swap the characters at these indices.

Return true if it is possible to make both strings equal by performing at most one string swap on exactly one of the strings. Otherwise, return false.

 

Example 1:

Input: s1 = "bank", s2 = "kanb"
Output: true
Explanation: For example, swap the first character with the last character of s2 to make "bank".

Example 2:

Input: s1 = "attack", s2 = "defend"
Output: false
Explanation: It is impossible to make them equal with one string swap.

Example 3:

Input: s1 = "kelb", s2 = "kelb"
Output: true
Explanation: The two strings are already equal, so no string swap operation is required.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CheckifOneStringSwapCanMakeStringsEqual
{
    public class Solution
    {
        public static bool AreAlmostEqual(string s1, string s2)
        {
            if(s1 == s2) return true;

            HashSet<char> set1 = new HashSet<char>();
            HashSet<char> set2 = new HashSet<char>();
            int changes = 0;

            for(int i = 0; i < s1.Length;i++)
            {
                if(s1[i] != s2[i])
                {
                    set1.Add(s1[i]);
                    set2.Add(s2[i]);
                    changes++;
                }
            }

            foreach(var element in set1)
                if(set2.Contains(element)) set2.Remove(element);

            return (changes == 2 && set2.Count == 0);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            string case1s1 = "bank";
            string case1s2 = "kanb";
            string case2s1 = "attack";
            string case2s2 = "defend";
            string case3s1 = "kelb";
            string case3s2 = "kelb";

            bool result1 = Solution.AreAlmostEqual(case1s1, case1s2);
            bool result2 = Solution.AreAlmostEqual(case2s1, case2s2);
            bool result3 = Solution.AreAlmostEqual(case3s1, case3s2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(result1, true),
                ResultTester.CheckResult<bool>(result2, false),
                ResultTester.CheckResult<bool>(result3, true)
            };
            return results;
        }
    }
}
