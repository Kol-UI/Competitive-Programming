// All Possible Full Binary Trees

/*
Given an integer n, return a list of all possible full binary trees with n nodes. Each node of each tree in the answer must have Node.val == 0.

Each element of the answer is the root node of one possible tree. You may return the final list of trees in any order.

A full binary tree is a binary tree where each node has exactly 0 or 2 children.

 

Example 1:

Input: n = 7
Output: [[0,0,0,null,null,0,0,null,null,0,0],[0,0,0,null,null,0,0,0,0],[0,0,0,0,0,0,0],[0,0,0,0,0,null,null,null,null,0,0],[0,0,0,0,0,null,null,0,0]]

Example 2:

Input: n = 3
Output: [[0,0,0]]
*/

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.AllPossibleFullBinaryTrees
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
        public IList<TreeNode> AllPossibleFBT(int n) {
            if (n % 2 == 0)
                return new List<TreeNode>(); 

            return GenerateFullBinaryTrees(n);
        }

        private IList<TreeNode> GenerateFullBinaryTrees(int n)
        {
            IList<TreeNode> result = new List<TreeNode>();

            if (n == 1)
            {
                result.Add(new TreeNode(0));
                return result;
            }

            for (int i = 1; i < n; i += 2)
            {
                IList<TreeNode> leftSubtrees = GenerateFullBinaryTrees(i);
                IList<TreeNode> rightSubtrees = GenerateFullBinaryTrees(n - i - 1);

                foreach (var leftSubtree in leftSubtrees)
                {
                    foreach (var rightSubtree in rightSubtrees)
                    {
                        TreeNode root = new TreeNode(0);
                        root.left = leftSubtree;
                        root.right = rightSubtree;
                        result.Add(root);
                    }
                }
            }

            return result;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("All Possible Full Binary Trees");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}