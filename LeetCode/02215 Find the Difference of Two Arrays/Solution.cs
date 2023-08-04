// Find the Difference of Two Arrays

/*
Given two 0-indexed integer arrays nums1 and nums2, return a list answer of size 2 where:

answer[0] is a list of all distinct integers in nums1 which are not present in nums2.
answer[1] is a list of all distinct integers in nums2 which are not present in nums1.
Note that the integers in the lists may be returned in any order.

 

Example 1:

Input: nums1 = [1,2,3], nums2 = [2,4,6]
Output: [[1,3],[4,6]]
Explanation:
For nums1, nums1[1] = 2 is present at index 0 of nums2, whereas nums1[0] = 1 and nums1[2] = 3 are not present in nums2. Therefore, answer[0] = [1,3].
For nums2, nums2[0] = 2 is present at index 1 of nums1, whereas nums2[1] = 4 and nums2[2] = 6 are not present in nums2. Therefore, answer[1] = [4,6].

Example 2:

Input: nums1 = [1,2,3,3], nums2 = [1,1,2,2]
Output: [[3],[]]
Explanation:
For nums1, nums1[2] and nums1[3] are not present in nums2. Since nums1[2] == nums1[3], their value is only included once and answer[0] = [3].
Every integer in nums2 is present in nums1. Therefore, answer[1] = [].
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindtheDifferenceofTwoArrays
{
    public class Solution
    {
        public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            HashSet<int> h1 = new HashSet<int>(nums1), h2 = new HashSet<int>(nums2);

            return new List<IList<int>>
            { 
                h1.Where(x => !h2.Contains(x)).ToList<int>(), 
                h2.Where(x => !h1.Contains(x)).ToList<int>() 
            };
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1_Case1 = {1,2,3};
            int[] nums2_Case1 = {2,4,6};

            int[] nums1_Case2 = {1,2,3,3};
            int[] nums2_Case2 = {1,1,2,2};

            IList<IList<int>> listOfLists1 = Solution.FindDifference(nums1_Case1, nums2_Case1);
            IList<IList<int>> listOfLists2 = Solution.FindDifference(nums1_Case2, nums2_Case2);

            IList<IList<int>> output1_2215 = new List<IList<int>>();
            IList<IList<int>> output2_2215 = new List<IList<int>>();
            IList<int> innerList1 = new List<int> { 1, 3 };
            IList<int> innerList2 = new List<int> { 4, 6 };
            output1_2215.Add(innerList1);
            output1_2215.Add(innerList2);
            IList<int> innerList3 = new List<int> { 3 };
            IList<int> innerList4 = new List<int> {  };
            output2_2215.Add(innerList3);
            output2_2215.Add(innerList4);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<IList<int>>>(listOfLists1, output1_2215),
                ResultTester.CheckResult<IList<IList<int>>>(listOfLists2, output2_2215)
            };
            return results;
        }
    }
}