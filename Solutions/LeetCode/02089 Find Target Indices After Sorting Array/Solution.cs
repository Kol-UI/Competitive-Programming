// Find Target Indices After Sorting Array

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindTargetIndicesAfterSortingArray
{
    public class Solution
    {
        public static IList<int> TargetIndices(int[] nums, int target) =>
            Enumerable.Range(
                nums.Count(num => num < target),
                nums.Count(num => num == target))
            .ToList();
    }
}