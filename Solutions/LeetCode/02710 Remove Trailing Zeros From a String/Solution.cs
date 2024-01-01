// Remove Trailing Zeros From a String



using System;
using CompetitiveProgramming.Helpers.Generaters;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.RemoveTrailingZerosFromaString
{
    public class Solution
    {
        public static string RemoveTrailingZeros(string num)
        {
            return num.TrimEnd('0'); 
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.RemoveTrailingZeros("51230100"), "512301"),
                ResultTester.CheckResult<string>(Solution.RemoveTrailingZeros("123"), "123"),
            };

            for(int i = 0; i < 200; i++)
            {
                string value = RandomGeneraters.GenerateRandomPositiveNumberAsString();
                _ = results.Append(ResultTester.CheckResult<string>(Solution.RemoveTrailingZeros(value), value));
            }

            return results;
        }
    }
}