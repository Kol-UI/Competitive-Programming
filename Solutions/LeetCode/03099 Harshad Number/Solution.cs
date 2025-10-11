// Harshad Number
namespace CompetitiveProgramming.LeetCode.HarshadNumber;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int SumOfTheDigitsOfHarshadNumber(int x)
    {
        int sum = 0;
        foreach (char a in Convert.ToString(x))
        {
            sum = sum + Convert.ToInt32(a.ToString());
        }

        if(x % sum == 0) return sum;
        else return -1;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.SumOfTheDigitsOfHarshadNumber(18), 9),
            ResultTester.CheckResult<int>(solution.SumOfTheDigitsOfHarshadNumber(23), -1)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Harshad Number");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}