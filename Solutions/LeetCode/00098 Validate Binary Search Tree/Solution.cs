using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ValidateBinarySearchTree
{
    // Given the root of a binary tree, determine if it is a valid binary search tree (BST).

    // A valid BST is defined as follows:

    // The left subtree of a node contains only nodes with keys less than the node's key.
    // The right subtree of a node contains only nodes with keys greater than the node's key.
    // Both the left and right subtrees must also be binary search trees.

    // Example:
    // Input: root = [5,1,4,null,null,3,6]
    // Output: false
    // Explanation: The root node's value is 5 but its right child's value is 4.

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
    //     public bool IsValidBST(TreeNode root)
    //     {
    //         return BstTraversal(root, null, null);
    //     }

    //     private bool BstTraversal(TreeNode node, TreeNode leftParent, TreeNode rightParent)
    //     {
    //         if (node == null) return true;

    //         var isValid = (leftParent == null || node.val < leftParent.val) && (rightParent == null || node.val > rightParent.val);

    //         return isValid && BstTraversal(node.left, node, rightParent) && BstTraversal(node.right, leftParent, node);
    //     }
    // }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Validate Binary Search Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}