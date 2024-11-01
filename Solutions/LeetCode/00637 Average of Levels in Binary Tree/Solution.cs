// Average of Levels in Binary Tree

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.AverageofLevelsinBinaryTree
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
        private readonly Dictionary<int, (int count, long sum)> dict = new();

        public IList<double> AverageOfLevels(TreeNode root) {
            var list = new List<double>();

            if (root == null) { return list; }

            Traverse(root, 1);

            foreach (var (key,value) in dict)
            {
                list.Add(value.sum / (double)value.count);
            }

            return list;
        }

        void Traverse(TreeNode node, int level)
        {
            if (!dict.TryAdd(level, (1, node.val)))
            {
                var levelData = dict[level];

                levelData.count++;
                levelData.sum += node.val;

                dict[level] = levelData;
            }

            if (node.left == null && node.right == null) { return; }

            level += 1;

            if (node.left != null) { Traverse(node.left, level); }
            if (node.right != null) { Traverse(node.right, level); }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Average of Levels in Binary Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}