// Find the Distinct Difference Array


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.FindtheDistinctDifferenceArray
{
    public class Solution 
    {
        public static int[] DistinctDifferenceArray(int[] nums) 
        {
            int n = nums.Length;
            int[] result = new int[n];
            HashSet<int> distinctElements = new();

            distinctElements.Add(nums[n-1]);
            for (int i = n - 2; i >= 0; i--)
            {
                result[i] = -distinctElements.Count;
                distinctElements.Add(nums[i]);
            }

            distinctElements.Clear();

            for (int i = 0; i <= n - 1; i++)
            {
                distinctElements.Add(nums[i]);
                result[i] += distinctElements.Count;
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.DistinctDifferenceArray(new int[]{1,2,3,4,5}), new int[]{-3,-1,1,3,5}),
                ResultTester.CheckResult<int[]>(Solution.DistinctDifferenceArray(new int[]{3,2,3,4,2}), new int[]{-2,-1,0,2,3}),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2670");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}