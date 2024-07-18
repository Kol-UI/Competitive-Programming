// Number of Good Leaf Nodes Pairs

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofGoodLeafNodesPairs
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
        public int CountPairs(TreeNode root, int distance) {
            int ans = 0;
            Dfs(root, distance, ref ans);
            return ans;
        }

        private List<int> Dfs(TreeNode node, int distance, ref int ans) {
            if (node == null) return new List<int>();
            if (node.left == null && node.right == null) return new List<int> { 0 };

            var leftDistances = Dfs(node.left!, distance, ref ans);
            var rightDistances = Dfs(node.right, distance, ref ans);

            foreach (int l in leftDistances) {
                foreach (int r in rightDistances) {
                    if (l + r + 2 <= distance) ans++;
                }
            }

            var distances = new List<int>();
            foreach (int l in leftDistances) distances.Add(l + 1);
            foreach (int r in rightDistances) distances.Add(r + 1);
            return distances;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Good Leaf Nodes Pairs");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}