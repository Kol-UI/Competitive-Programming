// Maximum Frequency After Subarray Operation
namespace CompetitiveProgramming.LeetCode.MaximumFrequencyAfterSubarrayOperation;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxFrequency(int[] numbers, int target)
    {
        int result = 0;
        int baseCount = 0;
        HashSet<int> distinct = new HashSet<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target) baseCount++;
            distinct.Add(numbers[i]);
        }

        foreach (int value in distinct)
        {
            int current = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target) current--;
                if (numbers[i] == value) current++;
                if (current < 0) current = 0;
                result = Math.Max(result, current + baseCount);
            }
        }

        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MaxFrequency([1,2,3,4,5,6], 1), 2),
            ResultTester.CheckResult<int>(solution.MaxFrequency([10,2,3,4,5,5,4,3,2,2], 10), 4),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Frequency After Subarray Operation");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}