namespace CompetitiveProgramming.Algorithms;
#nullable disable
public class SortBinarytreeByLevel
{
    #region LC 2471
    // Number of operations to sort a binary tree by level
    public int MinimumOperations(TreeNode root)
    {
        if (root == null)
            return 0;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        int totalSwaps = 0;

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            List<int> levelValues = new List<int>();

            for (int i = 0; i < levelSize; i++)
            {
                TreeNode currentNode = queue.Dequeue();
                levelValues.Add(currentNode.val);

                if (currentNode.left != null)
                    queue.Enqueue(currentNode.left);
                if (currentNode.right != null)
                    queue.Enqueue(currentNode.right);
            }

            totalSwaps += CountSwapsToSort(levelValues);
        }

        return totalSwaps;
    }

    private int CountSwapsToSort(List<int> values)
    {
        int[] sortedValues = values.ToArray();
        Array.Sort(sortedValues);
        Dictionary<int, int> valueToIndex = new Dictionary<int, int>();

        for (int i = 0; i < values.Count; i++)
        {
            valueToIndex[values[i]] = i;
        }

        bool[] visited = new bool[values.Count];
        int swaps = 0;

        for (int i = 0; i < values.Count; i++)
        {
            if (visited[i] || valueToIndex[sortedValues[i]] == i)
                continue;

            int cycleSize = 0;
            int j = i;

            while (!visited[j])
            {
                visited[j] = true;
                j = valueToIndex[sortedValues[j]];
                cycleSize++;
            }

            if (cycleSize > 1)
                swaps += cycleSize - 1;
        }

        return swaps;
    }
    #endregion
}
#nullable enable