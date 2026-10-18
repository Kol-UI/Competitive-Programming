// Minimum Insertions to Balance a Parentheses String
namespace CompetitiveProgramming.LeetCode.MinimumInsertionstoBalanceaParenthesesString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinInsertions(string s)
    {
        int res = 0;
        int leftCount = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                leftCount++;
            }
            else
            {
                if (leftCount > 0)
                    leftCount--;
                else
                    res++;

                if (i + 1 < s.Length && s[i + 1] == ')')
                    i++;
                else
                    res++;
            }
        }

        return res + leftCount * 2;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinInsertions("(()))"), 1),
            ResultTester.CheckResult<int>(solution.MinInsertions("())"), 0),
            ResultTester.CheckResult<int>(solution.MinInsertions("))())("), 3),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Insertions to Balance a Parentheses String");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}