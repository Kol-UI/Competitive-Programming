// Number of Smooth Descent Periods of a Stock
namespace CompetitiveProgramming.LeetCode.NumberofSmoothDescentPeriodsofaStock;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long GetDescentPeriods(int[] values)
    {
        long total = 0;
        int consecutive = 0;
        int previous = -1;

        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] == previous - 1)
            {
                consecutive++;
            }
            else
            {
                consecutive = 1;
            }
            previous = values[i];
            total += consecutive;
        }

        return total;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<long>(solution.GetDescentPeriods([3,2,1,4]), 7),
            ResultTester.CheckResult<long>(solution.GetDescentPeriods([8,6,7,7]), 4),
            ResultTester.CheckResult<long>(solution.GetDescentPeriods([1]), 1),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Number of Smooth Descent Periods of a Stock");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}