using System;

namespace CompetitiveProgramming.LeetCode.SymmetricTree
{
    // Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).

    // Example 1:
    // Input: root = [1,2,2,3,4,4,3]
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
    //     public bool check(TreeNode a, TreeNode b)
    //     {
    //         if(a == null && b == null)
    //             return true;

    //         if(a == null || b== null)
    //         return false;
            
    //         return a.val == b.val && check(a.left,b.right) && check(a.right, b.left);
    //     }

    //     public bool IsSymmetric(TreeNode root)
    //     {
    //         return check(root.left,root.right);
    //     }
    // }
}

