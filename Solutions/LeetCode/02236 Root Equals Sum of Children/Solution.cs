// Root Equals Sum of Children
namespace CompetitiveProgramming.LeetCode.RootEqualsSumofChildren;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool CheckTree(TreeNode root)
    {
        return (root.val == (root.left.val+root.right.val));
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Root Equals Sum of Children");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}