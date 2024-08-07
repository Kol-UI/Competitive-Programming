// Add Digits
/*
Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.

 

Example 1:

Input: num = 38
Output: 2
Explanation: The process is
38 --> 3 + 8 --> 11
11 --> 1 + 1 --> 2 
Since 2 has only one digit, return it.

Example 2:

Input: num = 0
Output: 0
 

Constraints:

0 <= num <= 231 - 1
*/
using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.AddDigits
{
    public class Solution
    {
        public static int AddDigits(int num)
        {
            while (num > 9)
            {
                int i = 0;
                while (num > 0)
                {
                    i += num % 10;
                    num /= 10;
                }
                num = i;
            }
            
            return num;
        }
    }

    public class Test
    {
        public static bool[] TestAddDigits()
        {
            // Case 1
            int Case1_258 = LeetCode.AddDigits.Solution.AddDigits(38);

            // Case 2
            int Case2_258 = LeetCode.AddDigits.Solution.AddDigits(0);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_258, 2),
                ResultTester.CheckResult<int>(Case2_258, 0)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Add Digits");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestAddDigits());
        }
    }
}