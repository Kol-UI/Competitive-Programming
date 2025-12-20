// Minimum Operations to Maximize Last Elements in Arrays
namespace CompetitiveProgramming.LeetCode.MinimumOperationstoMaximizeLastElementsinArrays;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinOperations(int[] first, int[] second)
    {
        int countNoSwap = 0;
        int lastFirst = first[first.Length - 1];
        int lastSecond = second[second.Length - 1];

        for (int i = 0; i < first.Length - 1; i++)
        {
            if (first[i] <= lastFirst && second[i] <= lastSecond)
            {
                continue;
            }
            if (first[i] <= lastSecond && second[i] <= lastFirst)
            {
                countNoSwap++;
                continue;
            }
            return -1;
        }

        int countWithSwap = 1;
        for (int i = 0; i < first.Length - 1; i++)
        {
            if (first[i] <= lastSecond && second[i] <= lastFirst)
            {
                continue;
            }
            if (first[i] <= lastFirst && second[i] <= lastSecond)
            {
                countWithSwap++;
                continue;
            }
            return -1;
        }

        return Math.Min(countNoSwap, countWithSwap);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MinOperations([1,2,7], [4,5,3]), 1),
            ResultTester.CheckResult<int>(solution.MinOperations([2,3,4,5,9], [8,8,4,4,4]), 2),
            ResultTester.CheckResult<int>(solution.MinOperations([1,5,4], [2,5,3]), -1),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Operations to Maximize Last Elements in Arrays");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}