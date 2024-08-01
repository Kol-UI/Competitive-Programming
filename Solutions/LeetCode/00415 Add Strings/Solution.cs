// Add Strings

/*
Given two non-negative integers, num1 and num2 represented as string, return the sum of num1 and num2 as a string.

You must solve the problem without using any built-in library for handling large integers (such as BigInteger). You must also not convert the inputs to integers directly.

 

Example 1:

Input: num1 = "11", num2 = "123"
Output: "134"

Example 2:

Input: num1 = "456", num2 = "77"
Output: "533"

Example 3:

Input: num1 = "0", num2 = "0"
Output: "0"
*/

using System;
using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.AddStrings
{
    public class Solution 
    {
        public static string AddStrings(string num1, string num2)
        {
            int carry = 0, i = num1.Length - 1, j = num2.Length - 1;
            StringBuilder sb = new();
            while (i > -1 || j > -1 || carry != 0)
            {
                int a = i > -1 ? num1[i] - '0' : 0;
                int b = j > -1 ? num2[j] - '0' : 0;
                i--;
                j--;

                int sum = a + b + carry;
                sb.Insert(0, sum % 10);
                carry = sum / 10;
            }

            return sb.ToString();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.AddStrings("11", "123"), "134"),
                ResultTester.CheckResult<string>(Solution.AddStrings("456", "77"), "533"),
                ResultTester.CheckResult<string>(Solution.AddStrings("0", "0"), "0"),
            };
            return results;
        }
    }
    
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("add Strings");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}