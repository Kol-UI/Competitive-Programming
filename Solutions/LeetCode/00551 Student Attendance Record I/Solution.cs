// Student Attendance Record I
namespace CompetitiveProgramming.LeetCode.StudentAttendanceRecordI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool CheckRecord(string s) => !s.Contains("LLL") && s.Count(c => c == 'A') < 2;
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.CheckRecord("PPALLP"), true),
            ResultTester.CheckResult<bool>(solution.CheckRecord("PPALLL"), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Student Attendance Record I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}