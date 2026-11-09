// Difference Between Peaks and Valleys
namespace CompetitiveProgramming.LeetCode.DifferenceBetweenPeaksandValleys;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int PeakValleyDifference(int[] nums)
    {
        var peaks = 0;
        var valleys = 0;

        for (var i = 1; i < nums.Length - 1; i++)
        {
            if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
            {
                peaks += nums[i];
            }
            else if (nums[i] < nums[i - 1] && nums[i] < nums[i + 1])
            {
                valleys += nums[i];
            }
        }

        return peaks - valleys;    
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.PeakValleyDifference([1,5,2,4,1,3,0]), 9),
            ResultTester.CheckResult<int>(solution.PeakValleyDifference([-5,-6,-1,-2,5,3,2]), 12),
            ResultTester.CheckResult<int>(solution.PeakValleyDifference([6,5,2,5,5,3,6]), -5),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Difference Between Peaks and Valleys");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}