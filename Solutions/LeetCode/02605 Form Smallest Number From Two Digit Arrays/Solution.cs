// Form Smallest Number From Two Digit Arrays


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.FormSmallestNumberFromTwoDigitArrays
{
    public class Solution 
    {
        public static int MinNumber(int[] nums1, int[] nums2)
        {
            var commonElements = nums1.Intersect(nums2);
            if(commonElements.Any())
            {
                return (commonElements.Min());
            }
            else
            {
                int min1 = nums1.Min() * 10 + nums2.Min();
                int min2 = nums2.Min() * 10 + nums1.Min();
                
                return (min1 < min2 ? min1 : min2);
            }
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinNumber(new int[]{4,1,3}, new int[]{5,7}), 15),
                ResultTester.CheckResult<int>(Solution.MinNumber(new int[]{3,5,2,6}, new int[]{3,1,7}), 3),
            };
            return results;
        }
    }
}