// Longest Alternating Subarray


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.LongestAlternatingSubarray
{
    public class Solution
    {
        public static int AlternatingSubarray(int[] nums)
        {
            int result = -1;

            for(int i = 1; i < nums.Length;)
            {
                if(nums[i-1] + 1 != nums[i++])
                {
                    continue;
                }

                result = Math.Max(result, 2);

                for(int j = 3; i < nums.Length && nums[i-2]== nums[i]; i++, j++)
                {
                    result = Math.Max(result,j);
                }
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
                ResultTester.CheckResult<int>(Solution.AlternatingSubarray(new int[]{2,3,4,3,4}), 4),
                ResultTester.CheckResult<int>(Solution.AlternatingSubarray(new int[]{4,5,6}), 2),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2765");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}