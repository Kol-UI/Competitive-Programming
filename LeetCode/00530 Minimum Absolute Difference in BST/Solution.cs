using System;
namespace CompetitiveProgramming.LeetCode.MinimumAbsoluteDifferenceinBST
{
    public class Solution
    {
        //Given the root of a Binary Search Tree (BST), return the minimum absolute difference between the values of any two different nodes in the tree.
        
        // Example 1:
        // Input: root = [4,2,6,1,3]
        // Output: 1

        // Example 2:
        // Input: root = [1,0,48,null,null,12,49]
        // Output: 1

        public int MinDiffInBST(TreeNode root)
        {
            int result = int.MaxValue;
            List<int> values = new(); 
            Stack<TreeNode> stack = new();
            stack.Push(root);
            while(stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                values.Add(node.val);
                if(node.left is not null) stack.Push(node.left);
                if(node.right is not null) stack.Push(node.right);
            }
            values.Sort();
            for(int i = 1; i < values.Count; ++i)
            {
                int diff = values[i] - values[i - 1];
                result = result > diff ? diff : result; 
            }
            return result;
        }
    }
}

