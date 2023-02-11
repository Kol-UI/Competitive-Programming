using System;
namespace CompetitiveProgramming.LeetCode.TwoSumIVInputisaBST
{
    // Given the root of a binary search tree and an integer k, return true if there exist two elements in the BST such that their sum is equal to k, or false otherwise.

    // Example 1:
    // Input: root = [5,3,6,2,4,null,7], k = 9
    // Output: true

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
    // public class Solution
    // {
    //     HashSet<int> seen = new();
    //     public bool FindTarget(TreeNode root, int k)
    //     {
    //         if (root is null) return false;
    //         if (seen.Contains(k - root.val)) return true;
    //         seen.Add(root.val);
    //         return FindTarget(root.left, k) || FindTarget(root.right, k);
    //     }
    // }
}