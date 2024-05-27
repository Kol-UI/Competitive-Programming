// Find the Number of Good Pairs I

using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindtheNumberofGoodPairsI
{
    public class Solution
    {
        public static int NumberOfPairs(int[] nums1, int[] nums2, int k)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            int n = nums1.Length, m = nums2.Length;
            int resCount = 0;
            int left = 0, right = 0;
            while (left < n)
            {
                if(right >= m || nums1[left] < nums2[right] * k)
                {
                    left++;
                    right = 0;
                }
                else if (nums1[left] % (nums2[right] * k) == 0)
                {
                    resCount++;
                    right++;
                }
                else if (nums1[left] > nums2[right] * k)
                    right++;
            }
            return resCount;
        }
    }
}