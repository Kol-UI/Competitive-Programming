// Maximum Difference Between Increasing Elements

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumDifferenceBetweenIncreasingElements
{
    public class Solution
    {
        public static int MaximumDifference(int[] nums)
        {
            var max = int.MinValue;
            var min = int.MaxValue;
            
            for (int i = 0; i < nums.Length; i++)
            {
                min = Math.Min(nums[i], min); 
                max = Math.Max(max, nums[i] - min);
            }
            return max > 0? max : -1;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MaximumDifference(new int[]{7,1,5,4}), 4),
                ResultTester.CheckResult<int>(Solution.MaximumDifference(new int[]{9,4,3,2}), -1),
                ResultTester.CheckResult<int>(Solution.MaximumDifference(new int[]{1,5,2,10}), 9),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Difference Between Increasing Elements");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}