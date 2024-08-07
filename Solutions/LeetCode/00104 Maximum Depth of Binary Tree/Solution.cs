using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumDepthofBinaryTree
{
    // Given the root of a binary tree, return its maximum depth.

    // A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.

    // Example 1:
    // Input: root = [3,9,20,null,null,15,7]
    // Output: 3

    // Example 2:

    // Input: root = [1,null,2]
    // Output: 2

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
    //     public int MaxDepth(TreeNode root) 
    //     {
    //         if (root == null)
    //         {
    //             return 0;
    //         }
    //         return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
    //     }
    // }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Depth of Binary Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}