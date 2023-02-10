using System;

namespace CompetitiveProgramming.LeetCode.BinaryTreeInorderTraversal
{
    // Given the root of a binary tree, return the inorder traversal of its nodes' values.
    
    // Example 1:
    // Input: root = [1,null,2,3]
    // Output: [1,3,2]
    
    // Example 2:
    // Input: root = []
    // Output: []
    
    // Example 3:
    // Input: root = [1]
    // Output: [1]

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
    // public class Solution {
    //     public IList<int> InorderTraversal(TreeNode root) {

    //         var result = new List<int>();

    //         return InorderTraversal(root, result);
    //     }

    //     private IList<int> InorderTraversal(TreeNode current, IList<int> result)
    //     {
    //         if(current == null)
    //         return result;

    //         InorderTraversal(current.left, result);
    //         result.Add(current.val);
    //         InorderTraversal(current.right, result);

    //         return result;
    //     }
    // }
}