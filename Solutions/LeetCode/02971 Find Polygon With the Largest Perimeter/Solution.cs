// Find Polygon With the Largest Perimeter


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindPolygonWiththeLargestPerimeter
{
    public class Solution
    {
        public static long LargestPerimeter(int[] nums)
        {
            Array.Sort(nums);
            int n = nums.Length;
            long[] prefix = new long[n];
            prefix[0] = nums[0];

            for(int i = 1; i < n; i++)
            {
                prefix[i] = prefix[i - 1] + nums[i];
            }
            
            for(int i = n - 1; i > 1; i--)
            {
                if(nums[i] < prefix[i - 1])
                    return prefix[i];
            }
            return -1;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(Solution.LargestPerimeter(new int[] {5,5,5}), 15),
                ResultTester.CheckResult<long>(Solution.LargestPerimeter(new int[] {1,12,1,2,5,50,3}), 12),
                ResultTester.CheckResult<long>(Solution.LargestPerimeter(new int[] {5,5,50}), -1),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Find Polygon With the Largest Perimeter");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}