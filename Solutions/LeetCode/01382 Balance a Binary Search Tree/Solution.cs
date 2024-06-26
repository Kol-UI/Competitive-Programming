// Balance a Binary Search Tree

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BalanceaBinarySearchTree
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
    public class Solution {
        public TreeNode BalanceBST(TreeNode root) {
            var list = GetList(root);
            var result = GetTreeNode(0, list.Count - 1, list);
            return result;
        }
        private TreeNode GetTreeNode(int index0, int index1, List<int> list)
        {
            var result = new TreeNode();
            if (index1 - index0 == 0)
            {
                result.val = list[index1];
                return result;
            }
            if (index1 - index0 == 1)
            {
                result.val = list[index1];
                result.left = new TreeNode(list[index0]);
                return result;
            }
            var indexMid = (index1 + index0) / 2;
            result.val = list[indexMid];
            result.left = GetTreeNode(index0, indexMid - 1, list);
            result.right = GetTreeNode(indexMid + 1, index1, list);
            return result;
        }
        private List<int> GetList(TreeNode root)
        {
            var result = new List<int>();
            if (root.left != null) result.AddRange(GetList(root.left));
            result.Add(root.val);
            if (root.right != null) result.AddRange(GetList(root.right));
            return result;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Balance a Binary Search Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}