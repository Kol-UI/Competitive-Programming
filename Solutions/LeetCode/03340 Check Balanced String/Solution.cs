// Check Balanced String
namespace CompetitiveProgramming.LeetCode.CheckBalancedString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool IsBalanced(string num)
    {
        var oddSum = 0;
        var evenSum = 0;

        for (var i = 0; i < num.Length; i++)
        {
            var value = Convert.ToInt32(num[i].ToString());
            if (i % 2 == 0)
            {
                oddSum += value;
            }
            else
            {
                evenSum += value;
            }
        }

        return oddSum == evenSum;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.IsBalanced("1234"), false),
            ResultTester.CheckResult<bool>(solution.IsBalanced("24123"), true),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check Balanced String");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}