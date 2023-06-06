// Merge Two Binary Trees

/*
You are given two binary trees root1 and root2.

Imagine that when you put one of them to cover the other, some nodes of the two trees are overlapped while the others are not. You need to merge the two trees into a new binary tree. The merge rule is that if two nodes overlap, then sum node values up as the new value of the merged node. Otherwise, the NOT null node will be used as the node of the new tree.

Return the merged tree.

Note: The merging process must start from the root nodes of both trees.


Example 1:

Input: root1 = [1,3,2,5], root2 = [2,1,3,null,4,null,7]
Output: [3,4,5,5,4,null,7]

Example 2:

Input: root1 = [1], root2 = [1,2]
Output: [2,2]
*/

using System;
namespace CompetitiveProgramming.LeetCode.MergeTwoBinaryTrees
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
        // BFS
        struct NodeCouple
        {
            public NodeCouple(TreeNode n1, TreeNode n2)
            {
                Node1 = n1;
                Node2 = n2;
            }
            public TreeNode Node1{get;}
            public TreeNode Node2{get;}
        }
        
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2) 
        {
            if(root1 is null)
                return root2;
            if(root2 is null)
                return root1;
                
            var queue = new Queue<NodeCouple>();
            queue.Enqueue(new NodeCouple(root1, root2));

            while(queue.Count > 0)
            {
                var couple = queue.Dequeue();
                var n1 = couple.Node1;
                var n2 = couple.Node2;

                if(n2 is null) 
                    continue;

                n1.val += n2.val;
                
                if(n1.left is null)
                    n1.left = n2.left;
                else
                    queue.Enqueue(new NodeCouple(n1.left, n2.left));

                if(n1.right is null)
                    n1.right = n2.right;
                else
                    queue.Enqueue(new NodeCouple(n1.right, n2.right));
            }

            return root1;
        }
    }
}
