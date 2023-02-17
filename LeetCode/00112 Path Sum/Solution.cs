using System;

namespace CompetitiveProgramming.LeetCode.PathSum
{
    // public class Solution
    // {
    //     // Given the root of a binary tree and an integer targetSum, return true if the tree has a root-to-leaf path such that adding up all the values along the path equals targetSum.
    //     // A leaf is a node with no children.

    //     // Example 1:
    //     // Input: root = [5,4,8,11,null,13,4,7,2,null,null,null,1], targetSum = 22
    //     // Output: true
    //     // Explanation: The root-to-leaf path with the target sum is shown.

    //     // Example 2:
    //     // Input: root = [1,2,3], targetSum = 5
    //     // Output: false
    //     // Explanation: There two root-to-leaf paths in the tree:
    //     // (1 --> 2): The sum is 3.
    //     // (1 --> 3): The sum is 4.
    //     // There is no root-to-leaf path with sum = 5.

    //     // Example 3:
    //     // Input: root = [], targetSum = 0
    //     // Output: false
    //     // Explanation: Since the tree is empty, there are no root-to-leaf paths.
    //     public class TreeNode
    //     {
    //          public int val;
    //          public TreeNode left;
    //          public TreeNode right;
    //          public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
    //              this.val = val;
    //              this.left = left;
    //              this.right = right;
    //          }
    //      }
    //     public bool HasPathSum(TreeNode root, int targetSum)
    //     {
    //         if(root == null)
    //             return false;
    //         bool tracker = false;
    //         RecursiveHasPathSum(root,targetSum,0,ref tracker);
    //         return tracker;
    //     }

    //     public void RecursiveHasPathSum(TreeNode root, int targetSum, int currentSum,ref bool found)
    //     {
    //         if(root.left == null && root.right == null)
    //         {
    //             currentSum += root.val;
    //             if(currentSum == targetSum)
    //             {
    //                 System.Console.WriteLine("B " + root.val + " " + currentSum);
    //                 found = true;
    //                 return;
    //             }
    //             else
    //             {
    //                 System.Console.WriteLine("C " + root.val + " " + currentSum);
    //                 return;
    //             }
    //         }
    //         else if(root.left != null && root.right == null)
    //         {
    //             System.Console.WriteLine("A " + root.val + " " + currentSum);
    //             currentSum += root.val;
    //             RecursiveHasPathSum(root.left, targetSum, currentSum,ref found);
    //         }
    //         else if(root.left == null && root.right != null)
    //         {
    //             currentSum += root.val;
    //             RecursiveHasPathSum(root.right, targetSum, currentSum,ref found);
    //         }
    //         else
    //         {
    //             currentSum += root.val;
    //             RecursiveHasPathSum(root.left,targetSum,currentSum,ref found);
    //             RecursiveHasPathSum(root.right,targetSum,currentSum,ref found);
    //         }
    //     }
    // }
}