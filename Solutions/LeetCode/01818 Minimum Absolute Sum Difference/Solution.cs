// Minimum Absolute Sum Difference

/*
You are given two positive integer arrays nums1 and nums2, both of length n.

The absolute sum difference of arrays nums1 and nums2 is defined as the sum of |nums1[i] - nums2[i]| for each 0 <= i < n (0-indexed).

You can replace at most one element of nums1 with any other element in nums1 to minimize the absolute sum difference.

Return the minimum absolute sum difference after replacing at most one element in the array nums1. Since the answer may be large, return it modulo 109 + 7.

|x| is defined as:

x if x >= 0, or
-x if x < 0.
 

Example 1:

Input: nums1 = [1,7,5], nums2 = [2,3,5]
Output: 3
Explanation: There are two possible optimal solutions:
- Replace the second element with the first: [1,7,5] => [1,1,5], or
- Replace the second element with the third: [1,7,5] => [1,5,5].
Both will yield an absolute sum difference of |1-2| + (|1-3| or |5-3|) + |5-5| = 3.

Example 2:

Input: nums1 = [2,4,6,8,10], nums2 = [2,4,6,8,10]
Output: 0
Explanation: nums1 is equal to nums2 so no replacement is needed. This will result in an 
absolute sum difference of 0.

Example 3:

Input: nums1 = [1,10,4,4,2,7], nums2 = [9,3,5,1,7,4]
Output: 20
Explanation: Replace the first element with the second: [1,10,4,4,2,7] => [10,10,4,4,2,7].
This yields an absolute sum difference of |10-9| + |10-3| + |4-5| + |4-1| + |2-7| + |7-4| = 20
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MinimumAbsoluteSumDifference
{
    public class Solution
    {
        public static int MinAbsoluteSumDiff(int[] nums1, int[] nums2)
        {
            int n = nums1.Length;
            int modulo = 1000000007;

            if (n == 1) return Math.Abs(nums1[0] - nums2[0]);
            int[] nums = new int[n];

            Array.Copy(nums1, nums, n);
            Array.Sort(nums);

            int diff = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum = AddSumInModulo(sum, Math.Abs(nums1[i] - nums2[i]), modulo);
                int new_diff = CalcDiff(nums1[i], nums2[i], nums, Math.Abs(nums1[i] - nums2[i]) );
                if (new_diff > diff)
                {
                    sum = AddSumInModulo(sum, - new_diff + diff, modulo);
                    diff = new_diff;
                }
            }
            return sum;        
        }

        public static int AddSumInModulo(int sum, int add, int modulo)
        {
            return (sum + add) % modulo;
        }

        public static int CalcDiff(int key, int target, int[] nums, int basediff)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (right - left > 1)
            {
                int mid = left + (right - left)/2;
                if (nums[mid] > target) right = mid;
                else left = mid;
            }
            
            if (Math.Abs(nums[left] - target) > Math.Abs(nums[right] - target)) left = right;
            if (nums[left] == key) return 0;
            
            return basediff - Math.Abs(nums[left] - target);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1_1 = {1,7,5}; int[] nums2_1 = {2,3,5};
            int[] nums1_2 = {2,4,6,8,10}; int[] nums2_2 = {2,4,6,8,10};
            int[] nums1_3 = {1,10,4,4,2,7}; int[] nums2_3 = {9,3,5,1,7,4};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinAbsoluteSumDiff(nums1_1, nums2_1), 3),
                ResultTester.CheckResult<int>(Solution.MinAbsoluteSumDiff(nums1_2, nums2_2), 0),
                ResultTester.CheckResult<int>(Solution.MinAbsoluteSumDiff(nums1_3, nums2_3), 20),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Minimum Absolute Sum Difference");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}