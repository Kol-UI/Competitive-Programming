using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumSumCircularSubarray
{
    public class Solution
    {
        //Given a circular integer array nums of length n, return the maximum possible sum of a non-empty subarray of nums.
        //A circular array means the end of the array connects to the beginning of the array.Formally, the next element of nums[i] is nums[(i + 1) % n] and the previous element of nums[i] is nums[(i - 1 + n) % n].

        //A subarray may only include each element of the fixed buffer nums at most once.Formally, for a subarray nums[i], nums[i + 1], ..., nums[j], there does not exist i <= k1, k2 <= j with k1 % n == k2 % n.
        //Example 1:
        //Input: nums = [1, -2, 3, -2]
        //Output: 3
        //Explanation: Subarray[3] has maximum sum 3.

        //Example 2:
        //Input: nums = [5, -3, 5]
        //Output: 10
        //Explanation: Subarray[5, 5] has maximum sum 5 + 5 = 10.

        //Example 3:
        //Input: nums = [-3, -2, -3]
        //Output: -2
        //Explanation: Subarray[-2] has maximum sum - 2.

        public static int MaxSubarraySumCircular(int[] nums)
        {
            // Using Kadane’s Algorithm
            int size = nums.Length;
            int max_sum = Int32.MinValue;
            int result = 0;
            int tempo = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                tempo += nums[i];
                if (max_sum < tempo)
                {
                    max_sum = tempo;
                }
                if (tempo < 0)
                {
                    tempo = 0;
                }
                result += nums[i];
            }

            int tempo2 = 0;
            tempo = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                max_sum = Math.Max(result + tempo2, max_sum);
                result -= nums[j];
                tempo += nums[j];
                tempo2 = Math.Max(tempo2, tempo);
            }

            return max_sum;

            /*
            for (int i = 0; i < size; i++)
            {
                tempo = tempo + nums[i];

                if (result < tempo)
                    result = tempo;

                if (tempo < 0)
                    tempo = 0;
            }

            return result;
            */


            /*
            foreach (int value in nums)
            {
                if(value > 0)
                {
                    result += value;
                }
            }
            return result;
            */
        }
    }

    public class Test
    {
        public static bool[] TestMaximumSumCircularSubarray()
        {
            // Case 1
            int[] numsCase1_918 = { 1, -2, 3, -2 };
            int Case1_918_Result = Solution.MaxSubarraySumCircular(numsCase1_918);

            // Case 2
            int[] numsCase2_918 = { 5, -3, 5 };
            int Case2_918_Result = Solution.MaxSubarraySumCircular(numsCase2_918);

            // Case 3
            int[] numsCase3_918 = { -3, -2, -3 };
            int Case3_918_Result = Solution.MaxSubarraySumCircular(numsCase3_918);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_918_Result, 3),
                ResultTester.CheckResult<int>(Case2_918_Result, 10),
                ResultTester.CheckResult<int>(Case3_918_Result, -2)
            };

            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Maximum Sum Circular Subarray");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestMaximumSumCircularSubarray());
        }
    }
}