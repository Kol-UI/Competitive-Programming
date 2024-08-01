// Kth Smallest Element in a BST

/*
Given the root of a binary search tree, and an integer k, return the kth smallest value (1-indexed) of all the values of the nodes in the tree.


Example 1:

Input: root = [3,1,4,null,2], k = 1
Output: 1

Example 2:

Input: root = [5,3,6,2,4,null,null,1], k = 3
Output: 3
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.KthSmallestElementinaBST
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
        static int count = 0;
        static int num = 0;

        public static int KthSmallest(TreeNode root, int k)
        {
            count = k;
            traverseBSTInorder(root);
            return num;
        }

        public static void traverseBSTInorder(TreeNode root)
        {
            if (root.left is not null)
                traverseBSTInorder(root.left);
            
            count -= 1;

            if (count == 0)
            {
                num = root.val;
                return;
            }
            
            if (root.right is not null)
                traverseBSTInorder(root.right);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Kth Smallest Element in a BST");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}