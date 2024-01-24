// Pseudo-Palindromic Paths in a Binary Tree


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.PseudoPalindromicPathsinaBinaryTree
{
    public class Solution
    {
        public static void Helper(TreeNode root, HashSet<int> map, ref int count)
        {
            if(root == null)
                return;

            if(!map.Add(root.val))
                map.Remove(root.val);

            if(root.left == null && root.right == null)
            {
                if(map.Count < 2)
                    count++;
            }
            else
            {
                Helper(root.left!, map, ref count);
                Helper(root.right, map, ref count);
            }

            if(!map.Remove(root.val))
                map.Add(root.val);
        }

        public static int PseudoPalindromicPaths (TreeNode root)
        {
            int answer = 0;
            HashSet<int> map = new HashSet<int>();
            Helper(root, map, ref answer);
            return answer;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Test Case 1
            TreeNode root1 = new TreeNode(2,
                new TreeNode(3,
                    new TreeNode(3),
                    new TreeNode(1)),
                new TreeNode(1,
                    null!,
                    new TreeNode(1)));

            // Test Case 2
            TreeNode root2 = new TreeNode(2,
                new TreeNode(1,
                    new TreeNode(1),
                    new TreeNode(3,
                        new TreeNode(1))),
                null!);

            TreeNode root3 = new TreeNode(9);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.PseudoPalindromicPaths(root1), 2),
                ResultTester.CheckResult<int>(Solution.PseudoPalindromicPaths(root2), 1),
                ResultTester.CheckResult<int>(Solution.PseudoPalindromicPaths(root3), 1),
            };
            return results;
        }
    }
}