// Basic Calculator
namespace CompetitiveProgramming.LeetCode.BasicCalculator;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int Calculate(string s)
    {
        var stack = new Stack<int>();
        int num = 0;
        var sign = 1;

        var result = 0;
        foreach (var ch in s)
        {
            if (char.IsDigit(ch))
                num = 10 * num + (ch - '0');
            else if (ch == '+')
            {
                result += sign * num;
                sign = 1;
                num = 0;
            }
            else if (ch == '-')
            {
                result += sign * num;
                sign = -1;
                num = 0;
            }
            else if (ch == '(')
            {
                stack.Push(result);
                stack.Push(sign);

                sign = 1;
                num = 0;
                result = 0;
            }
            else if (ch == ')')
            {
                result += sign * num;

                num = result;
                sign = stack.Pop();
                result = stack.Pop();
            }
        }

        return result + sign * num;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.Calculate("1 + 1"), 2),
            ResultTester.CheckResult<int>(solution.Calculate(" 2-1 + 2 "), 3),
            ResultTester.CheckResult<int>(solution.Calculate("(1+(4+5+2)-3)+(6+8)"), 23),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Basic Calculator");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}