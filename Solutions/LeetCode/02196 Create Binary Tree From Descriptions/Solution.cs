// Create Binary Tree From Descriptions


using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CreateBinaryTreeFromDescriptions
{
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
        public TreeNode CreateBinaryTree(int[][] descriptions)
        {
            var dict = new Dictionary<int, TreeNode>();
            var notRoots = new HashSet<int>();

            foreach (var desc in descriptions)
            {
                var parentValue = desc[0];
                var childValue = desc[1];
                var isLeft = desc[2] == 1;

                if (!dict.TryGetValue(parentValue, out var parent))
                {
                    dict[parentValue] = parent = new(parentValue);
                }

                if (!dict.TryGetValue(childValue, out var child))
                {
                    dict[childValue] = child = new(childValue);
                }

                if (isLeft)
                {
                    parent.left = child;
                }
                else
                {
                    parent.right = child;
                }

                notRoots.Add(childValue);
            }

            return dict[descriptions.First(d => !notRoots.Contains(d[0]))[0]];
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Create Binary Tree From Descriptions");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}