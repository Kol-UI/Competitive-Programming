// Maximize Sum of Squares of Digits
namespace CompetitiveProgramming.LeetCode.MaximizeSumofSquaresofDigits;

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string MaxSumOfSquares(int num, int sum)
    {
        if (sum > 9 * num) return string.Empty;

        StringBuilder sb = new();

        sb.Append('9', sum / 9);

        int rem = sum % 9;
        if (rem > 0) sb.Append(rem);

        sb.Append('0', num - sb.Length);

        return sb.ToString();
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.MaxSumOfSquares(2, 3), "30"),
            ResultTester.CheckResult<string>(solution.MaxSumOfSquares(2, 17), "98"),
            ResultTester.CheckResult<string>(solution.MaxSumOfSquares(1, 10), ""),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximize Sum of Squares of Digits");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}