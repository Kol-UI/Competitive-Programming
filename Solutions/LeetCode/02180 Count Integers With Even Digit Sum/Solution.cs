// Count Integers With Even Digit Sum
namespace CompetitiveProgramming.LeetCode.CountIntegersWithEvenDigitSum;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution 
{
    public int CountEven(int num)
    {
        int nums = 0;

        for (int i = 1; i <= num; i++)
        {
            int moduloNum = i;
            int sum = 0;

            while (moduloNum > 0)
            {
                var digit = moduloNum % 10;
                sum += digit;
                moduloNum = moduloNum / 10;
            }

            if (sum % 2 == 0) nums += 1;
        }

        return nums;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.CountEven(4), 2),
            ResultTester.CheckResult<int>(solution.CountEven(30), 14),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Integers With Even Digit Sum");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}