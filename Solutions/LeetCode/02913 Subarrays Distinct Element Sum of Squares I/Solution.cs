// Subarrays Distinct Element Sum of Squares I

/*
You are given a 0-indexed integer array nums.

The distinct count of a subarray of nums is defined as:

Let nums[i..j] be a subarray of nums consisting of all the indices from i to j such that 0 <= i <= j < nums.length. Then the number of distinct values in nums[i..j] is called the distinct count of nums[i..j].
Return the sum of the squares of distinct counts of all subarrays of nums.

A subarray is a contiguous non-empty sequence of elements within an array.

 

Example 1:

Input: nums = [1,2,1]
Output: 15
Explanation: Six possible subarrays are:
[1]: 1 distinct value
[2]: 1 distinct value
[1]: 1 distinct value
[1,2]: 2 distinct values
[2,1]: 2 distinct values
[1,2,1]: 2 distinct values
The sum of the squares of the distinct counts in all subarrays is equal to 12 + 12 + 12 + 22 + 22 + 22 = 15.

Example 2:

Input: nums = [1,1]
Output: 3
Explanation: Three possible subarrays are:
[1]: 1 distinct value
[1]: 1 distinct value
[1,1]: 1 distinct value
The sum of the squares of the distinct counts in all subarrays is equal to 12 + 12 + 12 = 3.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.SubarraysDistinctElementSumofSquaresI
{
    public class Solution
    {
        public static int SumCounts(IList<int> nums)
        {
            var list = new List<int>(nums);
            if(list.Count == 1) 
                return 1;
            var result = 0;

            for(var i = 0; i < list.Count; i++)
            {
                var h = new HashSet<int>();
                var index = i;
                while(index < list.Count)
                {
                    h.Add(list[index]);
                    result += h.Count * h.Count;
                    index++;   
                }
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1 = {1,2,1};
            int[] nums2 = {1,1};
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.SumCounts(nums1), 15),
                ResultTester.CheckResult<int>(Solution.SumCounts(nums2), 3),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2913");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}