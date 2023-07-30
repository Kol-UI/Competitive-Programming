// Convert number to reversed array of digits

/*
Given a random non-negative number, you have to return the digits of this number within an array in reverse order.

Example(Input => Output):
35231 => [1,3,2,5,3]
0 => [0]
*/

using System;
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
}