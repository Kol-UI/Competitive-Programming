using CompetitiveProgramming.LeetCode;
namespace CompetitiveProgramming.Helpers
{
    public class TreeNodeToStringConverter
    {
        public static string TreeNodeToString(TreeNode root)
        {
            if (root == null)
                return "null";

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            List<string> result = new List<string>();

            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();

                if (node == null)
                {
                    result.Add("null");
                }
                else
                {
                    result.Add(node.val.ToString());
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
            }

            while (result.Count > 0 && result[^1] == "null")
            {
                result.RemoveAt(result.Count - 1);
            }

            return "[" + string.Join(",", result) + "]";
        }
    }
}