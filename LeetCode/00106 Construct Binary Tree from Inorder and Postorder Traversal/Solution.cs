using System;
namespace CompetitiveProgramming.LeetCode.ConstructBinaryTreefromInorderandPostorderTraversal
{
    /*
    Given two integer arrays inorder and postorder where inorder is the inorder traversal of a binary tree and postorder is the postorder traversal of the same tree, construct and return the binary tree.

    Example 1:
    Input: inorder = [9,3,15,20,7], postorder = [9,15,7,20,3]
    Output: [3,9,20,null,null,15,7]
    
    Example 2:
    Input: inorder = [-1], postorder = [-1]
    Output: [-1]
    */

    /*
    public class Solution
    {
        public TreeNode BuildTree(int[] inorder, int[] postorder) 
        {
            TreeNode? Build(Span<int> inorder, Span<int> postorder)
            {
                if (postorder.IsEmpty || inorder.IsEmpty)
                {
                    return null;
                }

                var pos = inorder.IndexOf(postorder[^1]);
                return new TreeNode(postorder[^1])
                {
                    left = Build(inorder[..pos], postorder[..pos]),
                    right = Build(inorder[(pos + 1)..], postorder[pos..^1])
                };
            }

            return Build(inorder, postorder);
        }
    }
    */
}