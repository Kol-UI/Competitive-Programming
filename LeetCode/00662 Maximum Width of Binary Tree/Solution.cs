// Maximum Width of Binary Tree

/*
Given the root of a binary tree, return the maximum width of the given tree.

The maximum width of a tree is the maximum width among all levels.

The width of one level is defined as the length between the end-nodes (the leftmost and rightmost non-null nodes), where the null nodes between the end-nodes that would be present in a complete binary tree extending down to that level are also counted into the length calculation.

It is guaranteed that the answer will in the range of a 32-bit signed integer.

 
Example 1:

Input: root = [1,3,2,5,3,null,9]
Output: 4
Explanation: The maximum width exists in the third level with length 4 (5,3,null,9).

Example 2:

Input: root = [1,3,2,5,null,null,9,6,null,7]
Output: 7
Explanation: The maximum width exists in the fourth level with length 7 (6,null,null,null,null,null,7).

Example 3:

Input: root = [1,3,2,5]
Output: 2
Explanation: The maximum width exists in the second level with length 2 (3,2).
 

Constraints:
The number of nodes in the tree is in the range [1, 3000].
-100 <= Node.val <= 100
*/

using System;
namespace CompetitiveProgramming.LeetCode.MaximumWidthofBinaryTree
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
        public static int WidthOfBinaryTree(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            
            int maxWidth = 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            Dictionary<TreeNode, int> dict = new Dictionary<TreeNode, int>();
            queue.Enqueue(root);
            dict.Add(root, 0);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                int leftIndex = 0;
                int rightIndex = 0;
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = queue.Dequeue();
                    
                    if (i == 0)
                    {
                        leftIndex = dict[node];
                    }

                    if (i == size - 1)
                    {
                        rightIndex = dict[node];
                    }

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                        dict.Add(node.left, dict[node] * 2 + 1);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                        dict.Add(node.right, dict[node] * 2 + 2);
                    }
                }
                maxWidth = Math.Max(maxWidth, rightIndex - leftIndex + 1);
            }
            return maxWidth;
        }
    }
}