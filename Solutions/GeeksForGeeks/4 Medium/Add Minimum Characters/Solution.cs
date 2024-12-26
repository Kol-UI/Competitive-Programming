// Add Minimum Characters

/*
Given a string str, find the minimum characters to be added at front of the string to make it a palindrome.


Example 1:

Input:
str = ABCD
Output: 3
Explanation: The resultant string 
after adding 3 characters is DCBABCD.
The minimum possible answer is 3.

Example 2:

Input:
str = ABA
Output: 0
Explanation: The given string
is already a palindrome.

Your Task:  
You don't need to read input or print anything. Your task is to complete the function addMinChar() which takes the string str as input parameters and returns the minimum number of characters to be added to make it a palindrome.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.GeeksForGeeks.Medium.AddMinimumCharacters
{
    public class Solution
    {
        public static int AddMinChar(String str)
        {
            int len = str.Length;
            int i = 0;
            int j = len - 1;
            int cnt = len - 1;
            
            while(i < j)
            {
                if(str[i] == str[j])
                {
                    i++;
                    j--;
                }
                else
                {
                    i = 0;
                    j = (--cnt);
                }
            }
            return len - cnt - 1;
        }
    }

    public class Test
    {
        public static bool[] TestAddMinimumCharacters()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.AddMinChar("ABCD"), 3),
                ResultTester.CheckResult<int>(Solution.AddMinChar("ABA"), 0)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Add Minimum Characters");
            ResultTester.CheckCurrentSolution(ProblemOrigin.GeeksForGeeks, ProblemCategory.MediumGFG, Test.TestAddMinimumCharacters());
        }
    }
}