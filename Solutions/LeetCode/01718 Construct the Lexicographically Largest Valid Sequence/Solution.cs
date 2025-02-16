// Construct the Lexicographically Largest Valid Sequence
namespace CompetitiveProgramming.LeetCode.ConstructtheLexicographicallyLargestValidSequence;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] ConstructDistancedSequence(int n)
    {
        int len = 2 * n - 1;
        int[] result = new int[len];
        bool[] used = new bool[n + 1];
        Backtrack(result, used, 0, n);
        return result;
    }

    private bool Backtrack(int[] result, bool[] used, int index, int n)
    {
        if (index == result.Length) return true;
        if (result[index] != 0) return Backtrack(result, used, index + 1, n);

        for (int num = n; num >= 1; num--)
        {
            if (used[num]) continue;
            if (num == 1)
            {
                result[index] = 1;
                used[1] = true;
                if (Backtrack(result, used, index + 1, n)) return true;
                result[index] = 0;
                used[1] = false;
            }
            else
            {
                int secondIndex = index + num;
                if (secondIndex < result.Length && result[secondIndex] == 0)
                {
                    result[index] = result[secondIndex] = num;
                    used[num] = true;
                    if (Backtrack(result, used, index + 1, n)) return true;
                    result[index] = result[secondIndex] = 0;
                    used[num] = false;
                }
            }
        }
        return false;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int[]>(solution.ConstructDistancedSequence(3), new int[]{3,1,2,3,2}),
            ResultTester.CheckResult<int[]>(solution.ConstructDistancedSequence(5), new int[]{5,3,1,4,3,5,2,4,2})
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Construct the Lexicographically Largest Valid Sequence");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}