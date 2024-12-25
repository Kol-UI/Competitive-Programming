using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BinaryTreePostorderTraversal
{
    // Given the root of a binary tree, return the postorder traversal of its nodes' values.
    
    // Example 1:
    // Input: root = [1,null,2,3]
    // Output: [3,2,1]
    
    // Example 2:
    // Input: root = []
    // Output: []
    
    // Example 3:
    // Input: root = [1]
    // Output: [1]

    public class Solution
    {
        private IList<int> list=new List<int>();
        private Stack<TreeNode> s=new Stack<TreeNode>();
        private HashSet<TreeNode> visited=new HashSet<TreeNode>();
        public IList<int> PostorderTraversal(TreeNode root)
        {
            if(root==null) return list;
            s.Push(root);
            while(s.Count>0)
            {
                TreeNode node=s.Pop();
                if(!visited.Contains(node))
                {
                    visited.Add(node);
                    s.Push(node);
                    if(node.right!=null) s.Push(node.right);
                    if(node.left!=null) s.Push(node.left);
                }
                else
                    list.Add(node.val);         
            }
            return list;   
        }
    }

    public class Solution2
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            PostOrderHelper(root, result);
            return result;
        }

        public void PostOrderHelper(TreeNode root, IList<int> result)
        {
            if (root == null)
                return;
            
            PostOrderHelper(root.left, result);
            PostOrderHelper(root.right, result);
            result.Add(root.val);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Tree Level Order Traversal");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}