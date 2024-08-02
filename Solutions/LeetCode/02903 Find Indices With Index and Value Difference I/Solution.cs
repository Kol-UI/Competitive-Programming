// Find Indices With Index and Value Difference I

/*
You are given a 0-indexed integer array nums having length n, an integer indexDifference, and an integer valueDifference.

Your task is to find two indices i and j, both in the range [0, n - 1], that satisfy the following conditions:

abs(i - j) >= indexDifference, and
abs(nums[i] - nums[j]) >= valueDifference
Return an integer array answer, where answer = [i, j] if there are two such indices, and answer = [-1, -1] otherwise. If there are multiple choices for the two indices, return any of them.

Note: i and j may be equal.

 

Example 1:

Input: nums = [5,1,4,1], indexDifference = 2, valueDifference = 4
Output: [0,3]
Explanation: In this example, i = 0 and j = 3 can be selected.
abs(0 - 3) >= 2 and abs(nums[0] - nums[3]) >= 4.
Hence, a valid answer is [0,3].
[3,0] is also a valid answer.

Example 2:

Input: nums = [2,1], indexDifference = 0, valueDifference = 0
Output: [0,0]
Explanation: In this example, i = 0 and j = 0 can be selected.
abs(0 - 0) >= 0 and abs(nums[0] - nums[0]) >= 0.
Hence, a valid answer is [0,0].
Other valid answers are [0,1], [1,0], and [1,1].

Example 3:

Input: nums = [1,2,3], indexDifference = 2, valueDifference = 4
Output: [-1,-1]
Explanation: In this example, it can be shown that it is impossible to find two indices that satisfy both conditions.
Hence, [-1,-1] is returned.
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindIndicesWithIndexandValueDifferenceI
{
    public class Solution
    {
        public static int[] FindIndices(int[] nums, int indexDifference, int valueDifference)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    if(Math.Abs(i - j) >= indexDifference & Math.Abs(nums[i] - nums[j]) >= valueDifference)
                    {
                        return new int[2]{ i, j };
                    }
                }
                
            }

            return new int[2]{ -1, -1 };
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1 = {5,1,4,1};
            int indexDifference1 = 2;
            int valueDifference1 = 4;
            int[] nums2 = {2,1};
            int indexDifference2 = 0;
            int valueDifference2 = 0;
            int[] nums3 = {1,2,3};
            int indexDifference3 = 2;
            int valueDifference3 = 4;

            int[] result1 = {0,3};
            int[] result2 = {0,0};
            int[] result3 = {-1,-1};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.FindIndices(nums1, indexDifference1, valueDifference1), result1),
                ResultTester.CheckResult<int[]>(Solution.FindIndices(nums2, indexDifference2, valueDifference2), result2),
                ResultTester.CheckResult<int[]>(Solution.FindIndices(nums3, indexDifference3, valueDifference3), result3),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2903");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}