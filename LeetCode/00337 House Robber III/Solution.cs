using System;
namespace CompetitiveProgramming.LeetCode.HouseRobberIII
{
	public class Solution
	{
        //The thief has found himself a new place for his thievery again.There is only one entrance to this area, called root.

        //Besides the root, each house has one and only one parent house.After a tour, the smart thief realized that all houses in this place form a binary tree.It will automatically contact the police if two directly-linked houses were broken into on the same night.

        //Given the root of the binary tree, return the maximum amount of money the thief can rob without alerting the police.

        /* public class TreeNode
        {
          public int val;
          public TreeNode left;
          public TreeNode right;
          public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
          {
            this.val = val;
            this.left = left;
            this.right = right;
          }
        }

        public int Rob(TreeNode root)
        {
            return RobHelper(root).Item1;
        }

        private Tuple<int, int> RobHelper(TreeNode root)
        {
            if (root == null) return new Tuple<int, int>(0, 0);
            if (root.left == null && root.right == null) return new Tuple<int, int>(root.val, 0);
            Tuple<int, int> left = RobHelper(root.left);
            Tuple<int, int> right = RobHelper(root.right);
            int currentMax = Math.Max(root.val + left.Item2 + right.Item2, left.Item1 + right.Item1);
            return new Tuple<int, int>(currentMax, left.Item1 + right.Item1);
        } */
    }
}

