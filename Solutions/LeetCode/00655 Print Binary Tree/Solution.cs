// Print Binary Tree
namespace CompetitiveProgramming.LeetCode.PrintBinaryTree;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public IList<IList<string>> PrintTree(TreeNode root)
    {
        int h = Height(root);
        int m = h + 1;
        int n = (1 << (h + 1)) - 1;

        var res = new string[m][];
        for (int i = 0; i < m; i++)
        {
            res[i] = new string[n];
            for (int j = 0; j < n; j++)
                res[i][j] = "";
        }

        Fill(root, 0, (n - 1) / 2, h, res);
        return res;
    }

    private int Height(TreeNode node)
    {
        if (node == null) return -1;
        return 1 + Math.Max(Height(node.left), Height(node.right));
    }

    private void Fill(TreeNode node, int r, int c, int h, string[][] res)
    {
        if (node == null) return;

        res[r][c] = node.val.ToString();

        int offset = 1 << (h - r - 1);
        if (node.left != null)
            Fill(node.left, r + 1, c - offset, h, res);

        if (node.right != null)
            Fill(node.right, r + 1, c + offset, h, res);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Print Binary Tree");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}