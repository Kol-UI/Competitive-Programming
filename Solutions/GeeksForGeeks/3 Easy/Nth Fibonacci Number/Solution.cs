// Nth Fibonacci Number
namespace CompetitiveProgramming.GeeksForGeeks.Easy.NthFibonacciNumber;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int nthFibonacci(int n)
    {
        if (n <= 1) return n;
        int a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            int c = a + b;
            a = b;
            b = c;
        }
        return b;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.nthFibonacci(5), 5),
            ResultTester.CheckResult<int>(solution.nthFibonacci(0), 0),
            ResultTester.CheckResult<int>(solution.nthFibonacci(1), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Nth Fibonacci Number");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyGFG, Test.TestCases());
    }
}