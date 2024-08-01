// Minimum Number of Operations to Make Array Continuous

/*
You are given an integer array nums. In one operation, you can replace any element in nums with any integer.

nums is considered continuous if both of the following conditions are fulfilled:

All elements in nums are unique.
The difference between the maximum element and the minimum element in nums equals nums.length - 1.
For example, nums = [4, 2, 5, 3] is continuous, but nums = [1, 2, 3, 5, 6] is not continuous.

Return the minimum number of operations to make nums continuous.

 

Example 1:

Input: nums = [4,2,5,3]
Output: 0
Explanation: nums is already continuous.

Example 2:

Input: nums = [1,2,3,5,6]
Output: 1
Explanation: One possible solution is to change the last element to 4.
The resulting array is [1,2,3,5,4], which is continuous.

Example 3:

Input: nums = [1,10,100,1000]
Output: 3
Explanation: One possible solution is to:
- Change the second element to 2.
- Change the third element to 3.
- Change the fourth element to 4.
The resulting array is [1,2,3,4], which is continuous.

*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumNumberofOperationstoMakeArrayContinuous
{
    public class Solution
    {
        public static int MinOperations(int[] nums)
        {
            Array.Sort(nums);

            var st = new HashSet<int>(nums).ToArray();
            var n = nums.Length;
            var answer = n  - 1;
            var right = 0;

            for(var left = 0; left < st.Length; left++)
            {
                while(right < st.Length && (st[right] - st[left]) < n)
                {
                    right++;
                }
                var size = right - left;
                var times = n - size;
                answer = Math.Min(answer, times);
            }
            return answer;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1 = {4,2,5,3};
            int[] nums2 = {1,2,3,5,6};
            int[] nums3 = {1,10,100,1000};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinOperations(nums1), 0),
                ResultTester.CheckResult<int>(Solution.MinOperations(nums2), 1),
                ResultTester.CheckResult<int>(Solution.MinOperations(nums3), 3),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Number of Operations to Make Array Continuous");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}