// Binary Tree Tilt
namespace CompetitiveProgramming.LeetCode.BinaryTreeTilt;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    int result = 0;
    public int FindTilt(TreeNode root)
    {
        DFS(root);
        return result;
    }

    public int DFS(TreeNode root)
    {
        if(root == null)
            return 0;
        int left = DFS(root.left);
        int right = DFS(root.right);
        result += Math.Abs(left-right);
        root.val += left + right;
        return root.val;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Binary Tree Tilt");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}