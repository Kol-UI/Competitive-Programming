// Maximum Product of Splitted Binary Tree
namespace CompetitiveProgramming.LeetCode.MaximumProductofSplittedBinaryTree;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxProduct(TreeNode root)
    {
        long total = 0, res = 0;
        int MOD = 1000000007;

        total = GetTotal(root);
        DFS(root);
        return (int)(res % MOD);

        long DFS(TreeNode node)
        {
            if (node == null) return 0;
            var left = DFS(node.left);
            var right = DFS(node.right);
            var sum = node.val + left + right;

            long product = sum * (total - sum);
            res = Math.Max(res, product);
            return sum;
        }

        long GetTotal(TreeNode node)
        {
            if (node == null)
                return 0;
            var left = GetTotal(node.left);
            var right = GetTotal(node.right);
            return node.val + left + right;
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Product of Splitted Binary Tree");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}