using CompetitiveProgramming.LeetCode;

namespace CompetitiveProgramming.Helpers;

public class TreeNodeExtensions
{
    public static bool AreTreesEqual(TreeNode tree1, TreeNode tree2)
    {
        if (tree1 == null && tree2 == null)
            return true;

        if (tree1 == null || tree2 == null)
            return false;

        return tree1.val == tree2.val &&
            AreTreesEqual(tree1.left, tree2.left) &&
            AreTreesEqual(tree1.right, tree2.right);
    }
}