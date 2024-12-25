namespace CompetitiveProgramming.Algorithms;

public class PreOrdertraversal
{
    // Pre-Order Traversal
    // node => left => right
    #region LC 144
    public IList<int> PreorderTraversal(TreeNode root)
    {
        IList<int> result = new List<int>();
        PreorderHelper(root, result);
        return result;
    }

    public void PreorderHelper(TreeNode root, IList<int> result)
    {
        if (root == null)
            return;
        
        result.Add(root.val);
        PreorderHelper(root.left, result);
        PreorderHelper(root.right, result);
    }
    #endregion
}