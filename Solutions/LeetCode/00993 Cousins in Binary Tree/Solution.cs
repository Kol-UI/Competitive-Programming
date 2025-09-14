// Cousins in Binary Tree
namespace CompetitiveProgramming.LeetCode.CousinsinBinaryTree;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

#pragma warning disable CS8625
#pragma warning disable CS8619
public class Solution
{
    public bool IsCousins(TreeNode root, int x, int y)
    {
        if (root == null) return false;

        (TreeNode parent, int depth) xInfo = Find(root, null, x, 0);
        (TreeNode parent, int depth) yInfo = Find(root, null, y, 0);

        return xInfo.depth == yInfo.depth && xInfo.parent != yInfo.parent;
    }
    private (TreeNode parent, int depth) Find(TreeNode node, TreeNode parent, int target, int depth)
    {
        if (node == null) return (null, -1);

        if (node.val == target) return (parent, depth);

        var left = Find(node.left, node, target, depth + 1);
        if (left.depth != -1) return left;

        return Find(node.right, node, target, depth + 1);
    }
}

#pragma warning restore CS8619
#pragma warning restore CS8625

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Cousins in Binary Tree");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}