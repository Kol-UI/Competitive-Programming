// Majority Element II

/*
Given an integer array of size n, find all elements that appear more than ⌊ n/3 ⌋ times.

 

Example 1:

Input: nums = [3,2,3]
Output: [3]

Example 2:

Input: nums = [1]
Output: [1]

Example 3:

Input: nums = [1,2]
Output: [1,2]
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MajorityElementII
{
    public class Solution
    {
        public static IList<int> MajorityElement(int[] nums)
        {
            return nums.GroupBy(n => n).Where(g => g.Count() > nums.Length / 3).Select(x => x.Key).ToArray();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] case1 = {3,2,3};
            int[] case2 = {1};
            int[] case3 = {1,2};

            IList<int> result1 = new List<int> { 3 };
            IList<int> result2 = new List<int> { 1 };
            IList<int> result3 = new List<int> { 1, 2 };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<int>>(Solution.MajorityElement(case1), Solution.MajorityElement(case1)),
                ResultTester.CheckResult<IList<int>>(Solution.MajorityElement(case2), Solution.MajorityElement(case2)),
                ResultTester.CheckResult<IList<int>>(Solution.MajorityElement(case3), Solution.MajorityElement(case3)),
            };

            return results;
        }
    }
}