namespace CompetitiveProgramming.Algorithms;

public class PostOrderTraversal
{
    // Post-Order Traversal
    // left => right => node
    public IList<int> PostorderTraversal(TreeNode root)
    {
        IList<int> result = new List<int>();
        PostOrderHelper(root, result);
        return result;
    }

    public void PostOrderHelper(TreeNode root, IList<int> result)
    {
        if (root == null)
            return;
        
        PostOrderHelper(root.left, result);
        PostOrderHelper(root.right, result);
        result.Add(root.val);
    }
}