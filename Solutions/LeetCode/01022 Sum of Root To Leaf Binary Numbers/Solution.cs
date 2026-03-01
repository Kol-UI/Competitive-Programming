// Sum of Root To Leaf Binary Numbers
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SumofRootToLeafBinaryNumbers;

public class Solution
{
    public int SumRootToLeaf(TreeNode root)
    {
        return Solve(root, 0);
    }

    private int Solve(TreeNode root, int val)
    {
        if (root == null) return 0;
        val = 2 * val + root.val;
        if (root.left == null && root.right == null) return val;
        return Solve(root.left!, val) + Solve(root.right, val);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sum of Root To Leaf Binary Numbers");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}