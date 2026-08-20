// Count Valid Prefixes
namespace CompetitiveProgramming.LeetCode.CountValidPrefixes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountValidPrefixes(string s)
    {
        int count0 = 0;
        int count1 = 0;
        int validPrefixes = 0;

        foreach (char c in s)
        {
            if (c == '0')
            {
                count0++;
            }
            else
            {
                count1++;
            }

            if (Math.Abs(count0 - count1) <= 1)
            {
                validPrefixes++;
            }
        }

        return validPrefixes;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.CountValidPrefixes("00101"), 3),
            ResultTester.CheckResult<int>(solution.CountValidPrefixes("101"), 3),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Valid Prefixes");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}