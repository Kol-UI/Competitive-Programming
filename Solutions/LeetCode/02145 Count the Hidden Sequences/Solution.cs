// Count the Hidden Sequences
namespace CompetitiveProgramming.LeetCode.CounttheHiddenSequences;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int NumberOfArrays(int[] differences, int lower, int upper)
    {
        var (min, max) = GetMinMax(differences);
        var result = (int)((upper - lower) - (max - min) + 1);
        if (result < 0) result = 0;
        return result;
    }

    private (long min, long max) GetMinMax(int[] differences)
    {
        var min = 0L;
        var max = 0L;
        var curr = 0L;
        for (int i = 0; i < differences.Length; i++)
        {
            curr += differences[i];
            min = Math.Min(min, curr);
            max = Math.Max(max, curr);
        }
        return (min, max);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.NumberOfArrays(new int[]{1,-3,4}, 1, 6), 2),
            ResultTester.CheckResult<int>(solution.NumberOfArrays(new int[]{3,-4,5,1,-2}, -4, 5), 4),
            ResultTester.CheckResult<int>(solution.NumberOfArrays(new int[]{4,-7,2}, 3, 6), 0),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count the Hidden Sequences");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}