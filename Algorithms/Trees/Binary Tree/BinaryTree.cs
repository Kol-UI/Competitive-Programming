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

    #region LC 104
    public int GetMaxDepth(TreeNode root) 
    {
        if (root == null)
        {
            return 0;
        }
        return Math.Max(GetMaxDepth(root.left), GetMaxDepth(root.right)) + 1;
    }
    #endregion
    
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

    #region LC 112
    #nullable disable
    // Check if the tree has a root-to-leaf path such that adding up all the values along the path equals targetSum.
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null)
        {
            return false;
        }

        if (root.left == null && root.right == null)
        {
            return root.val == targetSum;
        }

        int remainingSum = targetSum - root.val;
        return HasPathSum(root.left, remainingSum) || HasPathSum(root.right, remainingSum);
    }
    #nullable enable
    #endregion

    #region LC 222
    // Get number of nodes in binary tree
    public int CountNodes(TreeNode root)
    {
        if (root == null) return 0;

        int leftHeight = GetHeight(root.left);
        int rightHeight = GetHeight(root.right);

        if (leftHeight == rightHeight)
        {
            return (1 << leftHeight) + CountNodes(root.right);
        }
        else
        {
            return (1 << rightHeight) + CountNodes(root.left);
        }
    }

    private int GetHeight(TreeNode node)
    {
        int height = 0;
        while (node != null)
        {
            height++;
            node = node.left;
        }
        return height;
    }
    #endregion
}