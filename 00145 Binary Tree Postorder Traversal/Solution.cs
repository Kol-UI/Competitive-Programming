using System;

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

    // /**
    // * Definition for a binary tree node.
    // * public class TreeNode {
    // *     public int val;
    // *     public TreeNode left;
    // *     public TreeNode right;
    // *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
    // *         this.val = val;
    // *         this.left = left;
    // *         this.right = right;
    // *     }
    // * }
    // */
    // public class Solution
    // {
    //     private IList<int> list=new List<int>();
    //     private Stack<TreeNode> s=new Stack<TreeNode>();
    //     private HashSet<TreeNode> visited=new HashSet<TreeNode>();
    //     public IList<int> PostorderTraversal(TreeNode root)
    //     {
    //         if(root==null) return list;
    //         s.Push(root);
    //         while(s.Count>0)
    //         {
    //             TreeNode node=s.Pop();
    //             if(!visited.Contains(node))
    //             {
    //                 visited.Add(node);
    //                 s.Push(node);
    //                 if(node.right!=null) s.Push(node.right);
    //                 if(node.left!=null) s.Push(node.left);
    //             }
    //             else
    //                 list.Add(node.val);         
    //         }
    //         return list;   
    //     }
    // }
}