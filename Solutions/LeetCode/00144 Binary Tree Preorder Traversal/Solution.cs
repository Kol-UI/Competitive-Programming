using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BinaryTreePreorderTraversal
{

    // Given the root of a binary tree, return the preorder traversal of its nodes' values.

    //Exemple 1:
    //Input: root = [1,null,2,3]
    //Output: [1,2,3]
    //Example 2:
    //Input: root = []
    //Output: []
    //Example 3:
    //Input: root = [1]
    //Output: [1]
 
    public class Solution
    {
        public static IList<int> PreorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                var current = stack.Pop();
                if (current != null)
                {
                    result.Add(current.val);
                    stack.Push(current.right);
                    stack.Push(current.left);
                }
            }

            return result;
        }
    }

    public class Solution2
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            PreorderHelper(root, result);
            return result;
        }

        public void PreorderHelper(TreeNode root, IList<int> result)
        {
            if (root == null)
                return;
            
            result.Add(root.val);
            PreorderHelper(root.left, result);
            PreorderHelper(root.right, result);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Tree Preorder Traversal");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}