namespace CompetitiveProgramming.Algorithms;

public class PerfectBinaryTree
{
    // A binary tree is perfect if all parent nodes have two children and all leaves are on the same level
    public static bool IsPerfectBinaryTree(TreeNode root)
    {
        if (root == null)
            return true;

        return IsPerfect(root, 0);
    }

    private static bool IsPerfect(TreeNode node, int depth)
    {
        
        if (node == null)
            return depth == 0;
            
        if (IsPerfect(node.left, depth + 1) == false || IsPerfect(node.right, depth + 1) == false)
            return false;

        return true;
    }

    /*
        For Perfect Binary Trees : 
        Level 0 has 1 node (root)
        Level 1 has 2 nodes
        Level 2 has 4 nodes, etc.
    */
    public static int GetLevelFromNodeCount(int nodeCount)
    {
        if (nodeCount <= 0)
            throw new ArgumentException("Number of node should be positive");
        return (int)Math.Log2(nodeCount + 1) - 1;
    }

    public static int CountNodes(TreeNode root)
    {
        if (root == null)
            return 0;
        return 1 + CountNodes(root.left) + CountNodes(root.right);
    }

    #region LC 2415
    public static TreeNode ReverseOddLevels(TreeNode root)
    {
        if (root == null)
            return null!;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int level = 0;

        while (queue.Count > 0)
        {
            int size = queue.Count;
            List<TreeNode> currentLevelNodes = new List<TreeNode>();

            for (int i = 0; i < size; i++)
            {
                TreeNode node = queue.Dequeue();
                currentLevelNodes.Add(node);

                if (node.left != null)
                    queue.Enqueue(node.left);
                if (node.right != null)
                    queue.Enqueue(node.right);
            }

            if (level % 2 == 1)
            {
                int left = 0;
                int right = currentLevelNodes.Count - 1;

                while (left < right)
                {
                    int temp = currentLevelNodes[left].val;
                    currentLevelNodes[left].val = currentLevelNodes[right].val;
                    currentLevelNodes[right].val = temp;

                    left++;
                    right--;
                }
            }

            level++;
        }

        return root;
    }
    #endregion
}