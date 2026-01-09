// Smallest Subtree with all the Deepest Nodes
namespace CompetitiveProgramming.LeetCode.SmallestSubtreewithalltheDeepestNodes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8619

public class Solution
{
    public TreeNode SubtreeWithAllDeepest(TreeNode root)
    {
        return GetDeepest(root, 0).node;
    }

    private (TreeNode node, int deep) GetDeepest(TreeNode node, int deep)
    {
        if(node == null) return (node, 0);

        (var leftNode, var leftDeep) = GetDeepest(node.left, deep + 1);
        (var rightNode, var rightDeep) = GetDeepest(node.right, deep + 1);

        if (leftDeep > rightDeep) return (leftNode, leftDeep + 1);
        else if (leftDeep < rightDeep) return (rightNode, rightDeep + 1);
        else return (node, leftDeep + 1);        
    }
}

#pragma warning restore CS8619
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Smallest Subtree with all the Deepest Nodes");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}