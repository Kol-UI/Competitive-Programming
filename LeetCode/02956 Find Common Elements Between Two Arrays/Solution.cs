// Find Common Elements Between Two Arrays



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.FindCommonElementsBetweenTwoArrays
{
    public class Solution
    {
        public static int[] FindIntersectionValues(int[] nums1, int[] nums2)
        {
            var hashset1 = new HashSet<int>(nums1);
            var hashset2 = new HashSet<int>(nums2);

            return new int[]
            {
                nums1.Count(value => hashset2.Contains(value)),
                nums2.Count(value => hashset1.Contains(value))
            };    
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1_1 = {4,3,2,3,1};
            int[] nums2_1 = {2,2,5,2,3,6};
            int[] expected1 = {3,4};

            int[] nums1_2 = {3,4,2,3};
            int[] nums2_2 = {1,5};
            int[] expected2 = {0,0};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<int>>(Solution.FindIntersectionValues(nums1_1, nums2_1), expected1),
                ResultTester.CheckResult<IList<int>>(Solution.FindIntersectionValues(nums1_2, nums2_2), expected2),
            };
            return results;
        }
    }
}