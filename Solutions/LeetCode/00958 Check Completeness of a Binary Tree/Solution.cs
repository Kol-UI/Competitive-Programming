using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.CheckCompletenessofaBinaryTree
{
    /*
    Given the root of a binary tree, determine if it is a complete binary tree.
    In a complete binary tree, every level, except possibly the last, is completely filled, and all nodes in the last level are as far left as possible. It can have between 1 and 2h nodes inclusive at the last level h.

    Example 1:
    Input: root = [1,2,3,4,5,6]
    Output: true
    Explanation: Every level before the last is full (ie. levels with node-values {1} and {2, 3}), and all nodes in the last level ({4, 5, 6}) are as far left as possible.
    
    Example 2:
    Input: root = [1,2,3,4,5,null,7]
    Output: false
    Explanation: The node with value 7 isn't as far left as possible.
    */

    public class Solution
    {
        public static bool IsCompleteTree(TreeNode root)
        {
            var q = new Queue<TreeNode>();
            var list = new List<int>();
            q.Enqueue(root);
            while (q.Count != 0)
            {
                var pop = q.Dequeue();
                if (pop != null)
                {
                    list.Add(pop.val);
                    q.Enqueue(pop.left);
                    q.Enqueue(pop.right);
                }
                else list.Add(-1);
            }

            int i = list.Count - 1;
            for(; i >= 0; i--)
            {
                if (list[i] != -1) break;
            }

            for(int j = 0; j <= i; j++)
            {
                if (list[j] == -1) return false;
            }
            return true;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Check Completeness of a Binary Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}