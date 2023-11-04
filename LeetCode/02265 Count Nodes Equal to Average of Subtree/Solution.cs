// Count Nodes Equal to Average of Subtree


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.CountNodesEqualtoAverageofSubtree
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
        private int count = 0;
        
        public int AverageOfSubtree(TreeNode root)
        {
            PostOrder(root);
            return count;
        }

        private Tuple<int, int> PostOrder(TreeNode root)
        {
            if (root == null)
            {
                return new Tuple<int, int>(0, 0);
            }

            Tuple<int, int> left = PostOrder(root.left);
            Tuple<int, int> right = PostOrder(root.right);

            int nodeSum = left.Item1 + right.Item1 + root.val;
            int nodeCount = left.Item2 + right.Item2 + 1;

            if (root.val == nodeSum / nodeCount)
            {
                count++;
            }

            return new Tuple<int, int>(nodeSum, nodeCount);
        }
    }
}