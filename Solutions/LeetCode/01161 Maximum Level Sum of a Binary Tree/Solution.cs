// Maximum Level Sum of a Binary Tree

/*
Given the root of a binary tree, the level of its root is 1, the level of its children is 2, and so on.

Return the smallest level x such that the sum of all the values of nodes at level x is maximal.


Example 1:

Input: root = [1,7,0,7,-8,null,null]
Output: 2
Explanation: 
Level 1 sum = 1.
Level 2 sum = 7 + 0 = 7.
Level 3 sum = 7 + -8 = -1.
So we return the level with the maximum sum which is level 2.

Example 2:

Input: root = [989,null,10250,98693,-89388,null,null,null,-32127]
Output: 2
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MaximumLevelSumofaBinaryTree
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
        public int MaxLevelSum(TreeNode root)
        {
            var nextLevelNodes = new List<TreeNode>();
            int maxSum = int.MinValue;
            int minLevel = 1;
            int level = 0;

            nextLevelNodes.Add(root);

            while(nextLevelNodes.Count > 0)
            {
                level++;
                int sum = 0;
                var currentNodes = nextLevelNodes;
                nextLevelNodes = new List<TreeNode>();

                foreach(var node in currentNodes)
                {
                    sum += node.val;

                    if(node.left != null) nextLevelNodes.Add(node.left);

                    if(node.right != null) nextLevelNodes.Add(node.right);
                }

                if(sum > maxSum)
                {
                    maxSum = sum;
                    minLevel = level;
                }
            }

            return minLevel;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Maximum Level Sum of a Binary Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}