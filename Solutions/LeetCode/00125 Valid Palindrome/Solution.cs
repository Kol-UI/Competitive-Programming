// Valid Palindrome

/*
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.

 

Example 1:

Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.

Example 2:

Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome.

Example 3:

Input: s = " "
Output: true
Explanation: s is an empty string "" after removing non-alphanumeric characters.
Since an empty string reads the same forward and backward, it is a palindrome.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ValidPalindrome
{
    public class Solution
    {
        public static bool IsPalindrome(string s)
        {
            if(String.IsNullOrEmpty(s))
            {
                return false;
            }

            int left = 0;
            int right = s.Length - 1;

            while(left < right)
            {
                if(!char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }
                else if(!char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }
                else
                {
                    if(char.ToLower(s[left++]) != char.ToLower(s[right--]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.IsPalindrome("A man, a plan, a canal: Panama"), true),
                ResultTester.CheckResult<bool>(Solution.IsPalindrome("race a car"), false),
                ResultTester.CheckResult<bool>(Solution.IsPalindrome(" "), true),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Valid Palindrome");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}