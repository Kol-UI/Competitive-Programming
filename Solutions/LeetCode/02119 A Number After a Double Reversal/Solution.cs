// A Number After a Double Reversal
namespace CompetitiveProgramming.LeetCode.ANumberAfteraDoubleReversal;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool IsSameAfterReversals(int num) => num == 0 || num % 10 != 0;
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("A Number After a Double Reversal");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}