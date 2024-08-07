// Find Bottom Left Tree Value


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindBottomLeftTreeValue
{
    public class Solution
    {
        public static int FindBottomLeftValue(TreeNode root)
        {
            
            var bfs = new Queue<TreeNode>();
            bfs.Enqueue(root);

            while (bfs.Count > 0)
            {
                root = bfs.Dequeue();

                if (root.right != null) bfs.Enqueue(root.right);
                if (root.left != null) bfs.Enqueue(root.left);
            }
            
            return root.val;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Find Bottom Left Tree Value");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}