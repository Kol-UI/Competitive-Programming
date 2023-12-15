// Valid Perfect Square

/*
Given a positive integer num, return true if num is a perfect square or false otherwise.

A perfect square is an integer that is the square of an integer. In other words, it is the product of some integer with itself.

You must not use any built-in library function, such as sqrt.

 

Example 1:

Input: num = 16
Output: true
Explanation: We return true because 4 * 4 = 16 and 4 is an integer.

Example 2:

Input: num = 14
Output: false
Explanation: We return false because 3.742 * 3.742 = 14 and 3.742 is not an integer.
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ValidPerfectSquare
{
    public class Solution
    {
        public static bool IsPerfectSquare(int num)
        {
            var lo = 1;
            var hi = num;

            while (lo <= hi)
            {
                var mid = lo + (hi - lo) / 2;
                var square = (long)mid * mid;
                if (square == num)
                {
                    return true;
                }

                if (square > num)
                {
                    hi = mid - 1;
                }
                else
                {
                    lo = mid + 1;
                }
            }

            return false;
        }
    }

    public class Test
    {
        public static bool[] TestValidPerfectSquare()
        {
            int case1_367 = 16;
            int case2_367 = 14;

            bool result1_367 = Solution.IsPerfectSquare(case1_367);
            bool result2_367 = Solution.IsPerfectSquare(case2_367);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(result1_367, true),
                ResultTester.CheckResult<bool>(result2_367, false)
            };
            return results;
        }
    }
}