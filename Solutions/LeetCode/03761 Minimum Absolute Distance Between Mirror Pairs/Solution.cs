// Minimum Absolute Distance Between Mirror Pairs
namespace CompetitiveProgramming.LeetCode.MinimumAbsoluteDistanceBetweenMirrorPairs;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinMirrorPairDistance(int[] nums)
    {
        int minDistance = int.MaxValue;
        var lastPositions = new Dictionary<int, int>();

        for (int j = 0; j < nums.Length; j++)
        {
            int current = nums[j];

            if (lastPositions.ContainsKey(current))
            {
                minDistance = Math.Min(minDistance, j - lastPositions[current]);
            }

            int reversed = ReverseInt(current);
            if (!lastPositions.ContainsKey(reversed))
            {
                lastPositions[reversed] = j;
            }
            else
            {
                lastPositions[reversed] = j;
            }
        }

        return minDistance == int.MaxValue ? -1 : minDistance;
    }

    private int ReverseInt(int n)
    {
        int rev = 0;
        while (n > 0)
        {
            rev = rev * 10 + (n % 10);
            n /= 10;
        }
        return rev;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinMirrorPairDistance([12,21,45,33,54]), 1),
            ResultTester.CheckResult<int>(solution.MinMirrorPairDistance([120,21]), 1),
            ResultTester.CheckResult<int>(solution.MinMirrorPairDistance([21,120]), -1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Absolute Distance Between Mirror Pairs");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}