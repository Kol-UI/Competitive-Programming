// Construct String from Binary Tree


using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ConstructStringfromBinaryTree
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
    /*
    public class Solution
    {
        public string Tree2str(TreeNode root)
        {
            if (root == null)
            {
                return "";
            }
            
            StringBuilder result = new StringBuilder();
            
            PreorderTraversal(root, result);
            return result.ToString();
        }

        private void PreorderTraversal(TreeNode node, StringBuilder result)
        {
            if (node == null)
            {
                return;
            }
            
            result.Append(node.val);
            
            if (node.left != null || node.right != null)
            {
                result.Append("(");
                PreorderTraversal(node.left, result);
                result.Append(")");
            }
            
            if (node.right != null)
            {
                result.Append("(");
                PreorderTraversal(node.right, result);
                result.Append(")");
            }
            
        }
    }
    */
    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("606");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}