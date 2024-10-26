// Height of Binary Tree After Subtree Removal Queries

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.HeightofBinaryTreeAfterSubtreeRemovalQueries
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
    public class Solution {
        public int[] TreeQueries(TreeNode root, int[] queries) {
            Dictionary<int, int> nodeIndexMap = new Dictionary<int, int>();
            Dictionary<int, int> subtreeSize = new Dictionary<int, int>();

            List<int> nodeDepths = new List<int>();
            List<int> maxDepthFromLeft = new List<int>();
            List<int> maxDepthFromRight = new List<int>();

            DFS(root, 0, nodeIndexMap, nodeDepths);

            int totalNodes = nodeDepths.Count;

            CalculateSubtreeSize(root, subtreeSize);

            maxDepthFromLeft.Add(nodeDepths[0]);
            maxDepthFromRight.Add(nodeDepths[totalNodes - 1]);

            for (int i = 1; i < totalNodes; i++) {
                maxDepthFromLeft.Add(Math.Max(maxDepthFromLeft[i - 1], nodeDepths[i]));
                maxDepthFromRight.Add(Math.Max(maxDepthFromRight[i - 1], nodeDepths[totalNodes - i - 1]));
            }
            maxDepthFromRight.Reverse();

            int[] results = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++) {
                int queryNode = queries[i];
                int startIndex = nodeIndexMap[queryNode] - 1;
                int endIndex = startIndex + 1 + subtreeSize[queryNode];

                int maxDepth = maxDepthFromLeft[startIndex];
                if (endIndex < totalNodes) {
                    maxDepth = Math.Max(maxDepth, maxDepthFromRight[endIndex]);
                }

                results[i] = maxDepth;
            }

            return results;
        }

        private void DFS(TreeNode root, int depth, Dictionary<int, int> nodeIndexMap, List<int> nodeDepths) {
            if (root == null) return;

            nodeIndexMap[root.val] = nodeDepths.Count;
            nodeDepths.Add(depth);

            DFS(root.left, depth + 1, nodeIndexMap, nodeDepths);
            DFS(root.right, depth + 1, nodeIndexMap, nodeDepths);
        }

        private int CalculateSubtreeSize(TreeNode root, Dictionary<int, int> subtreeSize) {
            if (root == null) return 0;

            int leftSize = CalculateSubtreeSize(root.left, subtreeSize);
            int rightSize = CalculateSubtreeSize(root.right, subtreeSize);

            int totalSize = leftSize + rightSize + 1;
            subtreeSize[root.val] = totalSize;

            return totalSize;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Height of Binary Tree After Subtree Removal Queries");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
        }
    }
}