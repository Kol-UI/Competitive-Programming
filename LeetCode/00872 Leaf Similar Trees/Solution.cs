// Leaf-Similar Trees

/*
Consider all the leaves of a binary tree, from left to right order, the values of those leaves form a leaf value sequence.
For example, in the given tree above, the leaf value sequence is (6, 7, 4, 9, 8).
Two binary trees are considered leaf-similar if their leaf value sequence is the same.
Return true if and only if the two given trees with head nodes root1 and root2 are leaf-similar.

 

Example 1:

Input: root1 = [3,5,1,6,2,9,8,null,null,7,4], root2 = [3,5,1,6,7,4,2,null,null,null,null,null,null,9,8]
Output: true

Example 2:

Input: root1 = [1,2,3], root2 = [1,3,2]
Output: false
*/

using System;
namespace CompetitiveProgramming.LeetCode.LeafSimilarTrees
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
        string rootList1 = "";
        string rootList2 = "";

        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            DeepSearch(root1,ref rootList1);
            DeepSearch(root2,ref rootList2);

            return rootList1 == rootList2;
        }

        public void DeepSearch(TreeNode node, ref string s)
        {
            if (node is null) return;
            if (node.left == null && node.right == null) s += $"@{node.val}";
            DeepSearch(node.left, ref s);
            DeepSearch(node.right, ref s);
        }
    }
    */
}
