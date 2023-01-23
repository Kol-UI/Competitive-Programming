﻿using System;

namespace CompetitiveProgramming.LeetCode.FlipStringtoMonotoneIncreasing
{
    public class Solution
	{
        //A binary string is monotone increasing if it consists of some number of 0's (possibly none), followed by some number of 1's(also possibly none).
        //You are given a binary string s.You can flip s[i] changing it from 0 to 1 or from 1 to 0.
        //Return the minimum number of flips to make s monotone increasing.

        //Example 1:

        //Input: s = "00110"
        //Output: 1
        //Explanation: We flip the last digit to get 00111.

        //Example 2:

        //Input: s = "010110"
        //Output: 2
        //Explanation: We flip to get 011111, or alternatively 000111.

        //Example 3:

        //Input: s = "00011000"
        //Output: 2
        //Explanation: We flip to get 00000000.

        public static int MinFlipsMonoIncr(string s)
        {
            var z = new int[s.Length];
            var a = new int[s.Length];
            if (s[0] == '1')
            {
                z[0] = 1;
            }
            else
            {
                a[0] = 1;
            }

            for (var i = 1; i < s.Length; i++)
            {
                z[i] = z[i - 1];
                a[i] = a[i - 1];
                if (s[i] == '1')
                {
                    z[i]++;
                }
                else a[i]++;
            }

            var min = a[s.Length - 1];
            for (var i = 0; i < s.Length; i++)
            {
                var t = z[i] + a[s.Length - 1] - a[i];
                min = min > t ? t : min;
            }
            return min;
        }


    }
}
