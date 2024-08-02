// Add One Row to Tree


using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.AddOneRowtoTree
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
        /*
        public TreeNode? AddOneRow(TreeNode? root, int val, int depth)
        {
            if (depth is 0 or 1)
            {
                return new TreeNode(val)
                {
                    left = depth == 1 ? root : null,
                    right = depth == 0 ? root : null
                };
            }

            if (root != null && depth >= 2)
            {
                root.left = AddOneRow(root.left, val, depth > 2 ? depth - 1 : 1);
                root.right = AddOneRow(root.right, val, depth > 2 ? depth - 1 : 0);
            }

            return root;
        }
        */
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("AAdd One Row to Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}