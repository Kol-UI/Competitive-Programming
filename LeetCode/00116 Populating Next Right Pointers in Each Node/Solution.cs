// Populating Next Right Pointers in Each Node

/*
You are given a perfect binary tree where all leaves are on the same level, and every parent has two children. The binary tree has the following definition:

struct Node {
  int val;
  Node *left;
  Node *right;
  Node *next;
}
Populate each next pointer to point to its next right node. If there is no next right node, the next pointer should be set to NULL.
Initially, all next pointers are set to NULL.

 

Example 1:

Input: root = [1,2,3,4,5,6,7]
Output: [1,#,2,3,#,4,5,6,7,#]
Explanation: Given the above perfect binary tree (Figure A), your function should populate each next pointer to point to its next right node, just like in Figure B. The serialized output is in level order as connected by the next pointers, with '#' signifying the end of each level.

Example 2:

Input: root = []
Output: []
*/

using System;
namespace CompetitiveProgramming.LeetCode.PopulatingNextRightPointersinEachNode
{
    /*
    // Definition for a Node.
    public class Node {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() {}

        public Node(int _val) {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next) {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
    */

    /*
    public class Solution
    {
        public Node Connect(Node root)
        {
            Queue<Node> Q= new Queue<Node>();
            if(root == null) return null;
            Q.Enqueue(root);

            while(Q.Count() > 0)
            {
                int qSize= Q.Count();
                while(qSize>0)
                {  
                    Node element = Q.Dequeue();       
                    if (qSize > 1)
                    {
                        element.next =Q.Peek();
                    }
                    if(element.left != null )Q.Enqueue(element.left );
                    if(element.right != null )Q.Enqueue(element.right );
                
                    qSize--;
                }
            }
            return root;
        }
    }
    */
}