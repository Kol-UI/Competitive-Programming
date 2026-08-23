// Binary Tree Inorder Traversal

Given the root of a binary tree, return the inorder traversal of its nodes' values.

Example 1 :

Input: root = [1,null,2,3]

Output: [1,3,2]


Example 2 :

Input: root = [1,2,3,4,5,null,8,null,null,6,7,9]

Output: [4,2,6,5,7,1,3,9,8]


Example 3 :

Input: root = []

Output: []


Example 4 :

Input: root = [1]

Output: [1]


```cs
public class Solution
{
    // Left, Root, Right
	public IList<int> InorderTraversal(TreeNode root)
	{
		var result = new List<int>();

		return InorderTraversal(root, result);
	}

	private IList<int> InorderTraversal(TreeNode current, IList<int> result)
	{
		if (current == null) return result;

		InorderTraversal(current.left, result); // Sub tree left
		result.Add(current.val); // Root
		InorderTraversal(current.right, result); // Sub tree right

		return result;
	}
}
```

