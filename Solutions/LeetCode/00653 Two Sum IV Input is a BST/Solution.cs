using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.TwoSumIVInputisaBST
{
    // Given the root of a binary search tree and an integer k, return true if there exist two elements in the BST such that their sum is equal to k, or false otherwise.

    // Example 1:
    // Input: root = [5,3,6,2,4,null,7], k = 9
    // Output: true

    public class Solution
    {
        HashSet<int> seen = new();
        public bool FindTarget(TreeNode root, int k)
        {
            if (root is null) return false;
            if (seen.Contains(k - root.val)) return true;
            seen.Add(root.val);
            return FindTarget(root.left, k) || FindTarget(root.right, k);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Two Sum IV Input is a BST");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}