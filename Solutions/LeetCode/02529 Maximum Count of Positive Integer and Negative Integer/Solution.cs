// Maximum Count of Positive Integer and Negative Integer


using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MaximumCountofPositiveIntegerandNegativeInteger
{
    public class Solution 
    {
        public static int MaximumCount(int[] nums)
        {
            return Math.Max(nums.Count(n => n < 0), nums.Count(n => n > 0));
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MaximumCount(new int[]{-2,-1,-1,1,2,3}), 3),
                ResultTester.CheckResult<int>(Solution.MaximumCount(new int[]{-3,-2,-1,0,0,1,2}), 3),
                ResultTester.CheckResult<int>(Solution.MaximumCount(new int[]{5,20,66,1314}), 4),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2529");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}