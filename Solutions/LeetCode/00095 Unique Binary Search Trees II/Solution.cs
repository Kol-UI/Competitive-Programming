// Unique Binary Search Trees II

/*
Given an integer n, return all the structurally unique BST's (binary search trees), which has exactly n nodes of unique values from 1 to n. Return the answer in any order.

 

Example 1:


Input: n = 3
Output: [[1,null,2,null,3],[1,null,3,2],[2,1,3],[3,1,null,null,2],[3,2,null,1]]

Example 2:

Input: n = 1
Output: [[1]]
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.UniqueBinarySearchTreesII
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
    /*
    public class Solution
    {
        private Dictionary<string, List<TreeNode>> memo = new Dictionary<string, List<TreeNode>>();

        public IList<TreeNode> GenerateTrees(int n)
        {
            return GenerateTrees(1, n);
        }

        private List<TreeNode> GenerateTrees(int start, int end)
        {
            List<TreeNode> result = new List<TreeNode>();
            
            if (start > end)
            {
                result.Add(null);
                return result;
            }
            
            string key = $"{start}-{end}";
            if (memo.ContainsKey(key))
            {
                return memo[key];
            }
            
            for (int rootValue = start; rootValue <= end; rootValue++)
            {
                List<TreeNode> leftSubtrees = GenerateTrees(start, rootValue - 1);
                List<TreeNode> rightSubtrees = GenerateTrees(rootValue + 1, end);
                
                foreach (var leftSubtree in leftSubtrees)
                {
                    foreach (var rightSubtree in rightSubtrees)
                    {
                        TreeNode root = new TreeNode(rootValue);
                        root.left = leftSubtree;
                        root.right = rightSubtree;
                        result.Add(root);
                    }
                }
            }
            
            memo[key] = result;
            return result;
        }
    }
    */


    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Unique Binary Search Trees II");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}