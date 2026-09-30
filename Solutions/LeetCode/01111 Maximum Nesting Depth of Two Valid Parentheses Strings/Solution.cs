// Maximum Nesting Depth of Two Valid Parentheses Strings
namespace CompetitiveProgramming.LeetCode.MaximumNestingDepthofTwoValidParenthesesStrings;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] MaxDepthAfterSplit(string seq)
    {
        var depth = 0;
        return seq.Select(c => c == '(' ? ++depth % 2 : depth-- % 2).ToArray();
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Nesting Depth of Two Valid Parentheses Strings");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}