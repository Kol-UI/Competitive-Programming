// All Nodes Distance K in Binary Tree

/*
Given the root of a binary tree, the value of a target node target, and an integer k, return an array of the values of all nodes that have a distance k from the target node.

You can return the answer in any order.

 

Example 1:


Input: root = [3,5,1,6,2,0,8,null,null,7,4], target = 5, k = 2
Output: [7,4,1]
Explanation: The nodes that are a distance 2 from the target node (with value 5) have values 7, 4, and 1.


Example 2:

Input: root = [1], target = 1, k = 3
Output: []
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.AllNodesDistanceKinBinaryTree
{
    /**
    * Definition for a binary tree node.
    * public class TreeNode {
    *     public int val;
    *     public TreeNode left;
    *     public TreeNode right;
    *     public TreeNode(int x) { val = x; }
    * }
    */
    public class Solution
    {
        public IList<int> DistanceK(TreeNode root, TreeNode target, int k)
        {
            if (k == 0)
                return new List<int>() { target.val };

            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
            graph.Add(root.val, new List<int>());
            TreeToGraph(root, graph);

            return BFS(graph, target.val, k);
        }

        private IList<int> BFS(Dictionary<int, List<int>> graph, int first, int k)
        {
            IList<int> result = new List<int>();
            Queue<int> q = new Queue<int>();
            HashSet<int> visited = new HashSet<int>();
            q.Enqueue(first);
            visited.Add(first);
            while (k > 0 && q.Count > 0)
            {
                int count = q.Count;
                while (count > 0)
                {
                    count--;
                    int item = q.Dequeue();
                    for (int i = 0; i < graph[item].Count; i++)
                    {
                        if (!visited.Contains(graph[item][i]))
                        {
                            q.Enqueue(graph[item][i]);
                            visited.Add(graph[item][i]);
                        }
                    }
                }
                k--;
            }

            return q.ToList();
        }

        private void TreeToGraph(TreeNode node, Dictionary<int, List<int>> graph)
        {
            if (node == null || (node.left == null && node.right == null))
                return;

            if (node.left != null)
            {
                graph[node.val].Add(node.left.val);

                graph.Add(node.left.val, new List<int>());
                graph[node.left.val].Add(node.val);
            }

            if (node.right != null)
            {
                graph[node.val].Add(node.right.val);
                
                graph.Add(node.right.val, new List<int>());
                graph[node.right.val].Add(node.val);
            }

            TreeToGraph(node.left!, graph);
            TreeToGraph(node.right!, graph);
        }
    }
}