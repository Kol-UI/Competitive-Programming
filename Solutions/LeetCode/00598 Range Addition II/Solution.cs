// Range Addition II
namespace CompetitiveProgramming.LeetCode.RangeAdditionII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxCount(int m, int n, int[][] ops)
    {
        if (ops.Length == 0)
        {
            return m * n;
        }

        int minX = int.MaxValue;
        int minY = int.MaxValue;
        for (int i = 0; i < ops.Length; i++)
        {
            if (ops[i][0] < minX)
            {
                minX = ops[i][0];
            }
            if (ops[i][1] < minY)
            {
                minY = ops[i][1];
            }
        }
        
        return minX * minY;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MaxCount(3, 3, [[2,2],[3,3],[3,3],[3,3],[2,2],[3,3],[3,3],[3,3],[2,2],[3,3],[3,3],[3,3]]), 4),
            ResultTester.CheckResult<int>(solution.MaxCount(3, 3, [[2,2],[3,3]]), 4),
            ResultTester.CheckResult<int>(solution.MaxCount(3, 3, []), 9)
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Range Addition II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}