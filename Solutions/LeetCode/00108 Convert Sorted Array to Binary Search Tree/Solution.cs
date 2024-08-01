using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ConvertSortedArraytoBinarySearchTree
{
    // Given an integer array nums where the elements are sorted in ascending order, convert it to a height-balanced binary search tree.

    // Example 1:

    // Input: nums = [-10,-3,0,5,9]
    // Output: [0,-3,9,-10,null,5]
    // Explanation: [0,-10,5,null,-3,null,9] is also accepted

    // Example 2:

    // Input: nums = [1,3]
    // Output: [3,1]
    // Explanation: [1,null,3] and [3,1] are both height-balanced BSTs.

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
        public static TreeNode SortedArrayToBST(int[] nums)
        {
            var node = new TreeNode();
            if (nums.Length == 1)
            {
                node.val = nums[0];

                // Print
                PrintHelper.PrintArray(nums);
                
                return node;
            }

            var midIndex = (int)(Math.Ceiling(((float)nums.Length / 2))) - 1;
            node.val = nums[midIndex];
            if(midIndex >= 1)
            {
                node.left = SortedArrayToBST(nums[..midIndex]);
            }

            var rightEndIndex = midIndex + 1;

            if(rightEndIndex <= nums.Length - 1)
            {
                node.right = SortedArrayToBST(nums[rightEndIndex..]);
            }

            // Print
            PrintHelper.PrintArray(nums);
            return node;
        }
    }

    public class Test
    {
        public static bool[] TestConvertSortedArraytoBinarySearchTree()
        {
            
            // Case 1
            StyleHelper.SubTitle("Case 1");
            int[] numsCase1_108 = { -10, -3, 0, 5, 9 };
            TreeNode resultCase1_108 = Solution.SortedArrayToBST(numsCase1_108);
            
            // Case 2
            StyleHelper.SubTitle("Case 2");
            int[] numsCase2_108 = { 1, 3 };
            TreeNode resultCase2_108 = Solution.SortedArrayToBST(numsCase2_108);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(true, true),
                ResultTester.CheckResult<bool>(false, false)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Convert Sorted Array to Binary Search Tree");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestConvertSortedArraytoBinarySearchTree());
        }
    }
}