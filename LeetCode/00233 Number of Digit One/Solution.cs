using System;
namespace CompetitiveProgramming.LeetCode.NumberofDigitOne
{
    public class Solution
    {

        //Given an integer n, count the total number of digit 1 appearing in all non-negative integers less than or equal to n.

        //Input: n = 13
        //Output: 6

        //Input: n = 0
        //Output: 0

        public static int CountDigitOne(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            int multiplier = 1;

            while (multiplier <= n / 10)
            {
                multiplier *= 10;
            }
            if (multiplier == 1)
            {
                return 1;
            }
            int modulo = n % multiplier;
            int div = n / multiplier;
            int add = div == 1 ? modulo + 1 : multiplier;
            return add + div * CountDigitOne(multiplier - 1) + CountDigitOne(modulo);
        }
    }
}

