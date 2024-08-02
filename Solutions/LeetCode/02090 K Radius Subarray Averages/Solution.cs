// K Radius Subarray Averages

/*
You are given a 0-indexed array nums of n integers, and an integer k.

The k-radius average for a subarray of nums centered at some index i with the radius k is the average of all elements in nums between the indices i - k and i + k (inclusive). If there are less than k elements before or after the index i, then the k-radius average is -1.

Build and return an array avgs of length n where avgs[i] is the k-radius average for the subarray centered at index i.

The average of x elements is the sum of the x elements divided by x, using integer division. The integer division truncates toward zero, which means losing its fractional part.

For example, the average of four elements 2, 3, 1, and 5 is (2 + 3 + 1 + 5) / 4 = 11 / 4 = 2.75, which truncates to 2.
 

Example 1:

Input: nums = [7,4,3,9,1,8,5,2,6], k = 3
Output: [-1,-1,-1,5,4,4,-1,-1,-1]
Explanation:
- avg[0], avg[1], and avg[2] are -1 because there are less than k elements before each index.
- The sum of the subarray centered at index 3 with radius 3 is: 7 + 4 + 3 + 9 + 1 + 8 + 5 = 37.
  Using integer division, avg[3] = 37 / 7 = 5.
- For the subarray centered at index 4, avg[4] = (4 + 3 + 9 + 1 + 8 + 5 + 2) / 7 = 4.
- For the subarray centered at index 5, avg[5] = (3 + 9 + 1 + 8 + 5 + 2 + 6) / 7 = 4.
- avg[6], avg[7], and avg[8] are -1 because there are less than k elements after each index.

Example 2:

Input: nums = [100000], k = 0
Output: [100000]
Explanation:
- The sum of the subarray centered at index 0 with radius 0 is: 100000.
  avg[0] = 100000 / 1 = 100000.

Example 3:

Input: nums = [8], k = 100000
Output: [-1]
Explanation: 
- avg[0] is -1 because there are less than k elements before and after index 0.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.KRadiusSubarrayAverages
{
    public class Solution
    {
        public static int[] GetAverages(int[] nums, int k)
        {
            var length = nums.Length;
            var result = Enumerable.Repeat(-1,length).ToArray();
            var divider = k * 2 + 1;

            if(divider > length)
            {
                return result;
            }

            var slidingSumm = Sum(nums[0..divider]);
            result[k] = (int)(slidingSumm/((ulong)divider));

            for(var i = k + 1; i < length - k; i++)
            {
                slidingSumm=slidingSumm - (ulong)nums[i - k - 1] + (ulong)nums[i + k];
                result[i] = (int)(slidingSumm/((ulong)divider));
            }
            return result;
        }

        private static ulong Sum(int[] nums)
        {
            ulong sum = 0;
            foreach(var n in nums)
            {
                sum += (ulong)n;
            }
            return sum;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1 = {7,4,3,9,1,8,5,2,6};
            int k1 = 3;
            int[] nums2 = {100000};
            int k2 = 0;
            int[] nums3 = {8};
            int k3 = 100000;

            int[] result1 = Solution.GetAverages(nums1, k1);
            int[] result2 = Solution.GetAverages(nums2, k2);
            int[] result3 = Solution.GetAverages(nums3, k3);
            int[] case1 = {-1,-1,-1,5,4,4,-1,-1,-1};
            int[] case2 = {100000};
            int[] case3 = {-1};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result1, case1),
                ResultTester.CheckResult<int[]>(result2, case2),
                ResultTester.CheckResult<int[]>(result3, case3)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("K Radius Subarray Aaverages");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}