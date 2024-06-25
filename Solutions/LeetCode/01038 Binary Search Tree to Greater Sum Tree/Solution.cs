// Binary Search Tree to Greater Sum Tree

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BinarySearchTreetoGreaterSumTree
{
    public class Solution
    {
        static void Sum (TreeNode root, Dictionary<int, int> keyValues)
        {
            if (root == null)
                return;

            int key = root.val;
            int max = 0;

            Sum(root.right, keyValues);

            if (keyValues.Count > 0) 
                max = keyValues.Keys.Max();
            
            for (int i = key + 1; i <= max; i++)
            {
                if (keyValues.ContainsKey(i))
                {
                    root.val += keyValues[i];
                    break;
                }
            }

            keyValues[key] = root.val;
            Sum(root.left, keyValues);
        }
        public TreeNode BstToGst(TreeNode root)
        {
            Sum(root, new Dictionary<int, int> ());
            return root;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Search Tree to Greater Sum Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}