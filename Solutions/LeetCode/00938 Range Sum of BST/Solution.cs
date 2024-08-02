// Range Sum of BST


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.RangeSumofBST
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
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            if(root == null)
            {
                return 0;
            }

            int sum = 0;

            if(low <= root.val && root.val <= high)
            {
                sum += root.val;
            }

            sum += RangeSumBST(root.left, low, high);
            sum += RangeSumBST(root.right, low, high);
            
            return sum;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();

            TreeNode root1 = new(10)
            {
                left = new TreeNode(5),
                right = new TreeNode(15)
            };
            root1.left.left = new TreeNode(3);
            root1.left.right = new TreeNode(7);
            root1.right.right = new TreeNode(18);

            TreeNode root2 = new(10)
            {
                left = new TreeNode(5),
                right = new TreeNode(15)
            };
            root2.left.left = new TreeNode(3);
            root2.left.right = new TreeNode(7);
            root2.right.left = new TreeNode(13);
            root2.right.right = new TreeNode(18);
            root2.left.left.left = new TreeNode(1);
            root2.left.right.left = new TreeNode(6);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.RangeSumBST(root1, 7, 15), 32),
                ResultTester.CheckResult<int>(solution.RangeSumBST(root2, 6, 10), 23),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("938");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}