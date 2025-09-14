// Univalued Binary Tree
namespace CompetitiveProgramming.LeetCode.UnivaluedBinaryTree;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool IsUnivalTree(TreeNode root) 
    {
        if (root == null) return true;
        bool result = Traverse(root, root.val);
        return result;
    }

    public bool Traverse(TreeNode node, int targetValue)
    {
        if (node == null) return true;
        if (node.val != targetValue) return false;
        
        bool left = Traverse(node.left, targetValue);
        bool right = Traverse(node.right, targetValue);
        
        if (!left || !right) return false;       
        return true;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Univalued Binary Tree");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}