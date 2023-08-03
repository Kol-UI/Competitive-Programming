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
using CompetitiveProgramming.TestDrivenDevelopment;

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

    public class Test
    {
        public static bool[] TestTrappingRainWater()
        {
            int[] height1 = {0,1,0,2,1,0,1,3,2,1,2,1};
            int[] height2 = {4,2,0,3,2,5};

            int output1_42 = 6;
            int output2_42 = 9;

            int result1 = Solution.Trap(height1);
            int result2 = Solution.Trap(height2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, output1_42),
                ResultTester.CheckResult<int>(result2, output2_42)
            };
            return results;
        }
    }
}