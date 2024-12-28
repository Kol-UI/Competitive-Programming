// Maximum Sum of 3 Non-Overlapping Subarrays

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumSumof3NonOverlappingSubarrays
{
    public class Solution
    {
        public int[] MaxSumOfThreeSubarrays(int[] nums, int k)
        {
            int a = 0; 
            int[] result = new int[3];

            for (int i = 1; i < nums.Length; i++)
            {
            nums[i] += nums[i-1];
            }

            for (int i = k; i <= nums.Length - 2 * k; i++)
            {
                int mleft = 0;
                int left = 0;
                int mright = 0;
                int right = i + k;

                mleft = Math.Max(mleft, nums[k - 1]);
                left = 0;

                for(int j = 0; j + k < i; j++)
                {
                    if(mleft < nums[j + k] - nums[j])
                    {
                        mleft = nums[j + k] - nums[j]; left = j + 1; 
                    }
                }

                for(int j = i + k; j <= nums.Length - k; j++)
                {
                    if(mright < nums[j + k - 1] - nums[j - 1])
                    {
                        mright = nums[j + k - 1] - nums[j - 1]; right = j;
                    }
                }

                if (nums[ i + k - 1] - nums[i - 1] + mright + mleft > a)
                {
                    a = nums[i + k - 1] - nums[i - 1] + mright + mleft;

                    result = new int[]
                    {
                        left, i, right
                    };
                }
        }

        return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(solution.MaxSumOfThreeSubarrays(new int[]{1,2,1,2,6,7,5,1}, 2), new int[]{0,3,5}),
                ResultTester.CheckResult<int[]>(solution.MaxSumOfThreeSubarrays(new int[]{1,2,1,2,1,2,1,2,1}, 2), new int[]{0,2,4}),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Sum of 3 Non-Overlapping Subarrays");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}