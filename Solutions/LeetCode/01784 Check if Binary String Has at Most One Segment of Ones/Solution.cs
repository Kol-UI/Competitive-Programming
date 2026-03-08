// Check if Binary String Has at Most One Segment of Ones
namespace CompetitiveProgramming.LeetCode.CheckifBinaryStringHasatMostOneSegmentofOnes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool CheckOnesSegment(string s)
    {
        if (!s.Contains("01"))
        {
            return true;
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
            ResultTester.CheckResult<bool>(solution.CheckOnesSegment("1001"), false),
            ResultTester.CheckResult<bool>(solution.CheckOnesSegment("110"), true),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check if Binary String Has at Most One Segment of Ones");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}