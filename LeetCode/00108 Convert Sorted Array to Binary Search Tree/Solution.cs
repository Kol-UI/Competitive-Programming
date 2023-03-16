using System;
namespace CompetitiveProgramming.LeetCode.ConvertSortedArraytoBinarySearchTree
{
    // Given an integer array nums where the elements are sorted in ascending order, convert it to a height-balanced binary search tree.

    // Example 1:

    // Input: nums = [-10,-3,0,5,9]
    // Output: [0,-3,9,-10,null,5]
    // Explanation: [0,-10,5,null,-3,null,9] is also accepted

    // Example 2:

    // Input: nums = [1,3]
    // Output: [3,1]
    // Explanation: [1,null,3] and [3,1] are both height-balanced BSTs.

    /**
    * Definition for a binary tree node.
    * public class TreeNode {
    *     public int val;
    *     public TreeNode left;
    *     public TreeNode right;
    *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
    *         this.val = val;
    *         this.left = left;
    *         this.right = right;
    *     }
    * }
    */
    public class Solution
    {
        public static TreeNode SortedArrayToBST(int[] nums)
        {
            var node = new TreeNode();
            if (nums.Length == 1)
            {
                node.val = nums[0];

                // Print
                Program.PrintArray(nums);
                
                return node;
            }

            var midIndex = (int)(Math.Ceiling(((float)nums.Length / 2))) - 1;
            node.val = nums[midIndex];
            if(midIndex >= 1)
            {
                node.left = SortedArrayToBST(nums[..midIndex]);
            }

            var rightEndIndex = midIndex + 1;

            if(rightEndIndex <= nums.Length - 1)
            {
                node.right = SortedArrayToBST(nums[rightEndIndex..]);
            }

            // Print
            Program.PrintArray(nums);
            return node;
        }
    }
}