namespace CompetitiveProgramming.Algorithms;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null!, TreeNode right = null!)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

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