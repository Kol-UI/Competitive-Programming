// Maximum Unique Subarray Sum After Deletion
namespace CompetitiveProgramming.LeetCode.MaximumUniqueSubarraySumAfterDeletion;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxSum(int[] nums)
    {
        int maxVal = int.MinValue;
        foreach (var num in nums)
            if (num > maxVal) maxVal = num;

        if (maxVal < 0) return maxVal;

        var set = new HashSet<int>();
        foreach (var num in nums)
            if (num >= 0) set.Add(num);

        int sum = 0;
        foreach (var num in set)
            sum += num;

        return sum;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Unique Subarray Sum After Deletion");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}