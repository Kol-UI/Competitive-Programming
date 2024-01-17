// Minimum String Length After Removing Substrings

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MinimumStringLengthAfterRemovingSubstrings
{
    public class Solution
    {
        public static int MinLength(string s)
        {
            int length = 0;

            while (length != s.Length)
            {
                length = s.Length;

                s = s.Replace("AB","").Replace("CD","");
            }

            return s.Length;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinLength("ABFCACDB"), 2),
                ResultTester.CheckResult<int>(Solution.MinLength("ACBBD"), 5),
            };
            return results;
        }
    }
}