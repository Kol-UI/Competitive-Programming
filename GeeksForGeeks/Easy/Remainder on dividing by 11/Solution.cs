// Remainder on dividing by 11
/*
Given a big positive number x represented as string, find value of x % 11 or x mod 11. Output is expected as an integer.

Example 1:

Input: x = 1345
Output: 3
Explanation: 1345 % 11 = 3 
Example 1:

Input: x = 231456786543567898765
Output: 1
Explanation: 231456786543567898765 % 11 = 1

Your Task:  
You don't need to read input or print anything. Your task is to complete the function xmod11() which takes string x as the input parameter and returns the integer value of x%11.

Expected Time Complexity: O(length of string x)
Expected Space Complexity: O(1)

Constraints:
1 ≤ length of string x ≤ 100000
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.GeeksForGeeks.Easy.Remainderondividingby11
{
    public class Solution
    {
        public static int xmod11(string x)
        { 
            int cur = 0;
            int rem = 0;
            for(int i = 0; i < x.Length; i++)
            {
                cur = rem*10 + x[i] - '0';
                rem = cur%11;
            }
            return rem;
        }
    }

    public class Test
    {
        public static bool[] TestRemainderondividingby11()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.xmod11("1345"), 3),
                ResultTester.CheckResult<int>(Solution.xmod11("231456786543567898765"), 1)
            };
            return results;
        }
    }
}