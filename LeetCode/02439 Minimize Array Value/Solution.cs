using System;
namespace CompetitiveProgramming.LeetCode.MinimizeMaximumofArray
{
    public class Solution
    {
        public static int MinimizeArrayValue(int[] nums)
        {
            int result = 0;
            int lowest = nums.Min();
            int highest = nums.Max();

            while (lowest <= highest)
            {
                long mid = ((long)lowest + (long)highest) / 2;

                if (isValidMid(nums, mid))
                {
                    result = (int)mid;
                    highest = result - 1;
                }
                else
                {
                    lowest = (int)mid + 1;
                }
            }
            return result;
        }

        private static bool isValidMid(int[] nums, long mid)
        {
            long tempRem = 0;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] <= mid)
                {
                    tempRem -= Math.Min(tempRem, mid - nums[i]);
                }
                else
                {
                    tempRem += nums[i] - mid;
                }
            }
            return tempRem <= 0;
        }
    }
}