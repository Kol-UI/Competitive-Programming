// Two Sum II - Input Array Is Sorted

/*
Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number. Let these two numbers be numbers[index1] and numbers[index2] where 1 <= index1 < index2 < numbers.length.

Return the indices of the two numbers, index1 and index2, added by one as an integer array [index1, index2] of length 2.

The tests are generated such that there is exactly one solution. You may not use the same element twice.

Your solution must use only constant extra space.

 

Example 1:

Input: numbers = [2,7,11,15], target = 9
Output: [1,2]
Explanation: The sum of 2 and 7 is 9. Therefore, index1 = 1, index2 = 2. We return [1, 2].

Example 2:

Input: numbers = [2,3,4], target = 6
Output: [1,3]
Explanation: The sum of 2 and 4 is 6. Therefore index1 = 1, index2 = 3. We return [1, 3].

Example 3:

Input: numbers = [-1,0], target = -1
Output: [1,2]
Explanation: The sum of -1 and 0 is -1. Therefore index1 = 1, index2 = 2. We return [1, 2].
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.TwoSumIIInputArrayIsSorted
{
    // Binary Search
    public class Solution
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                var start = i + 1;
                var end = numbers.Length - 1;
                var sum = target - numbers[i];
                while (start <= end)
                {
                    var mid = start + (end - start) / 2;
                    if (numbers[mid] == sum)
                    {
                        return new[] {i + 1, mid + 1};
                    }

                    if (numbers[mid] > sum)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
            }

            return new[] {0, 0};
        }
    }

    public class Test
    {
        public static bool[] TestTwoSumIIInputArrayIsSorted()
        {
            int[] nums1 = {2,7,11,15};
            int target1 = 9;
            int[] nums2 = {2,3,4};
            int target2 = 6;
            int[] nums3 = {-1,0};
            int target3 = -1;

            int[] result1 = Solution.TwoSum(nums1, target1);
            int[] result2 = Solution.TwoSum(nums2, target2);
            int[] result3 = Solution.TwoSum(nums3, target3);

            int[] expected1 = {1,2};
            int[] expected2 = {1,3};
            int[] expected3 = {1,2};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result1, expected1),
                ResultTester.CheckResult<int[]>(result2, expected2),
                ResultTester.CheckResult<int[]>(result3, expected3)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Two Sum II - Input Array Is Sorted");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestTwoSumIIInputArrayIsSorted());
        }
    }
}