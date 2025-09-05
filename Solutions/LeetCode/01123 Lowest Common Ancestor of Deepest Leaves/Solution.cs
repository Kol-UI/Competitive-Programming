// Lowest Common Ancestor of Deepest Leaves
namespace CompetitiveProgramming.LeetCode.LowestCommonAncestorofDeepestLeaves;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

#nullable disable
public class Solution
{
    private int maxDepth = 0;
    private TreeNode result = null;

    public TreeNode LcaDeepestLeaves(TreeNode root)
    {
        Helper(root, 0);
        return result;
    }

    public int Helper(TreeNode node, int level)
    {
        if (node == null)
            return 0;

        int left = Helper(node.left, level + 1);
        int right = Helper(node.right, level + 1);

        if (left == right && level + left >= maxDepth)
        {
            maxDepth = level + left;
            result = node;
        }

        return Math.Max(left, right) + 1;
    }
}
#nullable enable

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Lowest Common Ancestor of Deepest Leaves");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}