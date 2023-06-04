// Unique Binary Search Trees

/*
Given an integer n, return the number of structurally unique BST's (binary search trees) which has exactly n nodes of unique values from 1 to n.

 

Example 1:

Input: n = 3
Output: 5

Example 2:

Input: n = 1
Output: 1
*/

using System;
namespace CompetitiveProgramming.LeetCode.UniqueBinarySearchTrees
{
    public class Solution
    {
        // Recursion
        public static int NumTrees(int n)
        {
            if (n == 0) return 0;

            if (n == 1) return 1;

            return CalcNumTrees(n - 1);
        }

        private static int CalcNumTrees(int n)
        {
            if (n == 0) return 1;

            if (n == 1) return 2;

            var counter = 2 * CalcNumTrees(n - 1);

            for (var i = 0; i <= n - 2; i++)
            {
                var remainder = n - 2;
                counter += CalcNumTrees(i) * CalcNumTrees(remainder - i);
            }
            
            return counter;
        }
    }
}
