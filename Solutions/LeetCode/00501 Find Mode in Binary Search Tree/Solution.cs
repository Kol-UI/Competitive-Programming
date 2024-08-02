// Find Mode in Binary Search Tree


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.FindModeinBinarySearchTree
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
        private int? current_val = null;
        private int current_count = 0;
        private int max_count = 0;
        private List<int> modes = new List<int>();

        public int[] FindMode(TreeNode root)
        {
            in_order_traversal(root);
            return modes.ToArray();
        }

        private void in_order_traversal(TreeNode node)
        {
            if (node == null) return;

            in_order_traversal(node.left);

            current_count = (node.val == current_val) ? current_count + 1 : 1;
            if (current_count == max_count)
            {
                modes.Add(node.val);
            }
            else if (current_count > max_count)
            {
                max_count = current_count;
                modes.Clear();
                modes.Add(node.val);
            }
            current_val = node.val;

            in_order_traversal(node.right);
        }
    }
    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("501");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}