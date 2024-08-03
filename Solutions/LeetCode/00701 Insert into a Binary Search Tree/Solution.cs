using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.InsertintoaBinarySearchTree
{
    public class Solution
    {
                
        // You are given the root node of a binary search tree (BST) and a value to insert into the tree. Return the root node of the BST after the insertion. It is guaranteed that the new value does not exist in the original BST.

        // Notice that there may exist multiple valid ways for the insertion, as long as the tree remains a BST after insertion. You can return any of them.



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
        // public TreeNode InsertIntoBST(TreeNode root, int val)
        // {
        // if(root == null) return new TreeNode(val);

        // (TreeNode curr, TreeNode prev) = (root, null);
        
        // while(curr != null)
        // {
        //     prev = curr;
        //     curr = val > curr.val ? curr.right : curr.left;
        // }
        
        // if(val > prev.val)
        // {
        //     prev.right = new(val);
        // }
        // else
        // {
        //     prev.left = new(val);
        // }
        
        // return root;
        // }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Insert into a Binary Search Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}