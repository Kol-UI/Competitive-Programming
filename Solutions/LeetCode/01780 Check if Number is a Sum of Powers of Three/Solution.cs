// Check if Number is a Sum of Powers of Three
namespace CompetitiveProgramming.LeetCode.CheckifNumberisaSumofPowersofThree;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool CheckPowersOfThree(int n)
    {
        while(n != 0)
        {
            int value = n % 3;
            if (value == 2) return false;
            n /= 3;
        }
        return true;
    }
}

public class Test
{
    public static bool[] TestProblem()
    {
        Solution sol = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<bool>(sol.CheckPowersOfThree(12), true),
            ResultTester.CheckResult<bool>(sol.CheckPowersOfThree(91), true),
            ResultTester.CheckResult<bool>(sol.CheckPowersOfThree(21), false),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check if Number is a Sum of Powers of Three");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestProblem());
    }
}