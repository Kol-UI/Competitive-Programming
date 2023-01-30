using System;
using System.Threading;

namespace CompetitiveProgramming.LeetCode.ClimbingStairs
{
	public class Solution
	{
        //Example 1
        //Input: n = 2
        //Output: 2
        //Explanation: There are two ways to climb to the top.
        //1. 1 step + 1 step
        //2. 2 steps

        //Example 2
        //Input: n = 3
        //Output: 3
        //Explanation: There are three ways to climb to the top.
        //1. 1 step + 1 step + 1 step
        //2. 1 step + 2 steps
        //3. 2 steps + 1 step

        public static int ClimbStairs(int n)
        {
            int a = 0, b = 1, c = 0;
            for (int i = 0; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
	}
}

