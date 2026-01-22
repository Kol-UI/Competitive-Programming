// Minimum Pair Removal to Sort Array I
namespace CompetitiveProgramming.LeetCode.MinimumPairRemovaltoSortArrayI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinimumPairRemoval(int[] nums)
    {
        var next = new int?[nums.Length];
        for (var i = 0; i < nums.Length - 1; i++) next[i] = i + 1;

        var count = 0;

        while (nums.Length - count > 1)
        {
            int? curr = 0;
            var target = 0;
            var targetAdjSum = nums[target] + nums[next[target]!.Value];
            var isAscending = true;

            while (curr is not null && next[curr.Value] is not null)
            {
                var nextVal = next[curr.Value]!.Value;

                if (nums[curr.Value] > nums[nextVal])
                {
                    isAscending = false;
                }

                var currAdjSum = nums[curr.Value] + nums[nextVal];
                if (currAdjSum < targetAdjSum)
                {
                    target = curr.Value;
                    targetAdjSum = currAdjSum;
                }

                curr = next[curr.Value];
            }

            if (isAscending) break;

            count++;
            next[target] = next[next[target]!.Value];
            nums[target] = targetAdjSum;
        }

        return count;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinimumPairRemoval([5,2,3,1]), 2),
            ResultTester.CheckResult<int>(solution.MinimumPairRemoval([1,2,2]), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Pair Removal to Sort Array I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}