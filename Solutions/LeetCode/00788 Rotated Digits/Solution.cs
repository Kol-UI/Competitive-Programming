// Rotated Digits
namespace CompetitiveProgramming.LeetCode.RotatedDigits;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    int[] mappings = new int[] { 0, 1, 5, -1, -1, 2, 9, -1, 8, 6 };

    public int RotatedDigits(int n)
    {
        int count = 0;

        for (int i = 2; i <= n; i++)
        {
            if (IsValid(i))
            {
                count++;
            }
        }

        return count;
    }

    private bool IsValid(int n)
    {
        int newNum = 0;
        int temp = n;
        int mul = 1;

        while (temp != 0)
        {
            int x = temp % 10;

            if (mappings[x] < 0)
            {
                return false;
            }

            newNum = newNum + mappings[x] * mul;
            mul = mul * 10;
            temp = temp / 10;
        }

        return newNum != n;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.RotatedDigits(10), 4),
            ResultTester.CheckResult<int>(solution.RotatedDigits(1), 0),
            ResultTester.CheckResult<int>(solution.RotatedDigits(2), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Rotated Digits");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}