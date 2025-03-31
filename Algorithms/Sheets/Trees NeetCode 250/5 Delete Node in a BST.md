
```cs
public class Solution
{
    public TreeNode DeleteNode(TreeNode root, int key)
	{
		if (root == null) return null;

		if (key < root.val) root.left = DeleteNode(root.left, key);
		else if (key > root.val) root.right = DeleteNode(root.right, key);
		else
		{
			if (root.left == null) return root.right;
			if (root.right == null) return root.left;

			TreeNode successor = Helper(root.right);
			root.val = successor.val;
			root.right = DeleteNode(root.right, successor.val);
		}

		return root;
	}

	private TreeNode Helper(TreeNode node)
	{
		while (node.left != null)
		{
			node = node.left;
		}
		return node;
	}
}
```

