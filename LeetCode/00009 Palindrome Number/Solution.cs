// Palindrome Number

/*
Given an integer x, return true if x is a 
palindrome
, and false otherwise.

 

Example 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.

Example 2:

Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

Example 3:

Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.

*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.PalindromeNumber
{
    public class Solution
    {
        public static bool IsPalindrome(int x)
        {
            string stringValue = x.ToString();

            char[] charArray = stringValue.ToCharArray();
            Array.Reverse(charArray);

            string reversed = new(charArray);

            return stringValue.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.IsPalindrome(121), true),
                ResultTester.CheckResult<bool>(Solution.IsPalindrome(-121), false),
                ResultTester.CheckResult<bool>(Solution.IsPalindrome(10), false),
            };
            return results;
        }
    }
}