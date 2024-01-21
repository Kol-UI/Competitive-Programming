// Minimum Number of Pushes to Type Word I


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MinimumNumberofPushestoTypeWordI
{
    public class Solution
    {
        public static int MinimumPushes(string word)
        {
            var n = word.Length;
            var result = 0;
            var mult = 1;

            while (n > 0)
            {
                var result0 = Math.Min(8, n);
                n -= result0;
                result += result0 * mult;
                mult++;
            }
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinimumPushes("abcde"), 5),
                ResultTester.CheckResult<int>(Solution.MinimumPushes("xycdefghij"), 12),
            };
            return results;
        }
    }
}