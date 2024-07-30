// Binary Tree Paths

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BinaryTreePaths
{
    /**
    * Definition for a binary tree node.
    * public class TreeNode {
    *     public int val;
    *     public TreeNode left;
    *     public TreeNode right;
    *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
    *         this.val = val;
    *         this.left = left;
    *         this.right = right;
    *     }
    * }
    */
    public class Solution
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            var paths = new List<string>();
            if (root == null)
            {
                return paths;
            }

            void FindPaths(TreeNode node, string path)
            {
                if (node != null)
                {
                    path += node.val;
                    if (node.left == null && node.right == null)
                    {
                        paths.Add(path);
                    }
                    else
                    {
                        path += "->";
                        FindPaths(node.left!, path);
                        FindPaths(node.right, path);
                    }
                }
            }

            FindPaths(root, "");
            return paths;
        }
    }
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Tree Paths");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}