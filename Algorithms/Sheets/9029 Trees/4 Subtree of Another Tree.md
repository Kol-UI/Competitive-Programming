Subtree of Another Tree

Given the roots of two binary trees root and subRoot, return true if there is a subtree of root with the same structure and node values of subRoot and false otherwise.

A subtree of a binary tree tree is a tree that consists of a node in tree and all of this node's descendants. The tree tree could also be considered as a subtree of itself.


```cs
public bool IsSubtree(TreeNode root, TreeNode subRoot)
{
    if (subRoot == null) return true;
    if (root == null) return false;

    if (SameTree(root, subRoot))
    {
        return true;
    }
    return IsSubtree(root.left, subRoot) ||
        IsSubtree(root.right, subRoot);
}

private bool SameTree(TreeNode root, TreeNode subRoot)
{
    if (root == null && subRoot == null) return true;
    if (root != null && subRoot != null && root.val == subRoot.val)
        return SameTree(root.left, subRoot.left) && SameTree(root.right, subRoot.right);
    return false;
}
```
