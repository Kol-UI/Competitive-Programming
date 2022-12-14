using System;
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
}

