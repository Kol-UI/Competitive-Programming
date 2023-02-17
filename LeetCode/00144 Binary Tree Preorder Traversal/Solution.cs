﻿using System;

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
}

