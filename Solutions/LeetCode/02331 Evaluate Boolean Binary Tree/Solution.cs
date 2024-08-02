// Evaluate Boolean Binary Tree


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.EvaluateBooleanBinaryTree
{
    public class Solution
    {
        public static bool EvaluateTree(TreeNode root)
        {
            if(root.left == null && root.right == null) return root.val == 1;
            else
            {
                if(root.val == 2)
                {
                    return EvaluateTree(root.left!) || EvaluateTree(root.right);
                }
                else
                {
                    return EvaluateTree(root.left!) && EvaluateTree(root.right);
                }
            }
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Evaluate Boolean Binary Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}