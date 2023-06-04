// Trapping Rain Water

/*
Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.

 

Example 1:

Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
Output: 6
Explanation: The above elevation map (black section) is represented by array [0,1,0,2,1,0,1,3,2,1,2,1]. In this case, 6 units of rain water (blue section) are being trapped.

Example 2:

Input: height = [4,2,0,3,2,5]
Output: 9
*/

using System;
namespace CompetitiveProgramming.LeetCode.TrappingRainWater
{
    public class Solution
    {
        public static int Trap(int[] height)
        {
            int l = 0;
            int r = height.Length - 1;
            int amount = 0;
            int lh = 0;
            int rh = 0;

            while (l <= r)
            {
                if (height[l] < height[r])
                {
                    amount -= height[l];
                    lh = Math.Max(lh, height[l]);
                    l++;
                    amount += lh;            
                }
                else
                {
                    amount -= height[r];
                    rh = Math.Max(rh, height[r]);
                    r--;
                    amount += rh;
                }
            }

            return amount;
        }
    }
}