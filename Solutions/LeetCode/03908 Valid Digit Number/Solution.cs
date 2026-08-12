// Valid Digit Number
namespace CompetitiveProgramming.LeetCode.ValidDigitNumber;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool ValidDigit(int n, int x)
    {
        string s = n.ToString();
        char firstDigit = x.ToString()[0];

        return s[0] != firstDigit && s.Contains(firstDigit);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.ValidDigit(101, 0), true),
            ResultTester.CheckResult<bool>(solution.ValidDigit(232, 2), false),
            ResultTester.CheckResult<bool>(solution.ValidDigit(5, 1), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Valid Digit Number");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}