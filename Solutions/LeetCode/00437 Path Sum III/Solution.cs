// Path Sum III

/*
Given the root of a binary tree and an integer targetSum, return the number of paths where the sum of the values along the path equals targetSum.

The path does not need to start or end at the root or a leaf, but it must go downwards (i.e., traveling only from parent nodes to child nodes).

 

Example 1:

Input: root = [10,5,-3,3,2,null,11,3,-2,null,1], targetSum = 8
Output: 3
Explanation: The paths that sum to 8 are shown.

Example 2:

Input: root = [5,4,8,11,null,13,4,7,2,null,null,5,1], targetSum = 22
Output: 3
*/


using System;
namespace CompetitiveProgramming.LeetCode.PathSumIII
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
        public int PathSum(TreeNode root, int targetSum)
        {
            if (root == null) return 0;

            return CalcSum(root, targetSum) + PathSum(root.left, targetSum) + PathSum(root.right, targetSum);
        }

        private int CalcSum(TreeNode node, long targetSum)
        {
            if (node == null) return 0;

            return (node.val == targetSum ? 1 : 0) + CalcSum(node.left, targetSum - node.val) + CalcSum(node.right, targetSum - node.val);
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Path Sum III");
            TestDrivenDevelopment.ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}