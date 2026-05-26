// Reformat Date
namespace CompetitiveProgramming.LeetCode.ReformatDate;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string ReformatDate(string date)
    {
        var mouns = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        var arr = date.Split(' ');

        var day = int.TryParse((arr[0].Substring(0, arr[0].Length - 2)), out var dayValue) ? dayValue : 0;

        var monthIndex = mouns.IndexOf(arr[1]) + 1;

        var year = arr[2];

        var result = $"{year}-{monthIndex:D2}-{day:D2}";

        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.ReformatDate("20th Oct 2052"), "2052-10-20"),
            ResultTester.CheckResult<string>(solution.ReformatDate("6th Jun 1933"), "1933-06-06"),
            ResultTester.CheckResult<string>(solution.ReformatDate("26th May 1960"), "1960-05-26"),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Reformat Date");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}