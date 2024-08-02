// Subtree of Another Tree

/*
Given the roots of two binary trees root and subRoot, return true if there is a subtree of root with the same structure and node values of subRoot and false otherwise.

A subtree of a binary tree tree is a tree that consists of a node in tree and all of this node's descendants. The tree tree could also be considered as a subtree of itself.

 

Example 1:


Input: root = [3,4,5,1,2], subRoot = [4,1,2]
Output: true


Example 2:


Input: root = [3,4,5,1,2,null,null,null,null,0], subRoot = [4,1,2]
Output: false
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.SubtreeofAnotherTree
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
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if(root == null)
            {
                return root == subRoot;
            }
            if(root.val == subRoot.val && DFS(root, subRoot))
            {
                return true;
            }
            
            return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
        }
        
        private bool DFS(TreeNode root, TreeNode subRoot)
        {
            if(root == null && subRoot == null)
            {
                return true;
            }
            if(root == null || subRoot == null || root.val != subRoot.val)
            {
                return false;
            }
            return DFS(root.left, subRoot.left) && DFS(root.right, subRoot.right);        
        }
    }
    
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Subtree of Another Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}