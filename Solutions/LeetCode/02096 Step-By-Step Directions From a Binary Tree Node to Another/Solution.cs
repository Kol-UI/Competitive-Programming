// Step-By-Step Directions From a Binary Tree Node to Another

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.StepByStepDirectionsFromaBinaryTreeNodetoAnother
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
        public string GetDirections(TreeNode root, int startValue, int destValue)
        {
            StringBuilder startChars = new(), finalChars = new();
            DFS(root, startValue, startChars);
            DFS(root, destValue, finalChars);
            
            RemoveCommonPath(startChars, finalChars);
            
            ReverseSB(finalChars);

            startChars.Replace('R', 'U');
            startChars.Replace('L', 'U');
            return startChars.Append(finalChars).ToString();
        }

        private bool DFS(TreeNode node, int find, StringBuilder target)
        {
            if(node is null) return false;
            if(node.val == find) return true;

            var left = DFS(node.left, find, target);
            if(left) target.Append('L');
            var right = DFS(node.right, find, target);
            if(right) target.Append('R');

            return left || right;
        }

        private void RemoveCommonPath(StringBuilder path1, StringBuilder path2)
        {
            while(path1.Length > 0 && path2.Length > 0 && path1[path1.Length - 1] == path2[path2.Length - 1])
            {
                path1.Remove(path1.Length - 1, 1);
                path2.Remove(path2.Length - 1, 1);
            }
        }

        private void ReverseSB(StringBuilder path)
        {
            for(int i = 0; i < path.Length / 2; i++)
            {
                var temp = path[path.Length - i - 1];
                path[path.Length - i - 1] = path[i];
                path[i] = temp;
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Step-By-Step Directions From a Binary Tree Node to Another");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}