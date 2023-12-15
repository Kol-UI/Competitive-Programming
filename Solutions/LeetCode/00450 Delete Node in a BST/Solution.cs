// Delete Node in a BST

/*
Given a root node reference of a BST and a key, delete the node with the given key in the BST. Return the root node reference (possibly updated) of the BST.

Basically, the deletion can be divided into two stages:

Search for a node to remove.
If the node is found, delete the node.
 

Example 1:


Input: root = [5,3,6,2,4,null,7], key = 3
Output: [5,4,6,2,null,null,7]
Explanation: Given key to delete is 3. So we find the node with value 3 and delete it.
One valid answer is [5,4,6,2,null,null,7], shown in the above BST.
Please notice that another valid answer is [5,2,6,null,4,null,7] and it's also accepted.

Example 2:

Input: root = [5,3,6,2,4,null,7], key = 0
Output: [5,3,6,2,4,null,7]
Explanation: The tree does not contain a node with value = 0.

Example 3:

Input: root = [], key = 0
Output: []
*/

using System;
namespace CompetitiveProgramming.LeetCode.DeleteNodeinaBST
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
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            TreeNode? Delete(TreeNode? node, int value)
            {
                if (node == null)
                {
                    return null;
                }

                if (value < node.val)
                {
                    node.left = Delete(node.left, value)!;
                }
                else if (value > node.val)
                {
                    node.right = Delete(node.right, value)!;
                }
                else
                {
                    if (node.right == null)
                    {
                        return node.left;
                    }

                    if (node.left == null)
                    {
                        return node.right;
                    }

                    var newRoot = node.right;
                    while (newRoot.left != null)
                    {
                        newRoot = newRoot.left;
                    }

                    newRoot.right = Delete(node.right, newRoot.val)!;
                    newRoot.left = node.left;
                    node = newRoot;
                }

                return node;
            }

            return Delete(root, key)!;
        }
    }
}