// Find Minimum Log Transportation Cost
namespace CompetitiveProgramming.LeetCode.FindMinimumLogTransportationCost;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MinCuttingCost(int n, int m, int k)
    {
        long res = 0;
        int[] sample = new int[]{n, m};

        for(int i = 0; i < 2; i++)
        {
            int cur = sample[i];
            if(cur > 0)
            {
                if(cur > k) res += (long)k * (cur - k);
            }
        }

        return res;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<long>(solution.MinCuttingCost(6, 5, 5), 5),
            ResultTester.CheckResult<long>(solution.MinCuttingCost(4, 4, 6), 0),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find Minimum Log Transportation Cost");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}