// Even Odd Tree


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.EvenOddTree
{
    public class Solution 
    {
        public static bool IsEvenOddTree(TreeNode root)
        {
            if (root == null)
                return true;

            Queue<(TreeNode, int)> queue = new Queue<(TreeNode, int)>();
            queue.Enqueue((root, 0));

            while (queue.Count > 0)
            {
                int? prevVal = null;
                int levelSize = queue.Count;

                for (int i = 0; i < levelSize; i++)
                {
                    (TreeNode node, int level) = queue.Dequeue();

                    if (level % 2 == 0) 
                    {
                        if (node.val % 2 == 0 || (prevVal.HasValue && node.val <= prevVal))
                            return false;
                    }
                    else 
                    {
                        if (node.val % 2 != 0 || (prevVal.HasValue && node.val >= prevVal))
                            return false;
                    }

                    prevVal = node.val;

                    if (node.left != null)
                        queue.Enqueue((node.left, level + 1));

                    if (node.right != null)
                        queue.Enqueue((node.right, level + 1));
                }
            }

            return true;
        }
    }
}