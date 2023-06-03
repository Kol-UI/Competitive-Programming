// N-ary Tree Preorder Traversal

/*
Given the root of an n-ary tree, return the preorder traversal of its nodes' values.

Nary-Tree input serialization is represented in their level order traversal. Each group of children is separated by the null value (See examples)

 

Example 1:

Input: root = [1,null,3,2,4,null,5,6]
Output: [1,3,5,6,2,4]

Example 2:

Input: root = [1,null,2,3,4,5,null,null,6,7,null,8,null,9,10,null,null,11,null,12,null,13,null,null,14]
Output: [1,2,3,6,7,11,14,4,8,12,5,9,13,10]
*/

using System;
namespace CompetitiveProgramming.LeetCode.NaryTreePreorderTraversal
{
    /*
    // Definition for a Node.
    public class Node {
        public int val;
        public IList<Node> children;

        public Node() {}

        public Node(int _val) {
            val = _val;
        }

        public Node(int _val,IList<Node> _children) {
            val = _val;
            children = _children;
        }
    }
    */

    /*
    public class Solution
    {
        private List<int> _list = new List<int>();

        public IList<int> Preorder(Node root)
        {
            if (root == null)
            {
                return _list;
            }
            
            recursiveAdd(root);

            return _list;
        }

        private void recursiveAdd(Node node)
        {
            if (node == null)
            {
                return;
            }

            _list.Add(node.val);

            foreach (var child in node.children)
            {
                recursiveAdd(child);
            }
        }
    }
    */
}