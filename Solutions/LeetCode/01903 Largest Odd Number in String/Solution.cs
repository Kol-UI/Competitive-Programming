// Largest Odd Number in String



using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LargestOddNumberinString
{
    public class Solution
    {
        public static string LargestOddNumber(string num)
        {
            for (int i = num.Length - 1; i >= 0; i--) 
            {
                if (int.Parse(num[i].ToString()) % 2 != 0) 
                {
                    return num.Substring(0, i + 1);
                }
            }
            return "";
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.LargestOddNumber("52"), "5"),
                ResultTester.CheckResult<string>(Solution.LargestOddNumber("35427"), "35427"),
                ResultTester.CheckResult<string>(Solution.LargestOddNumber("4206"), ""),
            };
            return results;
        }
    }
}