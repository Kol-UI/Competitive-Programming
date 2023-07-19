// Linked List in Binary Tree

/*
Given a binary tree root and a linked list with head as the first node. 

Return True if all the elements in the linked list starting from the head correspond to some downward path connected in the binary tree otherwise return False.

In this context downward path means a path that starts at some node and goes downwards.

 

Example 1:

Input: head = [4,2,8], root = [1,4,4,null,2,2,null,1,null,6,8,null,null,null,null,1,3]
Output: true
Explanation: Nodes in blue form a subpath in the binary Tree.



Example 2:

Input: head = [1,4,2,6], root = [1,4,4,null,2,2,null,1,null,6,8,null,null,null,null,1,3]
Output: true



Example 3:

Input: head = [1,4,2,6,8], root = [1,4,4,null,2,2,null,1,null,6,8,null,null,null,null,1,3]
Output: false
Explanation: There is no path in the binary tree that contains all the elements of the linked list from head.
*/

namespace CompetitiveProgramming.LeetCode.LinkedListinBinaryTree
{
    /**
    * Definition for singly-linked list.
    * public class ListNode {
    *     public int val;
    *     public ListNode next;
    *     public ListNode(int val=0, ListNode next=null) {
    *         this.val = val;
    *         this.next = next;
    *     }
    * }
    */
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
        public static bool IsSubPath(ListNode head, TreeNode root)
        { 
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while(q.Count > 0)
            {
                int count = q.Count;    

                while(count-- > 0){
                    var current = q.Dequeue();

                    if(current == null){
                        continue;
                    }

                    if(current.val == head.val && dfs(head, current)){
                        return true;
                    }

                    q.Enqueue(current.left);
                    q.Enqueue(current.right);
                }
            }

            return false;
        }

        private static bool dfs(ListNode head, TreeNode root)
        {
            if(head == null)
            {
                return true;
            }

            if(root == null)
            {
                return false;
            }

            return (head.val == root.val && (dfs(head.next, root.left) || dfs(head.next, root.right)));
        }
    }
}
