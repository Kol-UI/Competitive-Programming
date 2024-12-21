namespace CompetitiveProgramming.Algorithms;

public class SymmetricBinaryTree
{
    public class Solution
    {
        #region LC 101
        // Symmetric Binary Tree :
        // Under the root, check if the left subtree is the mirror of the right subtree
        public bool IsSymmetric(TreeNode root)
        {
            return CheckIfSummetric(root.left,root.right);
        }

        private bool CheckIfSummetric(TreeNode a, TreeNode b)
        {
            if(a == null && b == null)
                return true;

            if(a == null || b == null)
                return false;
            
            return a.val == b.val && CheckIfSummetric(a.left,b.right) && CheckIfSummetric(a.right, b.left);
        }
        #endregion
    }
}