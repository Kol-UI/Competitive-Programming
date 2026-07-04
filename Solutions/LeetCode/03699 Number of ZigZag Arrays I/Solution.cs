// Number of ZigZag Arrays I
namespace CompetitiveProgramming.LeetCode.NumberofZigZagArraysI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int ZigZagArrays(int n, int l, int r)
    {
        var col0 = new long[r - l + 1];
        for (int i = 0; i < col0.Length - 1; i++) col0[i] = 1;
        var isPeak = true;
        for (int i = n - 2; i >= 0; i--)
        {
            var col1 = new long[r - l + 1];
            if (isPeak)
            {
                for (int j = 1; j < col1.Length; j++)
                {
                    col1[j] = (col1[j - 1] + col0[j - 1]) % 1_000_000_007;
                }
            }
            else
            {
                for (int j = col1.Length - 2; j >= 0; j--)
                {
                    col1[j] = (col1[j + 1] + col0[j + 1]) % 1_000_000_007;
                }
            }
            col0 = col1;
            isPeak = !isPeak;
        }
        return (int)((col0.Sum() * 2)% 1_000_000_007);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.ZigZagArrays(3, 4, 5), 2),
            ResultTester.CheckResult<int>(solution.ZigZagArrays(3, 1, 3), 10),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Number of ZigZag Arrays I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}