using System;
namespace CompetitiveProgramming.BinaryTreeMaximumPathSum
{
    public class Solution {
        private int max = Int32.MinValue;
        
        public int MaxPathSum(TreeNode root) {
            if (root != null)
                DFS(root);
            
            return max;
        }
        
        private int DFS(TreeNode node)
        {
            if (node == null)
                return 0;
            
            int left = DFS(node.left),
                right = DFS(node.right),
                lpath = node.val + left,
                rpath = node.val + right,
                path = lpath >= rpath ? lpath : rpath;
                        
            max = Math.Max(max, Math.Max(Math.Max(lpath + rpath - node.val, path), node.val));
                
            return node.val >= path ? node.val : path;
        }
    }

    public class Solution2 {
        int result = Int32.MinValue;
        
        public int MaxPathSum(TreeNode root) {
            MaxGain(root);
            return result;
        }
        
        public int MaxGain(TreeNode node)
        {
            if (node == null) return 0;
            
            int leftGain = Math.Max(MaxGain(node.left), 0);
            int rightGain = Math.Max(MaxGain(node.right), 0);
            
            result = Math.Max(result, node.val + leftGain+ rightGain);
            
            return Math.Max(node.val + leftGain, node.val + rightGain);
        }
    }
    
}