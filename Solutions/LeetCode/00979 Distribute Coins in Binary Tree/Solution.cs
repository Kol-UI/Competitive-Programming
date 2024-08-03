// Distribute Coins in Binary Tree

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DistributeCoinsinBinaryTree
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
        public int DistributeCoins(TreeNode root)
        {
            int res = 0;
            DFS(root);
            return res;

            int DFS(TreeNode node)
            {
                if(node == null)
                {
                    return 0;
                }
                var l_extraCoins = DFS(node.left);
                var r_extraCoins = DFS(node.right);
                var extraCoins = node.val - 1 + l_extraCoins + r_extraCoins;
                res += Math.Abs(extraCoins);
                return extraCoins;
            }
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Distribute Coins in Binary Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}