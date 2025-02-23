// Construct Binary Tree from Preorder and Postorder Traversal
namespace CompetitiveProgramming.LeetCode.ConstructBinaryTreefromPreorderandPostorderTraversal;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

#nullable disable
public class Solution
{
    public TreeNode ConstructFromPrePost(int[] preorder, int[] postorder)
    {
         return ConstructFromPrePost(preorder, postorder, 0, preorder.Length - 1, 0, postorder.Length - 1);
    }

    private TreeNode ConstructFromPrePost(int[] pre, int[] post, int preLeft, int preRight, int postLeft, int postRight)
    {
        var length = preRight - preLeft;
        if (length < 0) return null;
        var root = new TreeNode(pre[preLeft]);
        if (length == 0) return root;

        var newPostRight = postRight - 1;
        while (post[newPostRight] != pre[preLeft + 1])
            newPostRight--;
        var newLength = newPostRight - postLeft + 1;

        root.left = ConstructFromPrePost(pre, post, preLeft + 1, preLeft + newLength, postLeft, newPostRight);
        root.right = ConstructFromPrePost(pre, post, preLeft + newLength + 1, preRight, newPostRight + 1, postRight - 1);
        return root;
    }
}
#nullable enable

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Construct Binary Tree from Preorder and Postorder Traversal");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}