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

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Find Target Indices After Sorting Array");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}