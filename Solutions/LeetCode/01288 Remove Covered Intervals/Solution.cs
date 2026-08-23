// Remove Covered Intervals
namespace CompetitiveProgramming.LeetCode.RemoveCoveredIntervals;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int RemoveCoveredIntervals(int[][] intervals)
    {
        Array.Sort(intervals, (i1, i2) =>
        {
            if(i1[0] == i2[0]){
                return i2[1] - i1[1];
            }

            return i1[0] - i2[0];
        });

        int i = 1, end = intervals[0][1], res = 1;

        while(i < intervals.Length)
        {
            if(intervals[i][1] > end)
            {
                end = intervals[i][1];
                res++;
            }
            i++;
        }

        return res;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.RemoveCoveredIntervals([[1,4],[3,6],[2,8]]), 2),
            ResultTester.CheckResult<int>(solution.RemoveCoveredIntervals([[1,4],[2,3]]), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Remove Covered Intervals");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}