// Delete Leaves With a Given Value

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DeleteLeavesWithaGivenValue
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
        public TreeNode RemoveLeafNodes(TreeNode root, int target)
        {
            if (root == null)
            {
                return null!;
            }
            
            Stack<TreeNode> stack = new Stack<TreeNode>();
            Stack<TreeNode> processStack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                processStack.Push(node);
                if (node.left != null)
                {
                    stack.Push(node.left);
                }
                if (node.right != null)
                {
                    stack.Push(node.right);
                }
            }

            while (processStack.Count > 0)
            {
                TreeNode node = processStack.Pop();
                if (node.left != null && node.left.val == target && node.left.left == null && node.left.right == null)
                {
                    node.left = null!;
                }
                if (node.right != null && node.right.val == target && node.right.left == null && node.right.right == null)
                {
                    node.right = null!;
                }
            }

            if (root.val == target && root.left == null && root.right == null)
            {
                return null!;
            }

            return root;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Delete leaves With a Given Value");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}