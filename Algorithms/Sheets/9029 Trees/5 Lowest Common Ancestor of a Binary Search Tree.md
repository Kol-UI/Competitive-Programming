Lowest Common Ancestor of a Binary Search Tree


Given a binary search tree (BST), find the lowest common ancestor (LCA) node of two given nodes in the BST.

According to the definition of LCA on Wikipedia: “The lowest common ancestor is defined between two nodes p and q as the lowest node in T that has both p and q as descendants (where we allow a node to be a descendant of itself).”





Given a binary search tree (BST) where all node values are unique,
and two nodes from the tree p and q,
return the lowest common ancestor (LCA) of the two nodes.

The lowest common ancestor between two nodes p and q is the lowest node in a tree T such that both p and q as descendants.
The ancestor is allowed to be a descendant of itself.

A Binary Search Tree (BST) is a node-based binary tree data structure which has the following properties:

The left subtree of a node contains only nodes with keys lesser than the node's key.   
The right subtree of a node contains only nodes with keys greater than the node's key.
The left and right subtree each must also be a binary search tree.   
There must be no duplicate nodes.


```cs
public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
{
    if (root == null || p == null || q == null) return null;

    if (Math.Max(p.val, q.val) < root.val)
    {
        return LowestCommonAncestor(root.left, p, q);
    }
    else if (Math.Min(p.val, q.val) > root.val)
    {
        return LowestCommonAncestor(root.right, p, q);
    }
    else
    {
        return root;
    }
}
```

