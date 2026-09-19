// Limit Occurrences in Sorted Array
namespace CompetitiveProgramming.LeetCode.LimitOccurrencesinSortedArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] LimitOccurrences(int[] nums, int k) => nums
        .GroupBy(m => m)
        .Select(m => Enumerable.Repeat(m.Key, m.Count() > k ? k : m.Count()))
        .SelectMany( m=> m)
        .ToArray();
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[]>(solution.LimitOccurrences([1,1,1,2,2,3], 2), [1,1,2,2,3]),
            ResultTester.CheckResult<int[]>(solution.LimitOccurrences([1,2,3], 1), [1,2,3]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Limit Occurrences in Sorted Array");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}