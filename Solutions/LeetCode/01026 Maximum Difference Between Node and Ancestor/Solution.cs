// Maximum Difference Between Node and Ancestor



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MaximumDifferenceBetweenNodeandAncestor
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
        public static int MaxAncestorDiff(TreeNode root)
        {
            Queue<(TreeNode node, int min,int max)> q = new();
            q.Enqueue((root, root.val, root.val));
            int maxDiff = 0;
            while(q.Count > 0)
            {
                TreeNode node = q.Peek().node;
                int min = q.Peek().min;
                int max = q.Peek().max;
                maxDiff = Math.Max(max - min, maxDiff);

                q.Dequeue();
                if(node.left != null)
                {
                    q.Enqueue((node.left, Math.Min(min, node.left.val), Math.Max(max, node.left.val)));
                } 
                if(node.right != null)
                {
                    q.Enqueue((node.right, Math.Min(min, node.right.val), Math.Max(max, node.right.val)));
                }
            }

            return maxDiff;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            TreeNode root1 = new(8,
                new TreeNode(3,
                    new TreeNode(1),
                    new TreeNode(6, new TreeNode(4), new TreeNode(7))
                ),
                new TreeNode(10, null!, new TreeNode(14, new TreeNode(13)))
            );

            TreeNode root2 = new(1,
                null!,
                new TreeNode(2,
                    null!,
                    new TreeNode(0, null!, new TreeNode(3))
                )
            );

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MaxAncestorDiff(root1), 7),
                ResultTester.CheckResult<int>(Solution.MaxAncestorDiff(root2), 3),
            };
            return results;
        }
    }
}