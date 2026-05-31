// Check Array Formation Through Concatenation
namespace CompetitiveProgramming.LeetCode.ArrayFormationThroughConcatenation;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool CanFormArray(int[] arr, int[][] pieces) => pieces
        .OrderBy(p => Array.IndexOf(arr, p[0]))
        .SelectMany(p => p)
        .SequenceEqual(arr);
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.CanFormArray([15,88], [[88],[15]]), true),
            ResultTester.CheckResult<bool>(solution.CanFormArray([49,18,16], [[16,18,49]]), false),
            ResultTester.CheckResult<bool>(solution.CanFormArray([91,4,64,78], [[78],[4,64],[91]]), true),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check Array Formation Through Concatenation");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}