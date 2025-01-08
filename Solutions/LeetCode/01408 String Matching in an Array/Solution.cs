// String Matching in an Array

namespace CompetitiveProgramming.LeetCode.StringMatchinginanArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public IList<string> StringMatching(string[] words)
    {
        return words.Where(w => words.Any(a => a.Contains(w) && a.Length > w.Length)).ToList();
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("String Matching in an Array");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}