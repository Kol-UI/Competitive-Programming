namespace CompetitiveProgramming.Algorithms;

public class PerfectBinaryTree
{
    // A binary tree is perfect if all parent nodes have two children and all leaves are on the same level
    public static bool IsPerfectBinaryTree(TreeNode root)
    {
        if (root == null)
            return true;

        return IsPerfect(root, 0);
    }

    private static bool IsPerfect(TreeNode node, int depth)
    {
        
        if (node == null)
            return depth == 0;
            
        if (IsPerfect(node.left, depth + 1) == false || IsPerfect(node.right, depth + 1) == false)
            return false;

        return true;
    }
}