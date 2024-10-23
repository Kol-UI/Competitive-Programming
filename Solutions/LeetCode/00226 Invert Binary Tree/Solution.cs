using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.InvertBinaryTree
{
    public class Solution
    {
        //Given the root of a binary tree, invert the tree, and return its root.
        // Example:
        // Input: root = [4,2,7,1,3,6,9]
        // Output: [4,7,2,9,6,3,1]
        
        // public class TreeNode
        // {
        // public int val;
        // public TreeNode left;
        // public TreeNode right;
        // public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        //     this.val = val;
        //     this.left = left;
        //     this.right = right;
        // }
        // }

        // public TreeNode InvertTree(TreeNode root)
        // {
        //     if (root == null)
        //         return root;
        //     Invert(root);
        //     return root;
        // }
        // public void Invert(TreeNode node)
        // {
        //     if (node == null)
        //         return;
        //     Invert(node.left);
        //     Invert(node.right);
        //     var a = node.left;
        //     node.left = node.right;
        //     node.right = a;
        // }


        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null!;

            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;

            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Invert Binary Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}