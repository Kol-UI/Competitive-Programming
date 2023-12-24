// Minimum Changes To Make Alternating Binary String



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MinimumChangesToMakeAlternatingBinaryString
{
    public class Solution
    {
        public static int MinOperations(string s) 
        {
            int value = 0;
            int laps = 0;

            foreach(var c in s)
            {
                if(value != c - '0')
                {
                    laps++;
                }

                value = 1 - value;
            }

            return Math.Min(laps, s.Length - laps);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinOperations("0100"), 1),
                ResultTester.CheckResult<int>(Solution.MinOperations("10"), 0),
                ResultTester.CheckResult<int>(Solution.MinOperations("1111"), 2),
            };
            return results;
        }
    }
}