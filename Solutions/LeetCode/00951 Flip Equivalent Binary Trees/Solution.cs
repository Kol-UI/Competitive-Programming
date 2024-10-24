// Flip Equivalent Binary Trees

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FlipEquivalentBinaryTrees
{
    public class Solution
    {
        public bool FlipEquiv(TreeNode root1, TreeNode root2)
        {
            if(root2 == null || root1 == null)
                return root1 == root2;
            
            return (root1.val == root2.val) && 
                ((FlipEquiv(root1.left, root2.right) && FlipEquiv(root1.right, root2.left)) || 
                (FlipEquiv(root1.left, root2.left) && FlipEquiv(root1.right, root2.right)));
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Flip Equivalent Binary Trees");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}