// Count Total Number of Colored Cells
namespace CompetitiveProgramming.LeetCode.CountTotalNumberofColoredCells;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using static System.Math;
public class Solution
{
    public long ColoredCells(int n) => (long)(Pow(n, 2) + Pow(n - 1, 2));
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution sol = new();

        bool[] results = new bool[]
        {
            ResultTester.CheckResult<long>(sol.ColoredCells(1), 1),
            ResultTester.CheckResult<long>(sol.ColoredCells(2), 5)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Total Number of Colored Cells");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}