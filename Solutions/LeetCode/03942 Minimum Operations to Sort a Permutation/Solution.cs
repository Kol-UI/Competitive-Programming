// Minimum Operations to Sort a Permutation
namespace CompetitiveProgramming.LeetCode.MinimumOperationstoSortaPermutation;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinOperations(int[] nums)
    {
        int n = nums.Length;
        if (n == 1)
        {
            return 0;
        }

        int start = Array.IndexOf(nums, 0);

        bool asc = true;
        bool desc = true;

        for (int i = 1; i < n; i++)
        {
            int value = nums[(start + i) % n];

            if (value != i)
            {
                asc = false;
            }
            if (value != n - i)
            {
                desc = false;
            }

            if (!asc && !desc)
            {
                return -1;
            }
        }

        if (asc)
        {
            return Math.Min(start, n - start + 2);
        }

        return Math.Min(n - start, start + 2);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinOperations([0,2,1]), 2),
            ResultTester.CheckResult<int>(solution.MinOperations([1,0,2]), 2),            
            ResultTester.CheckResult<int>(solution.MinOperations([2,0,1,3]), -1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Operations to Sort a Permutation");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}