// Final Value of Variable After Performing Operations
namespace CompetitiveProgramming.LeetCode.FinalValueofVariableAfterPerformingOperations;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int FinalValueAfterOperations(string[] operations)
    {
        return operations.Count(x => x.Contains("++")) - operations.Count(x => x.Contains("--"));
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Final Value of Variable After Performing Operations");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}