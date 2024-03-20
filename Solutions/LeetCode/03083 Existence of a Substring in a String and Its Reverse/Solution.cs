// Existence of a Substring in a String and Its Reverse


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ExistenceofaSubstringinaStringandItsReverse
{
    public class Solution
    {
        public static bool IsSubstringPresent(string s) => Enumerable
            .Range(0, s.Length - 1)
            .Any(index => s.Contains(string.Concat(s
                .Substring(index, 2)
                .Reverse())));
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.IsSubstringPresent("leetcode"), true),
                ResultTester.CheckResult<bool>(Solution.IsSubstringPresent("abcba"), true),
                ResultTester.CheckResult<bool>(Solution.IsSubstringPresent("abcd"), false),
            };
            return results;
        }
    }
}