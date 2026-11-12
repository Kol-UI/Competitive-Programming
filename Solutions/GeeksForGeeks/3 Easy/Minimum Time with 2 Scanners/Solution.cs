// Minimum Time with 2 Scanners
namespace CompetitiveProgramming.GeeksForGeeks.Easy.MinimumTimewithTwoScanners;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

class Solution
{
    public int minTime(int n, int s1, int s2)
    {
        long low = 0;
        long high = (long)n * Math.Min(s1, s2);
        while (low < high)
        {
            long mid = low + (high - low) / 2;
            if (mid / s1 + mid / s2 >= n) high = mid;
            else low = mid + 1;
        }
        return (int)low;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.minTime(2, 2, 4), 4),
            ResultTester.CheckResult<int>(solution.minTime(2, 1, 3), 2),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Time with 2 Scanners");
        ResultTester.CheckCurrentSolution(ProblemOrigin.GeeksForGeeks, ProblemCategory.EasyGFG, Test.TestCases());
    }
}