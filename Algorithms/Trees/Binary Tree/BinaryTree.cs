namespace CompetitiveProgramming.Algorithms;

public class BinaryTree
{
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