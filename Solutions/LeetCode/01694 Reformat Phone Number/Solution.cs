// Reformat Phone Number
namespace CompetitiveProgramming.LeetCode.ReformatPhoneNumber;

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string ReformatNumber(string number)
    {
        StringBuilder sb = new StringBuilder();
        var count = 0;
        foreach (var n in number)
        {
            if (count == 3)
            {
                count = 0;
                sb.Append('-');
            }
            if (n != ' ' && n != '-')
            {
                sb.Append(n);
                count++;
            }
        }
        if (sb[sb.Length - 1] == '-')
            sb.Remove(sb.Length - 1, 1);
        if (sb.Length % 4 == 1)
        {
            var temp = sb[sb.Length - 2];
            sb[sb.Length - 2] = sb[sb.Length - 3];
            sb[sb.Length - 3] = temp;
        }

        return sb.ToString();
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.ReformatNumber("1-23-45 6"), "123-456"),
            ResultTester.CheckResult<string>(solution.ReformatNumber("123 4-567"), "123-45-67"),
            ResultTester.CheckResult<string>(solution.ReformatNumber("123 4-5678"), "123-456-78"),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Reformat Phone Number");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}