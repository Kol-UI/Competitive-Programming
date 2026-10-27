// Create Grid With Exactly One Path
namespace CompetitiveProgramming.LeetCode.CreateGridWithExactlyOnePath;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string[] CreateGrid(int m, int n) => Enumerable.Range(0, m).Select(x => new string(x == 0 ? '.' : '#', n - 1) + ".").ToArray();
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Create Grid With Exactly One Path");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}