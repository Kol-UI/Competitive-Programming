// Minimum Operations to Reduce X to Zero

/*
You are given an integer array nums and an integer x. In one operation, you can either remove the leftmost or the rightmost element from the array nums and subtract its value from x. Note that this modifies the array for future operations.

Return the minimum number of operations to reduce x to exactly 0 if it is possible, otherwise, return -1.

 

Example 1:

Input: nums = [1,1,4,2,3], x = 5
Output: 2
Explanation: The optimal solution is to remove the last two elements to reduce x to zero.

Example 2:

Input: nums = [5,6,7,8,9], x = 4
Output: -1

Example 3:

Input: nums = [3,2,20,1,1,3], x = 10
Output: 5
Explanation: The optimal solution is to remove the last three elements and the first two elements (5 operations in total) to reduce x to zero.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumOperationstoReduceXtoZero
{
    public class Solution
    {
        public static int MinOperations(int[] nums, int x)
        {
            var sum = nums.Sum() - x;

            if (sum == 0) return nums.Length;
            
            var index0 = 0;
            var index1 = 0;
            var currSum = nums[index0];
            var rs = -1;

            while (index0 != nums.Length - 1 || index1 != nums.Length - 1)
            {
                if (currSum < sum)
                {
                    if (index1 + 1 < nums.Length)
                    {
                        index1++;
                        currSum += nums[index1];
                    }
                    else
                    {
                        index0 = nums.Length - 1;
                    }
                }
                else
                {
                    if (currSum > sum)
                    {
                        if(index0 < index1)
                        {
                            currSum -= nums[index0];
                            index0++;
                        }
                        else
                        {
                            index0++;
                            index1++;
                            currSum = nums[index0];
                        }
                    }
                    else
                    {
                        var rs0 = nums.Length - (index1 - index0 + 1);
                        rs = rs == -1 ? rs0 : Math.Min(rs, rs0);
                        if(index0 < index1)
                        {
                            currSum -= nums[index0];
                            index0++;
                        }
                        else
                        {
                            index0++;
                            index1++;
                            currSum = nums[index0];
                        }
                    }
                }

            }
            if (nums[index0] == sum && rs == -1) rs = nums.Length - 1;
            return rs;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1 = {1,1,4,2,3};
            int[] nums2 = {5,6,7,8,9};
            int[] nums3 = {1,1,4,2,3};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinOperations(nums1, 5), 2),
                ResultTester.CheckResult<int>(Solution.MinOperations(nums2, 4), -1),
                ResultTester.CheckResult<int>(Solution.MinOperations(nums3, 10), 4),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Minimum Operations to reduce X to Zero");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}