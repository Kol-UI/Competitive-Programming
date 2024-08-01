using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BinaryTreeZigzagLevelOrderTraversal
{
    public class Solution
    {
        //Given the root of a binary tree, return the zigzag level order traversal of its nodes' values. (i.e., from left to right, then right to left for the next level and alternate between)
        // Example 1:
        // Input: root = [3,9,20,null,null,15,7]
        // Output: [[3],[20,9],[15,7]]
        // Example 2:
        // Input: root = [1]
        // Output: [[1]]
        // Example 3:
        // Input: root = []
        // Output: []
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            List<IList<int>> ret = new();
            if (root == null) return ret;
            ZigzagLevelOrderSub(root, ret, 0);
            return ret;        
        }
        private void ZigzagLevelOrderSub(TreeNode nd, List<IList<int>> ret, int level)
        {
            if (ret.Count < level + 1) ret.Add(new List<int>());
            if (level % 2 == 0)
                ret[level].Add(nd.val);
            else
                ret[level].Insert(0, nd.val);

            if (nd.left != null) ZigzagLevelOrderSub(nd.left, ret, level + 1);
            if (nd.right != null) ZigzagLevelOrderSub(nd.right, ret, level + 1);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Tree Zigzag Level Order Traversal");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}