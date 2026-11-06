// Count Values With Equally Spaced Occurrences I
namespace CompetitiveProgramming.LeetCode.CountValuesWithEquallySpacedOccurrencesI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountSpecialIntegers(int[] nums) => nums.Select((m, i) => (m, i)).GroupBy(m => m.m).Where(m => m.Count() == 3)
        .Count(m => m.ElementAtOrDefault(1).i - m.ElementAtOrDefault(0).i == m.ElementAtOrDefault(2).i - m.ElementAtOrDefault(1).i);
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.CountSpecialIntegers([1,8,1,5,1,5,8,5]), 2),
            ResultTester.CheckResult<int>(solution.CountSpecialIntegers([8,8,8,8]), 0),
            ResultTester.CheckResult<int>(solution.CountSpecialIntegers([8,6,6,8,8]), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Values With Equally Spaced Occurrences I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}