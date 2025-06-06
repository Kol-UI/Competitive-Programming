using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LowestCommonAncestorofaBinarySearchTree
{
    #nullable disable
    public class Solution
    {
        // Given a binary search tree (BST), find the lowest common ancestor (LCA) node of two given nodes in the BST.

        // According to the definition of LCA on Wikipedia: “The lowest common ancestor is defined between two nodes p and q as the lowest node in T that has both p and q as descendants (where we allow a node to be a descendant of itself).”
        
        // Example 1:
        // Input: root = [6,2,8,0,4,7,9,null,null,3,5], p = 2, q = 8
        // Output: 6
        // Explanation: The LCA of nodes 2 and 8 is 6.
        // /**
        // * Definition for a binary tree node.
        // * public class TreeNode {
        // *     public int val;
        // *     public TreeNode left;
        // *     public TreeNode right;
        // *     public TreeNode(int x) { val = x; }
        // * }
        // */

        // public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        // {
        //     if(root == null) return null;
        //     if(root.val == p.val || root.val == q.val) return root;
            
        //     TreeNode left = LowestCommonAncestor(root.left, p, q);
        //     TreeNode right = LowestCommonAncestor(root.right, p, q);


        //         if(left != null && right != null) return root;

        //         if(left != null) return left;

        //         return right;
        // }


        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || p == null || q == null) return null;

            if (Math.Max(p.val, q.val) < root.val)
            {
                return LowestCommonAncestor(root.left, p, q);
            }
            else if (Math.Min(p.val, q.val) > root.val)
            {
                return LowestCommonAncestor(root.right, p, q);
            }
            else
            {
                return root;
            }
        }
    }
    #nullable enable

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Lowest Common Ancestor of a Binary Search Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}