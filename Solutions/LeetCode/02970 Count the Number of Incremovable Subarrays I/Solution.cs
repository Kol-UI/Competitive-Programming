// Count the Number of Incremovable Subarrays I



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.CounttheNumberofIncremovableSubarraysI
{
    public class Solution
    {
        public static int IncremovableSubarrayCount(int[] nums)
        {
            var result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (Check(i, j, nums)) result++;
                }
            }
            return result;
        }
        
        private static bool Check(int index0, int index1, int[] nums)
        {
            for (int i = 0; i < index0 - 1; i++)
            {
                if (nums[i] >= nums[i + 1]) return false;
            }

            if (0 <= index0 - 1 && index1 + 1 < nums.Length && nums[index0 - 1] >= nums[index1 + 1])
            {
                return false;
            }

            for (int i = index1 + 1; i < nums.Length - 1; i++)
            {
                if (nums[i] >= nums[i + 1]) return false;
            }

            return true;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.IncremovableSubarrayCount(new int[] {1,2,3,4}), 10),
                ResultTester.CheckResult<int>(Solution.IncremovableSubarrayCount(new int[] {6,5,7,8}), 7),
                ResultTester.CheckResult<int>(Solution.IncremovableSubarrayCount(new int[] {8,7,6,6}), 3),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2970");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}