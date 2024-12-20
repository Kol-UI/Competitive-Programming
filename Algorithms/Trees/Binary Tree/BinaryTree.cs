namespace CompetitiveProgramming.Algorithms;

public class BinaryTree
{
    private static bool AreTreesEqual(TreeNode tree1, TreeNode tree2)
    {
        if (tree1 == null && tree2 == null)
            return true;

        if (tree1 == null || tree2 == null)
            return false;

        return tree1.val == tree2.val &&
            AreTreesEqual(tree1.left, tree2.left) &&
            AreTreesEqual(tree1.right, tree2.right);
    }
    
    #region LC 226
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return null!;

        TreeNode temp = root.left;
        root.left = root.right;
        root.right = temp;

        InvertTree(root.left);
        InvertTree(root.right);

        return root;
    }
    #endregion
}