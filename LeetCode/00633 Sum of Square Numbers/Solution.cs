// Sum of Square Numbers

/*
Given a non-negative integer c, decide whether there're two integers a and b such that a2 + b2 = c.

 

Example 1:

Input: c = 5
Output: true
Explanation: 1 * 1 + 2 * 2 = 5

Example 2:

Input: c = 3
Output: false
*/

using System;
namespace CompetitiveProgramming.LeetCode.SumofSquareNumbers
{
    public class Solution
    {
        public static bool JudgeSquareSum(int c)
        {
            var lo = 0L;
            var hi = (long)Math.Sqrt(c);

            while (lo <= hi)
            {
                var sum = lo * lo + hi * hi;
                if (sum == c)
                {
                    return true;
                }

                if (sum > c)
                {
                    --hi;
                }
                else
                {
                    ++lo;
                }
            }
            
            return false;
        }
    }
}
