Balanced Binary Tree

```cs
// A height-balanced binary tree is defined as a binary tree in which the left and right subtrees of every node differ in height by no more than 1
// 150
public bool IsBalanced(TreeNode root)
{
	if (root == null) return true;

	int leftHeight = HeightNode(root.left);
	int rightHeight = HeightNode(root.right);

	// Math.Abs because it can be negative
	if (Math.Abs(leftHeight - rightHeight) > 1) return false;
	return IsBalanced(root.left) && IsBalanced(root.right);
}

private int HeightNode(TreeNode root)
{
	if (root == null) return 0;

	return 1 + Math.Max(HeightNode(root.left), HeightNode(root.right));
}
```
