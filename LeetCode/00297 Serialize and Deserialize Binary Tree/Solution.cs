// Serialize and Deserialize Binary Tree

/*
Serialization is the process of converting a data structure or object into a sequence of bits so that it can be stored in a file or memory buffer, or transmitted across a network connection link to be reconstructed later in the same or another computer environment.

Design an algorithm to serialize and deserialize a binary tree. There is no restriction on how your serialization/deserialization algorithm should work. You just need to ensure that a binary tree can be serialized to a string and this string can be deserialized to the original tree structure.

Clarification: The input/output format is the same as how LeetCode serializes a binary tree. You do not necessarily need to follow this format, so please be creative and come up with different approaches yourself.


Example 1:


Input: root = [1,2,3,null,null,4,5]
Output: [1,2,3,null,null,4,5]

Example 2:

Input: root = []
Output: []
*/

using System;
using System.Text;

namespace CompetitiveProgramming.LeetCode.SerializeandDeserializeBinaryTree
{
    /**
    * Definition for a binary tree node.
    * public class TreeNode {
    *     public int val;
    *     public TreeNode left;
    *     public TreeNode right;
    *     public TreeNode(int x) { val = x; }
    * }
    */
    public class Codec 
    {
        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            if(root == null) return "";
            var queue = new Queue<TreeNode>();
            var res = new StringBuilder();
            queue.Enqueue(root);
            
            while(queue.Count > 0)
            {
                var size = queue.Count;
                for(var i =0;i<size;i++)
                {
                    var curr = queue.Dequeue();
                    if(curr == null)
                    {
                        res.Append("null ");
                        continue;
                    }

                    res.Append(curr.val+" ");
                    queue.Enqueue(curr.left);
                    queue.Enqueue(curr.right);
                }
            }
            return res.ToString();
        }

        // Decodes your encoded data to tree.
        public TreeNode? deserialize(string data)
        {
            if(data == null || data.Length == 0) return null;
            
            var list = data.Split(' ');
            
            if(list == null || list.Length == 0 )return null;
            
            var root = new TreeNode(Convert.ToInt32(list[0]));
            var i  = 1;
            var queue = new Queue<TreeNode>();
            
            queue.Enqueue(root);
            
            while(queue.Count > 0)
            {
                var size = queue.Count;
                for (int s = 0; s < size; s++)
                {
                    var node = queue.Dequeue();

                    if(!list[i].Equals("null"))
                    {
                        node.left = new TreeNode(Convert.ToInt32(list[i]));
                        queue.Enqueue(node.left);
                    }

                    i++;

                    if(!list[i].Equals("null"))
                    {
                        node.right = new TreeNode(Convert.ToInt32(list[i]));
                        queue.Enqueue(node.right);
                    }
                    i++;
                }
            }
            return root;
        }
    }

    // Your Codec object will be instantiated and called as such:
    // Codec ser = new Codec();
    // Codec deser = new Codec();
    // TreeNode ans = deser.deserialize(ser.serialize(root));
}