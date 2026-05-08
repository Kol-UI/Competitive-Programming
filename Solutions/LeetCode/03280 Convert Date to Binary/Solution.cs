// Convert Date to Binary
namespace CompetitiveProgramming.LeetCode.ConvertDatetoBinary;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public static string intToString(string number)
    {
        return Convert.ToString(Int32.Parse(number), 2);
    }
    public string ConvertDateToBinary(string date)
    {
        string[] stringSplit = date.Split("-").Select(num => intToString(num)).ToArray();
        return String.Join("-", stringSplit);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.ConvertDateToBinary("2080-02-29"), "100000100000-10-11101"),
            ResultTester.CheckResult<string>(solution.ConvertDateToBinary("1900-01-01"), "11101101100-1-1")
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Convert Date to Binary");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}