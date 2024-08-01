// Balanced Binary Tree

/*
Given a binary tree, determine if it is height-balanced.


Example 1:


Input: root = [3,9,20,null,null,15,7]
Output: true

Example 2:


Input: root = [1,2,2,3,3,null,null,4,4]
Output: false

Example 3:

Input: root = []
Output: true
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BalancedBinaryTree
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
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;
            if (Math.Abs(height(root.left) - height(root.right)) <= 1)
                return true && IsBalanced(root.left) && IsBalanced(root.right);
            else
                return false;
        }
        
        public int height(TreeNode node)
        {
            if (node == null)
                return 0;
            return 1 + Math.Max(height(node.left), height(node.right));
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Balanced Binary Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}