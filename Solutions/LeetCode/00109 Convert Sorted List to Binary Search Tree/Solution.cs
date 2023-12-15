using System;
namespace CompetitiveProgramming.LeetCode.ConvertSortedListtoBinarySearchTree
{
    // Given the head of a singly linked list where elements are sorted in ascending order, convert it to a height-balanced binary search tree.
    
    // Example 1:
    // Input: head = [-10,-3,0,5,9]
    // Output: [0,-3,9,-10,null,5]
    // Explanation: One possible answer is [0,-3,9,-10,null,5], which represents the shown height balanced BST.
    
    // Example 2:
    // Input: head = []
    // Output: []

    // public class Solution
    // {
    //     public TreeNode SortedListToBST(ListNode head)
    //     {
    //         TreeNode tree = null;
    //             List<int> ints = new List<int>();
    //             while (head != null)
    //             {
    //                 ints.Add(head.val);
    //                 head = head.next;
    //             }
    //             tree = insertBST(tree, ints, 0, ints.Count - 1);
    //             return tree;

    //             return tree;
    //     }
    //     public static TreeNode insertBST(TreeNode root, List<int> values, int left, int right)
    //     {
    //         if (left > right)
    //             return root;
    //         int mid = left + (right - left) / 2;
    //         root = new TreeNode(values[mid]);
    //         root.left = insertBST(root.left, values, left, mid - 1);
    //         root.right = insertBST(root.right, values, mid + 1, right);
    //         return root;
    //     }
    // }
}