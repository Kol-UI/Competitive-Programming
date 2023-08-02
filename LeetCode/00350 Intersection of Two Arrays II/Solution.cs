using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.IntersectionofTwoArraysII
{
    //Given two integer arrays nums1 and nums2, return an array of their intersection.Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.
    //Example 1:
    //Input: nums1 = [1, 2, 2, 1], nums2 = [2, 2]
    //Output: [2,2]
    //Example 2:
    //Input: nums1 = [4, 9, 5], nums2 = [9, 4, 9, 8, 4]
    //Output: [4,9]
    //Explanation: [9,4] is also accepted.


    public class Solution
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {

            Dictionary<int, int> d = new Dictionary<int, int>();
            foreach (int elem in nums1)
            {
                if (d.ContainsKey(elem))
                {
                    d[elem]++;
                }
                else
                    d.Add(elem, 1);
            }
            List<int> list = new List<int>();
            foreach (int elem in nums2)
            {
                if (d.ContainsKey(elem))
                {
                    list.Add(elem);
                    d[elem]--;
                    if (d[elem] == 0)
                        d.Remove(elem);
                }
            }
            int[] n = new int[list.Count];
            int i = 0;
            foreach (int elem in list)
            {
                n[i] = elem;
                i++;
            }

            return n;
        }
    }

    public class Test
    {
        public static bool[] TestIntersectionofTwoArraysII()
        {
            int[] nums1_1 = {1, 2, 2, 1}; 
            int[] nums2_1 = {2, 2};
            int[] nums1_2 = {4, 9, 5}; 
            int[] nums2_2 = {9, 4, 9, 8, 4};
            int[] expected1 = {2,2}; 
            int[] expected2 = {9,4};

            int[] result1 = Solution.Intersect(nums1_1, nums2_1);
            int[] result2 = Solution.Intersect(nums1_2, nums2_2); 

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result1, expected1),
                ResultTester.CheckResult<int[]>(result2, expected2)
            };
            return results;
        }
    }
}

