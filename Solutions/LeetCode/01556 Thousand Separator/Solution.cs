// Thousand Separator
namespace CompetitiveProgramming.LeetCode.ThousandSeparator;

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string ThousandSeparator(int n)
    {
        if(n < 1000) return n.ToString();
        StringBuilder result = new StringBuilder(n.ToString());
        var f = result.Length-3;
        for(int i = f; i > 0; i -= 3) result.Insert(i,'.');
        return result.ToString();
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Thousand Separator");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}