// Cousins in Binary Tree II

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CousinsinBinaryTreeII
{
    public class Solution
    {
        private Dictionary<int, int> depthSum = new Dictionary<int, int>();
        public TreeNode ReplaceValueInTree(TreeNode root)
        {
            if (root == null) return null!;

            ComputeDepthSum(root, 0);
            root.val = 0;
            ReplaceNodeValues(root, 0);
            
            return root;
        }

        private void ComputeDepthSum(TreeNode node, int depth)
        {
            if (node == null) return;
            
            if (!depthSum.ContainsKey(depth))
            {
                depthSum[depth] = 0;
            }
            depthSum[depth] += node.val;
            
            ComputeDepthSum(node.left, depth + 1);
            ComputeDepthSum(node.right, depth + 1);
        }

        private void ReplaceNodeValues(TreeNode node, int depth)
        {
            if (node == null) return;
            
            int siblingSum = 0;
            if (node.left != null) siblingSum += node.left.val;
            if (node.right != null) siblingSum += node.right.val;

            if (node.left != null)
            {
                node.left.val = depthSum[depth + 1] - siblingSum;
                ReplaceNodeValues(node.left, depth + 1);
            }
            if (node.right != null)
            {
                node.right.val = depthSum[depth + 1] - siblingSum;
                ReplaceNodeValues(node.right, depth + 1);
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Cousins in Binary Tree II");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}