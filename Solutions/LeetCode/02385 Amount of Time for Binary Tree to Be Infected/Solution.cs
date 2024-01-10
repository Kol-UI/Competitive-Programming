// Amount of Time for Binary Tree to Be Infected



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.AmountofTimeforBinaryTreetoBeInfected
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
        TreeNode startNode = null!;
        public int AmountOfTime(TreeNode root, int start)
        {
            var amount_of_time = -1;
            var set = new HashSet<int>();
            var queue = new Queue<TreeNode>();
            var parent = new Dictionary<int, TreeNode>();

            FillParent(root, null!, start, parent);
            queue.Enqueue(startNode);

            while(queue.Count > 0) 
            {
                var count = queue.Count;
                for(int i = 0; i < count; i++)
                {
                    var temp = queue.Dequeue();
                    set.Add(temp.val);

                    if(temp.left != null && !set.Contains(temp.left.val))
                        queue.Enqueue(temp.left);

                    if(temp.right != null && !set.Contains(temp.right.val))
                        queue.Enqueue(temp.right);

                    if(parent[temp.val] != null && !set.Contains(parent[temp.val].val))
                        queue.Enqueue(parent[temp.val]);
                }

                amount_of_time++;
            }

            return amount_of_time;
        }

        private void FillParent(TreeNode root, TreeNode prev, int start, Dictionary<int, TreeNode> parent)
        {
            if(root == null)
                return;
            
            if(root.val == start)
                startNode = root;

            parent[root.val] = prev;
            FillParent(root.left, root, start, parent);
            FillParent(root.right, root, start, parent);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            TreeNode root1 = new(1,
                new TreeNode(5,
                    null!,
                    new TreeNode(4, new TreeNode(9), new TreeNode(2))
                ),
                new TreeNode(3, new TreeNode(10), new TreeNode(6))
            );

            Solution solution = new();

            TreeNode root2 = new(1);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.AmountOfTime(root1, 3), 4),
                ResultTester.CheckResult<int>(solution.AmountOfTime(root2, 1), 0),
            };
            return results;
        }
    }
}