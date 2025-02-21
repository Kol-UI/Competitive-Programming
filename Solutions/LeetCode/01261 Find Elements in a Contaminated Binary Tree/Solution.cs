// Find Elements in a Contaminated Binary Tree
namespace CompetitiveProgramming.LeetCode.FindElementsinaContaminatedBinaryTree;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class FindElements 
{
    HashSet<int> values;

    public FindElements(TreeNode root)
    {
        values = new();
        AddValues(root, 0);
    }

    public void AddValues(TreeNode root, int curr)
    {
        values.Add(curr);
        if(root.left != null) AddValues(root.left, curr * 2 + 1);
        if(root.right != null) AddValues(root.right, curr * 2 + 2);
    }
    
    public bool Find(int target) => values.Contains(target);
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find Elements in a Contaminated Binary Tree");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}