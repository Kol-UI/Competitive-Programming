namespace CompetitiveProgramming.Algorithms;

public class InOrderTraversal
{
    // In-Order Traversal
    // left => node => right

    #region LC 94
    public IList<int> InorderTraversal(TreeNode root)
    {
        IList<int> result = new List<int>();
        InorderHelper(root, result);
        return result;
    }

    private void InorderHelper(TreeNode root, IList<int> result)
    {
        if (root == null)
            return;

        InorderHelper(root.left, result);
        result.Add(root.val);
        InorderHelper(root.right, result);
    }
    #endregion
}