// Construct the Longest New String
namespace CompetitiveProgramming.CodeForces.ConstructtheLongestNewString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int LongestString(int x, int y, int z)
    {
        var count = 0;

        var temp = Math.Min(x, y);
        count += temp * 4;
        x -= temp;
        y -= temp;

        if (x > 0)
            count += z * 2 + 2;
        else if (y > 0)
            count += z * 2 + 2;
        else
            count += z * 2;

        return count;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.LongestString(2, 5, 1), 12),
            ResultTester.CheckResult<int>(solution.LongestString(3, 2, 2), 14),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Construct the Longest New String");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}