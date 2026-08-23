Same Tree

Given the roots of two binary trees p and q, write a function to check if they are the same or not.

Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.

```cs
public bool IsSameTree(TreeNode p, TreeNode q)
{
	if (p == null && q == null) return true;
	else if (p is not null && q is not null)
	{
		if (p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right)) return true;
	}

	return false;
}
```
