
```cs
public IList<IList<int>> LevelOrder(TreeNode root)
{
    var result = new List<List<int>>();
    if (root == null) return new List<IList<int>>();

    Queue<TreeNode> queue = new();
    queue.Enqueue(root);

    while (queue.Count > 0)
    {
        int levelSize = queue.Count;
        List<int> currentLevel = new(levelSize);

        for (int i = 0; i < levelSize; i++)
        {
            TreeNode node = queue.Dequeue();
            currentLevel.Add(node.val);

            if (node.left != null) queue.Enqueue(node.left);
            if (node.right != null) queue.Enqueue(node.right);
        }

        result.Add(currentLevel);
    }

    return new List<IList<int>>(result);
}
```