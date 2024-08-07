using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BinarySearch
{

/*
    Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.
    You must write an algorithm with O(log n) runtime complexity.

    Example 1:
    Input: nums = [-1,0,3,5,9,12], target = 9
    Output: 4
    Explanation: 9 exists in nums and its index is 4
    
    Example 2:
    Input: nums = [-1,0,3,5,9,12], target = 2
    Output: -1
    Explanation: 2 does not exist in nums so return -1
*/

    public class Solution
    {
        public static int Search(int[] nums, int target)
        {
            int highestInt = nums.Length - 1;
            int lowestInt = 0;

            while (lowestInt <= highestInt)
            {
                int mid = (lowestInt + highestInt) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[mid] < target)
                { 
                    lowestInt = mid + 1;
                }

                else 
                {
                    highestInt = mid - 1;
                }
            }

            return -1;
        }
    }

    public class Test
    {
        public static bool[] TestBinarySearch()
        {
            // Case 1
            int[] nums704_1 = {-1,0,3,5,9,12};
            int target704_1 = 9;
            int result704_1 = Solution.Search(nums704_1, target704_1);

            // Case 2
            StyleHelper.Space();
            int[] nums704_2 = {-1,0,3,5,9,12};
            int target704_2 = 2;
            int result704_2 = Solution.Search(nums704_2, target704_2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result704_1, 4),
                ResultTester.CheckResult<int>(result704_2, -1)
            };

            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Search");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestBinarySearch());
        }
    }
}