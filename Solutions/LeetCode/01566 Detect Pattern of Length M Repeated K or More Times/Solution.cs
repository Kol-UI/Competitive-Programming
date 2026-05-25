// Detect Pattern of Length M Repeated K or More Times
namespace CompetitiveProgramming.LeetCode.DetectPatternofLengthMRepeatedKorMoreTimes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool ContainsPattern(int[] arr, int m, int k)
    {
        var count = 0;

        for (var i = 0; i + m < arr.Length; i++)
        {
            if (arr[i] != arr[i + m])
            {
                count = 0;
                continue;
            }

            ++count;

            if (count == (k - 1) * m)
            {
                return true;
            }
        }

        return false;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.ContainsPattern([1,2,4,4,4,4], 1, 3), true),
            ResultTester.CheckResult<bool>(solution.ContainsPattern([1,2,1,2,1,1,1,3], 2, 2), true),
            ResultTester.CheckResult<bool>(solution.ContainsPattern([1,2,1,2,1,3], 2, 3), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Detect Pattern of Length M Repeated K or More Times");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}