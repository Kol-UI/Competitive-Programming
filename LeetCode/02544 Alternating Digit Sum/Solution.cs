// Alternating Digit Sum

/*
You are given a positive integer n. Each digit of n has a sign according to the following rules:

The most significant digit is assigned a positive sign.
Each other digit has an opposite sign to its adjacent digits.
Return the sum of all digits with their corresponding sign.

 

Example 1:

Input: n = 521
Output: 4
Explanation: (+5) + (-2) + (+1) = 4.


Example 2:

Input: n = 111
Output: 1
Explanation: (+1) + (-1) + (+1) = 1.


Example 3:

Input: n = 886996
Output: 0
Explanation: (+8) + (-8) + (+6) + (-9) + (+9) + (-6) = 0.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.AlternatingDigitSum
{
    public class Solution
    {
        public static int AlternateDigitSum(int n)
        {
            int sign = 1;
            int result = 0;

            foreach(var digit in n.ToString())
            {
                result += (sign * (digit - '0'));
                sign *= -1;
            }
            
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestAlternatingDigitSum()
        {
            int n1 = 521;
            int n2 = 111;
            int n3 = 886996;
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.AlternateDigitSum(n1), 4),
                ResultTester.CheckResult<int>(Solution.AlternateDigitSum(n2), 1),
                ResultTester.CheckResult<int>(Solution.AlternateDigitSum(n3), 0)
            };
            return results;
        }
    }
}