// Minimum Operations to Equalize Binary String
namespace CompetitiveProgramming.LeetCode.MinimumOperationstoEqualizeBinaryString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinOperations(string s, int k)
    {
        long z = 0;

        foreach (char ch in s)
        {
            if (ch == '0')
                z++;
        }

        long n = s.Length;
        long o = n - z;

        if (z == 0)
            return 0;

        for (long i = 1; i <= n; i++)
        {
            long p = i * (long)k;

            if (((p - z) & 1) != 0)
                continue;

            if ((i & 1) == 1)
            {
                if (p >= z && p <= (z * i + o * (i - 1)))
                    return (int)i;
            }
            else
            {
                if (p >= z && p <= (z * (i - 1) + o * i))
                    return (int)i;
            }
        }

        return -1;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinOperations("110", 1), 1),
            ResultTester.CheckResult<int>(solution.MinOperations("0101", 3), 2),
            ResultTester.CheckResult<int>(solution.MinOperations("101", 2), -1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Operations to Equalize Binary String");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}