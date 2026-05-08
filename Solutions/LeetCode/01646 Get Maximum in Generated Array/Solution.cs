// Get Maximum in Generated Array
namespace CompetitiveProgramming.LeetCode.GetMaximuminGeneratedArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
public class Solution
{
    public int GetMaximumGenerated(int n)
    {
        int[] res = new int[n + 1];
        int j = 1;
        for (int i = 0; i <= n; i++)
        {
            if (i == 0)
            {
                res[i] = 0;
            }
            else if (i == 1)
            {
                res[i] = 1;
            }
            else if (i > 1)
            {
                if (i % 2 == 0)
                {
                    res[i] = res[i - j];
                }
                else
                {
                    res[i] = res[j] + res[j + 1];
                    j++;
                }
            }
        }
        return res.Max();
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.GetMaximumGenerated(7), 3),
            ResultTester.CheckResult<int>(solution.GetMaximumGenerated(2), 1),
            ResultTester.CheckResult<int>(solution.GetMaximumGenerated(3), 2),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Get Maximum in Generated Array");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}