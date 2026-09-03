// Removing Minimum and Maximum From Array
namespace CompetitiveProgramming.LeetCode.RemovingMinimumandMaximumFromArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinimumDeletions(int[] nums)
    {
        var min = nums[0];
        var minIndex = 0;
        var max = nums[0];
        var maxIndex = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            var num = nums[i];

            if (num < min)
            {
                min = num;
                minIndex = i;
            }

            if (num > max)
            {
                max = num;
                maxIndex = i;
            }
        }

        if (maxIndex < minIndex)
        {
            (maxIndex, minIndex) = (minIndex, maxIndex);
        }

        var aroundRemoving = minIndex + (nums.Length - maxIndex) + 1;
        var leftRemoving = maxIndex + 1;
        var rightRemoving = nums.Length - minIndex;

        return Math.Min(aroundRemoving, Math.Min(leftRemoving, rightRemoving));
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinimumDeletions([2,10,7,5,4,1,8,6]), 5),
            ResultTester.CheckResult<int>(solution.MinimumDeletions([0,-4,19,1,8,-2,-3,5]), 3),
            ResultTester.CheckResult<int>(solution.MinimumDeletions([101]), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Removing Minimum and Maximum From Array");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}