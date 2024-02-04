// Type of Triangle II


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.TypeofTriangleII
{
    public class Solution
    {
        public static string TriangleType(int[] nums)
        {
            Array.Sort(nums);
            if (nums[0] + nums[1] <= nums[2]) return "none";
            if (nums[0] == nums[1] && nums[1] == nums[2]) return "equilateral";
            if (nums[0] == nums[1] || nums[1] == nums[2]) return "isosceles";
            return "scalene";
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.TriangleType(new int[]{3,3,3}), "equilateral"),
                ResultTester.CheckResult<string>(Solution.TriangleType(new int[]{3,4,5}), "scalene"),
            };

            return results;
        }
    }
}