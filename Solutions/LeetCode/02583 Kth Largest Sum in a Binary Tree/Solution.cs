// Kth Largest Sum in a Binary Tree

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.KthLargestSuminaBinaryTree
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
        public long KthLargestLevelSum(TreeNode root, int k)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            PriorityQueue<long, long> minHeap = new PriorityQueue<long, long>();

            q.Enqueue(root);

            while (q.Count > 0)
            {
                long levelSum = 0;
                int count = q.Count;
                for (int i = 0; i < count; i++)
                {
                    TreeNode node = q.Dequeue();
                    levelSum += node.val;
                    if (node.left != null)
                    {
                        q.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        q.Enqueue(node.right);
                    }
                }

                minHeap.Enqueue(levelSum, levelSum);
                if (minHeap.Count > k)
                {
                    minHeap.Dequeue();
                }
            }

            return minHeap.Count < k ? -1 : minHeap.Peek();
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Kth Largest Sum in a Binary Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}