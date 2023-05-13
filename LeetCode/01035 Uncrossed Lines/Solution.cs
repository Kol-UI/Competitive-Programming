// Uncrossed Lines

/*
You are given two integer arrays nums1 and nums2. We write the integers of nums1 and nums2 (in the order they are given) on two separate horizontal lines.

We may draw connecting lines: a straight line connecting two numbers nums1[i] and nums2[j] such that:

nums1[i] == nums2[j], and
the line we draw does not intersect any other connecting (non-horizontal) line.
Note that a connecting line cannot intersect even at the endpoints (i.e., each number can only belong to one connecting line).

Return the maximum number of connecting lines we can draw in this way.

 

Example 1:

Input: nums1 = [1,4,2], nums2 = [1,2,4]
Output: 2
Explanation: We can draw 2 uncrossed lines as in the diagram.
We cannot draw 3 uncrossed lines, because the line from nums1[1] = 4 to nums2[2] = 4 will intersect the line from nums1[2]=2 to nums2[1]=2.

Example 2:

Input: nums1 = [2,5,1,2,5], nums2 = [10,5,2,1,5,2]
Output: 3
Example 3:

Input: nums1 = [1,3,7,1,7,5], nums2 = [1,9,2,5,1]
Output: 2
*/

using System;
namespace CompetitiveProgramming.LeetCode.UncrossedLines
{
    public class Solution
    {
        public static int Traverse(int idx1, int idx2, int[] nums1, int[] nums2, int[,] MemoArray)
        {

            if (idx2 >= nums2.Length || idx1 >= nums1.Length)
            {
                return 0;
            }

            if (MemoArray[idx1, idx2] != -1)
            {
                return MemoArray[idx1, idx2];
            }

            var res1 = 0;
            if (nums1[idx1] == nums2[idx2])
            {
                res1 = 1 + Traverse(idx1 + 1, idx2 + 1, nums1, nums2, MemoArray);
            }

            var res2 = Traverse(idx1, idx2 + 1, nums1, nums2, MemoArray);
            var res3 = Traverse(idx1 + 1, idx2, nums1, nums2, MemoArray);

            MemoArray[idx1, idx2] = Math.Max(Math.Max(res1, res2), res3);

            return MemoArray[idx1, idx2];
        }

        public static int MaxUncrossedLines(int[] nums1, int[] nums2)
        {
            int[,] MemoArray = new int[nums1.Length, nums2.Length];

            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    MemoArray[i, j] = -1;
                }
            }

            return Traverse(0, 0, nums1, nums2, MemoArray);
        }
    }
}