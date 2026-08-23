// Increasing Order Search Tree
namespace CompetitiveProgramming.LeetCode.IncreasingOrderSearchTree;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public TreeNode IncreasingBST(TreeNode root)
    {
        TreeNode dummy = new TreeNode(0);
        TreeNode current = dummy;
        InOrderTraversal(root,ref current);
        return dummy.right;
    }

    private void InOrderTraversal(TreeNode node, ref TreeNode current)
    {
        if(node == null) return;
        InOrderTraversal(node.left,ref current);
        current.right = new TreeNode(node.val);
        current = current.right;
        InOrderTraversal(node.right, ref current);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Increasing Order Search Tree");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}