// Maximum Total from Optimal Activation Order
namespace CompetitiveProgramming.LeetCode.MaximumTotalfromOptimalActivationOrder;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MaxTotal(int[] value, int[] limit)
    {
        int[][] weightValueLimit = new int[value.Length][];
        for (int i = 0; i < value.Length; i++)
        {
            weightValueLimit[i] = new int[2] { value[i], limit[i] };
        }
        Array.Sort(weightValueLimit, (a, b) => (a[1] * 100000 - a[0]).CompareTo(b[1] * 100000 - b[0]));

        long sum = 0;
        int count = 0;
        for (int i = 0; i < weightValueLimit.Length; i++)
        {
            if (i == 0 || weightValueLimit[i][1] != weightValueLimit[i - 1][1])
            {
                count = 0;
            }
            else if (count >= weightValueLimit[i][1])
            {
                continue;
            }
            sum += weightValueLimit[i][0];
            count++;
        }
        return sum;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.MaxTotal([3,5,8], [2,1,3]), 16),
            ResultTester.CheckResult<long>(solution.MaxTotal([4,2,6], [1,1,1]), 6),
            ResultTester.CheckResult<long>(solution.MaxTotal([4,1,5,2], [3,3,2,3]), 12),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Total from Optimal Activation Order");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}