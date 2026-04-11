// Count Monobit Integers
namespace CompetitiveProgramming.LeetCode.CountMonobitIntegers;

using System.Numerics;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountMonobit(int n) => BitOperations.Log2((ulong)(n + 1L)) + 1;
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.CountMonobit(1), 2),
            ResultTester.CheckResult<int>(solution.CountMonobit(4), 3),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Monobit Integers");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}