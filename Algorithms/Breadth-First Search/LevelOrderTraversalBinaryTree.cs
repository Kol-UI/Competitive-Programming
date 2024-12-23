namespace CompetitiveProgramming.Algorithms;

public class LevelOrderTraversalBinaryTree
{
    #region LC 102
    // Given the root of a binary tree, return the level order traversal of its nodes' values
    // Input: root = [3, 9,20, null,null,15,7]
    // Output: [[3],[9,20],[15,7]]
    public IList<IList<int>> GetLevelOrderTraversal(TreeNode root)
    {
        List<IList<int>> levelOrderList = new();
        if(root == null)
            return levelOrderList;

        Queue<TreeNode> queue = new();
        queue.Enqueue(root);

        while(queue.Count > 0)
        {
            int count = queue.Count;
            List<int> list = new();
            for(int i = 0; i < count; i++)
            {
                TreeNode node = queue.Dequeue();
                list.Add(node.val);

                if(node.left != null)
                    queue.Enqueue(node.left);

                if(node.right != null)
                    queue.Enqueue(node.right);
            }
            levelOrderList.Add(list);
        }
        return levelOrderList;
    }
    #endregion
}