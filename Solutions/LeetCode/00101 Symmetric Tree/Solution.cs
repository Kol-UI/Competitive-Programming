using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SymmetricTree
{
    // Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).

    // Example 1:
    // Input: root = [1,2,2,3,4,4,3]
    // Output: true   
    
    public class Solution 
    {
        public bool check(TreeNode a, TreeNode b)
        {
            if(a == null && b == null)
                return true;

            if(a == null || b== null)
            return false;
            
            return a.val == b.val && check(a.left,b.right) && check(a.right, b.left);
        }

        public bool IsSymmetric(TreeNode root)
        {
            return check(root.left,root.right);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Symmetric Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}