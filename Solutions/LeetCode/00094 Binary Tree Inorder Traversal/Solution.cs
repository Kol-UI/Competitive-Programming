using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BinaryTreeInorderTraversal
{
    // Given the root of a binary tree, return the inorder traversal of its nodes' values.
    
    // Example 1:
    // Input: root = [1,null,2,3]
    // Output: [1,3,2]
    
    // Example 2:
    // Input: root = []
    // Output: []
    
    // Example 3:
    // Input: root = [1]
    // Output: [1]
    
    public class Solution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {

            var result = new List<int>();

            return InorderTraversal(root, result);
        }

        private IList<int> InorderTraversal(TreeNode current, IList<int> result)
        {
            if(current == null)
            return result;

            InorderTraversal(current.left, result);
            result.Add(current.val);
            InorderTraversal(current.right, result);

            return result;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Tree Inorder Traversal");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}