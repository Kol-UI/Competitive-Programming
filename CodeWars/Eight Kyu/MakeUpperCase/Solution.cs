// MakeUpperCase

// Write a function which converts the input string to uppercase.

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.MakeUpperCase
{
    public class Solution
    {
        public static string MakeUpperCase(string str)
        {
            return str.ToUpper();
        }
    } 

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.MakeUpperCase("hello"), "HELLO"),
            };
            return results;
        }
    }
}