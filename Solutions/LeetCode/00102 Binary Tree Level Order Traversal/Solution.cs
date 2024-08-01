using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BinaryTreeLevelOrderTraversal
{
    
    public class Solution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<IList<int>> levelOrderList = new();
            if(root == null)
            return levelOrderList;

            Queue<TreeNode> queue = new ();
            queue.Enqueue(root);
            while(queue.Count > 0)
            {
                int count = queue.Count;
                List<int> list = new ();
                for(int i = 0; i < count; i++)
                {
                    TreeNode node = queue.Dequeue();
                    list.Add(node.val);

                    if(node.left != null)
                    queue.Enqueue(node.left);

                    if(node.right != null)
                    queue.Enqueue(node.right);
                }
                levelOrderList.Add(list);
            }
            return levelOrderList;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Tree Level Order Traversal");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}