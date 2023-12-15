// Convert number to reversed array of digits

/*
Given a random non-negative number, you have to return the digits of this number within an array in reverse order.

Example(Input => Output):
35231 => [1,3,2,5,3]
0 => [0]
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.ConvertNumberToReversedArrayOfDigits
{
    public class Solution
    {
        public static long[] Digitize(long n)
        {
            string numberString = n.ToString();
            long[] digitsArray = new long[numberString.Length];

            for (int i = numberString.Length - 1; i >= 0; i--)
            {
                digitsArray[numberString.Length - 1 - i] = long.Parse(numberString[i].ToString());
            }

            return digitsArray;
        }

        public static long[] DigitizeLinq(long n)
        {
            return n.ToString().Reverse().Select(t => Convert.ToInt64(t.ToString())).ToArray();
        }
    }

    public class Test
    {
        public static bool[] TestConvertNumberToReversedArrayOfDigits()
        {
            long[] expected1 = { 1, 3, 2, 5, 3 };
            long[] expected2 = { 0 };
            long[] result1 = Solution.Digitize(35231);
            long[] result2 = Solution.Digitize(0);
            long[] result3 = Solution.DigitizeLinq(35231);
            long[] result4 = Solution.DigitizeLinq(0);
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long[]>(result1, expected1),
                ResultTester.CheckResult<long[]>(result2, expected2),
                ResultTester.CheckResult<long[]>(result3, expected1),
                ResultTester.CheckResult<long[]>(result4, expected2)
            };
            return results;
        }
    }
}