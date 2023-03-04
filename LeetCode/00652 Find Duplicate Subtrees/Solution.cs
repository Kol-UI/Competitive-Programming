using System;
namespace CompetitiveProgramming.LeetCode.FindDuplicateSubtrees
{
    // Given the root of a binary tree, return all duplicate subtrees.
    // For each kind of duplicate subtrees, you only need to return the root node of any one of them.
    // Two trees are duplicate if they have the same structure with the same node values.

    // Example 1:
    // Input: root = [1,2,3,4,null,2,4,null,null,4]
    // Output: [[2,4],[4]]

    // Example 2:
    // Input: root = [2,2,2,3,null,3,null]
    // Output: [[2,3],[3]]

	public class Solution
	{
        private static readonly Dictionary<string, int> _map = new();
        private static readonly List<TreeNode> _result = new();

        public static IList<TreeNode> FindDuplicateSubtrees(TreeNode? root)
        {
            postOrderTraversal(root);
            return _result;
        }

        private static string postOrderTraversal(TreeNode? root)
        {
            if (root == null)
                return "/";

            var left = postOrderTraversal(root.left);
            var right = postOrderTraversal(root.right);

            var curr = root.val + "/" + left + "/" + right;

            if (_map.GetValueOrDefault(curr) == 1) 
                _result.Add(root);

            _map[curr] = _map.GetValueOrDefault(curr) + 1; 

            return curr; 
        }
    }
}

