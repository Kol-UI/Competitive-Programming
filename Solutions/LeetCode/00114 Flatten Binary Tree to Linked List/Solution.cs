// Flatten Binary Tree to Linked List


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FlattenBinaryTreetoLinkedList
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
        public static void Flatten(TreeNode root)
        {
            FlattenRec(root);
        }

        private static TreeNode FlattenRec(TreeNode root)
        {
            if(root == null) return null!;

            var temp = FlattenRec(root.right);
            root.right = FlattenRec(root.left);
            root.left = null!;

            TreeNode last = root;
            while(last.right != null)
            {
                last = last.right;
            }
            last.right = temp;
            return root;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Flatten Binary Tree to Linked List");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}