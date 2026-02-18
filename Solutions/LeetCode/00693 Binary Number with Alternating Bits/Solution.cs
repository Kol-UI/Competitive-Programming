// Binary Number with Alternating Bits
namespace CompetitiveProgramming.LeetCode.BinaryNumberwithAlternatingBits;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool HasAlternatingBits(int n)
    {
        var x = n ^ (n >> 1);
        return (x & (x + 1)) == 0;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.HasAlternatingBits(5), true),
            ResultTester.CheckResult<bool>(solution.HasAlternatingBits(7), false),
            ResultTester.CheckResult<bool>(solution.HasAlternatingBits(11), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Binary Number with Alternating Bits");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}