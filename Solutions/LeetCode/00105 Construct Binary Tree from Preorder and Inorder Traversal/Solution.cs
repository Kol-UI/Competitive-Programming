// Construct Binary Tree from Preorder and Inorder Traversal

/*
Given two integer arrays preorder and inorder where preorder is the preorder traversal of a binary tree and inorder is the inorder traversal of the same tree, construct and return the binary tree.

 

Example 1:

Input: preorder = [3,9,20,15,7], inorder = [9,3,15,20,7]
Output: [3,9,20,null,null,15,7]

Example 2:

Input: preorder = [-1], inorder = [-1]
Output: [-1]
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ConstructBinaryTreefromPreorderandInorderTraversal
{
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
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            return BuildTree(0, preorder.Length - 1, preorder, 0, inorder.Length - 1, inorder);
        }

        private TreeNode BuildTree(int startPre, int endPre, int[] preorder, int startIn, int endIn, int[] inorder)
        {
            var rs = new TreeNode(preorder[startPre]);
            var index = Array.IndexOf(inorder, preorder[startPre]);
            var leftLength = index - startIn;

            if (leftLength > 0) rs.left = BuildTree(startPre + 1, startPre + leftLength, preorder, startIn, index - 1, inorder);

            var  rightLength = endIn - index;

            if (rightLength > 0) rs.right = BuildTree(startPre + leftLength + 1, endPre, preorder, index + 1, endIn, inorder);
            
            return rs;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Construct Binary Tree from Preorder and Inorder Traversal");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}