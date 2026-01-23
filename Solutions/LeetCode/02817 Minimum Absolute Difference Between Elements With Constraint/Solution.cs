// Minimum Absolute Difference Between Elements With Constraint
namespace CompetitiveProgramming.LeetCode.MinimumAbsoluteDifferenceBetweenElementsWithConstraint;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinAbsoluteDifference(IList<int> nums, int x)
    {
        var result = int.MaxValue;
        var values = new SortedSet<int>();
        values.UnionWith([int.MinValue, int.MaxValue]);

        for (var i = x; i < nums.Count; i++)
        {
            values.Add(nums[i - x]);

            if (values.Contains(nums[i]))
                return 0;

            long lower = values.GetViewBetween(int.MinValue, nums[i] - 1).Max;
            long upper = values.GetViewBetween(nums[i] + 1, int.MaxValue).Min;
            result = (int)Math.Min(result, nums[i] - lower);
            result = (int)Math.Min(result, upper - nums[i]);
        }

        return result;
    }
}

public class Solution2
{
    public int MinAbsoluteDifference(IList<int> nums, int x)
    {
        var result = int.MaxValue;
        var values = new List<int>(nums.Count);

        for (var i = x; i < nums.Count && result != 0; i++)
        {
            var pos = values.BinarySearch(nums[i - x]);
            if (pos < 0)
                values.Insert(~pos, nums[i - x]);

            var idx = values.BinarySearch(nums[i]);
            var j = Math.Abs(idx + 1);

            if (j < values.Count)
            {
                var diff = Math.Abs(nums[i] - values[j]);
                result = Math.Min(result, diff);
            }

            if (j > 0)
            {
                var diff = Math.Abs(nums[i] - values[j - 1]);
                result = Math.Min(result, diff);
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
        Solution2 solution2 = new();
        IList<int> list1 = new List<int> { 4, 3, 2, 4 };
        IList<int> list2 = new List<int> { 5, 3, 2, 10, 15 };
        IList<int> list3 = new List<int> { 1, 2, 3, 4 };
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinAbsoluteDifference(list1, 2), 0),
            ResultTester.CheckResult<int>(solution.MinAbsoluteDifference(list2, 1), 1),
            ResultTester.CheckResult<int>(solution.MinAbsoluteDifference(list3, 3), 3),
            ResultTester.CheckResult<int>(solution2.MinAbsoluteDifference(list1, 2), 0),
            ResultTester.CheckResult<int>(solution2.MinAbsoluteDifference(list2, 1), 1),
            ResultTester.CheckResult<int>(solution2.MinAbsoluteDifference(list3, 3), 3),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Absolute Difference Between Elements With Constraint");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}