// License Key Formatting
namespace CompetitiveProgramming.LeetCode.LicenseKeyFormatting;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string LicenseKeyFormatting(string s, int k) => new([.. string.Join("-", new string([.. s.ToUpper().Replace("-", string.Empty).Reverse()]).Chunk(k).Select(m => new string(m))).Reverse()]);
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.LicenseKeyFormatting("5F3Z-2e-9-w", 4), "5F3Z-2E9W"),
            ResultTester.CheckResult<string>(solution.LicenseKeyFormatting("2-5g-3-J", 2), "2-5G-3J"),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("License Key Formatting");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}