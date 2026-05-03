// Number of Different Integers in a String
namespace CompetitiveProgramming.CodeForces.NumberofDifferentIntegersinaString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int NumDifferentIntegers(string word) => System.Text.RegularExpressions.Regex
        .Matches(word, @"\d+")
        .Select(m => m.Value.TrimStart('0'))
        .Distinct()
        .Count();
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.NumDifferentIntegers("a123bc34d8ef34"), 3),
            ResultTester.CheckResult<int>(solution.NumDifferentIntegers("leet1234code234"), 2),
            ResultTester.CheckResult<int>(solution.NumDifferentIntegers("a1b01c001"), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Number of Different Integers in a String");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}