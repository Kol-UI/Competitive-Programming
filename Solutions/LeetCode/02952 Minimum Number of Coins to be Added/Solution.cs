// Minimum Number of Coins to be Added
namespace CompetitiveProgramming.LeetCode.MinimumNumberofCoinstobeAdded;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinimumAddedCoins(int[] values, int goal)
    {
        Array.Sort(values);
        int index = 0;
        int missing = 0;
        int sum = 0;

        for (int current = 1; current <= goal; current++)
        {
            if (sum < current)
            {
                while (index < values.Length && values[index] <= current)
                {
                    sum += values[index];
                    index++;
                }
                if (sum < current)
                {
                    missing++;
                    sum += current;
                }
            }
        }

        return missing;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MinimumAddedCoins([1,4,10], 19), 2),
            ResultTester.CheckResult<int>(solution.MinimumAddedCoins([1,4,10,5,7,19], 19), 1),
            ResultTester.CheckResult<int>(solution.MinimumAddedCoins([1,1,1], 20), 3),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Number of Coins to be Added");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}