// Second Largest Digit in a String
namespace CompetitiveProgramming.LeetCode.SecondLargestDigitinaString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int SecondHighest(string s)
    {
        return s
            .Distinct()
            .Where(Char.IsDigit)
            .Select(x => x - '0')
            .OrderDescending()
            .Skip(1)
            .FirstOrDefault(-1);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.SecondHighest("dfa12321afd"), 2),
            ResultTester.CheckResult<int>(solution.SecondHighest("abc1111"), -1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Second Largest Digit in a String");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}