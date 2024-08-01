

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SearchinaBinarySearchTree
{
    
    // You are given the root of a binary search tree (BST) and an integer val.

    // Find the node in the BST that the node's value equals val and return the subtree rooted with that node. If such a node does not exist, return null.


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
    // public class Solution {
    //     public TreeNode SearchBST(TreeNode root, int val)
    //     {
            
    //     TreeNode crnt= root;

    //     while(crnt!=null)
    //     {
    //         if(val<crnt.val)
    //             crnt= crnt.left;
    //         else if(val > crnt.val)
    //             crnt= crnt.right;
    //         else
    //         return crnt;
    //     }
    //     return null;
    //     }
    // }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Search into a Binary Search Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}