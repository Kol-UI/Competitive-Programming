using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SearchInsertPosition
{
    // Given a sorted array of distinct integers and a target value, return the index if the target is found.
    // If not, return the index where it would be if it were inserted in order.
    // You must write an algorithm with O(log n) runtime complexity.

    // Example 1:
    // Input: nums = [1,3,5,6], target = 5
    // Output: 2
    
    // Example 2:
    // Input: nums = [1,3,5,6], target = 2
    // Output: 1
    
    // Example 3:
    // Input: nums = [1,3,5,6], target = 7
    // Output: 4

    public class Solution
    {
        public static int SearchInsert(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return left;
        }
    }

    public class Test
    {
        public static bool[] TestSearchInsertPosition()
        {
            System.Random random = new System.Random();

            // Case 1
            int[] Case1_35 = { 1, 3, 5, 6 };
            int targetCase1_35 = 5;
            int resultCase1_35 = Solution.SearchInsert(Case1_35, targetCase1_35);

            // Case 2
            int[] Case2_35 = { 1, 3, 5, 6 };
            int targetCase2_35 = 2;
            int resultCase2_35 = Solution.SearchInsert(Case2_35, targetCase2_35);

            // Case 3
            int[] Case3_35 = { 1, 3, 5, 6 };
            int targetCase3_35 = 7;
            int resultCase3_35 = Solution.SearchInsert(Case3_35, targetCase3_35);

            // Case 4
            int[] Case4_35 = { 1, 3, 5, 6 };
            int targetCase4_35 = random.Next(1, 10);
            int resultCase4_35 = Solution.SearchInsert(Case4_35, targetCase4_35);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(resultCase1_35, 2),
                ResultTester.CheckResult<int>(resultCase2_35, 1),
                ResultTester.CheckResult<int>(resultCase3_35, 4),
                ResultTester.CheckResult<int>(resultCase4_35, resultCase4_35)
            };
            return results;
        }
    }
}


