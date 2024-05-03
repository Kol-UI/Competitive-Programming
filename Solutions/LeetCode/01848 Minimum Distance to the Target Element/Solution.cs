// Minimum Distance to the Target Element

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumDistancetotheTargetElement
{
    public class Solution
    {
        public static int GetMinDistance(int[] nums, int target, int start) =>
            Enumerable.Range(0, nums.Length).First(i =>
                nums.ElementAtOrDefault(start + i) == target ||
                nums.ElementAtOrDefault(start - i) == target);
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.GetMinDistance(new int[]{1,2,3,4,5}, 5, 3), 1),
                ResultTester.CheckResult<int>(Solution.GetMinDistance(new int[]{1}, 1, 0), 0),
                ResultTester.CheckResult<int>(Solution.GetMinDistance(new int[]{1,1,1,1,1,1,1,1,1,1}, 1, 0), 0),
            };
            return results;
        }
    }
}