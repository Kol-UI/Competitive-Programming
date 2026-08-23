// Binary Tree Preorder Traversal

Given the root of a binary tree, return the preorder traversal of its nodes' values.

Example 1 :

Input: root = [1,null,2,3]

Output: [1,2,3]


Example 2 :

Input: root = [1,2,3,4,5,null,8,null,null,6,7,9]

Output: [1,2,4,5,6,7,3,8,9]


Example 3 :

Input: root = []

Output: []


Example 4 :

Input: root = [1]

Output: [1]


```cs
// Root, Left, Right
public IList<int> PreorderTraversal(TreeNode root)
{
    var result = new List<int>();
    PreorderTraversal(root, result);
    return result;
}

private static void PreorderTraversal(TreeNode current, IList<int> result)
{
    if (current == null)
        return;

    result.Add(current.val); // root
    PreorderTraversal(current.left, result); // Sub tree left
    PreorderTraversal(current.right, result); // Sub tree right
}
```

