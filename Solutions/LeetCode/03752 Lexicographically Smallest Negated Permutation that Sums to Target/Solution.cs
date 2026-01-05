// Lexicographically Smallest Negated Permutation that Sums to Target
namespace CompetitiveProgramming.LeetCode.LexicographicallySmallestNegatedPermutationthatSumstoTarget;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] LexSmallestNegatedPerm(int n, long target)
    {
        long maxSum = (n + 1) * (long)n / 2;
        long remaining = maxSum - target;
        if (maxSum < target) return new int[0];
        if (remaining % 2 == 1) return new int[0];
        remaining /= 2;
        var negated = new HashSet<int>();
        var result = new List<int>();
        for (int i = n; i >= 1; i--)
        {
            if (remaining - i >= 0)
            {
                negated.Add(i);
                result.Add(-i);
                remaining -= i;
            }
            if (remaining == 0) break;
        }
        if (remaining != 0) return new int[0];
        for (int i = 1; i <= n; i++)
        {
            if (!negated.Contains(i))
            {
                result.Add(i);
            }
        }
        return result.ToArray();
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int[]>(solution.LexSmallestNegatedPerm(3, 0), [-3,1,2]),
            ResultTester.CheckResult<int[]>(solution.LexSmallestNegatedPerm(1, 10000000000), []),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Lexicographically Smallest Negated Permutation that Sums to Target");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}