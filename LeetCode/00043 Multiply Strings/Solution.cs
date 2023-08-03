// Multiply Strings

/*
Given two non-negative integers num1 and num2 represented as strings, return the product of num1 and num2, also represented as a string.

Note: You must not use any built-in BigInteger library or convert the inputs to integer directly.

 

Example 1:

Input: num1 = "2", num2 = "3"
Output: "6"

Example 2:

Input: num1 = "123", num2 = "456"
Output: "56088"
*/

using System;
using System.Numerics;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MultiplyStrings
{
    public class Solution
    {
        public static string Multiply(string num1, string num2)
        {
            BigInteger n1 = BigInteger.Parse(num1);
            BigInteger n2 = BigInteger.Parse(num2);
            BigInteger n3 = n1 * n2;

            return n3.ToString();
        }
    }

    public class Test
    {
        public static bool[] TestMultiplyStrings()
        {
            string num1 = "2";
            string num2 = "3";
            string num3 = "123";
            string num4 = "456";
            string result1 = Solution.Multiply(num1, num2);
            string result2 = Solution.Multiply(num3, num4);
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(result1, "6"),
                ResultTester.CheckResult<string>(result2, "56088")
            };
            return results;
        }
    }
}