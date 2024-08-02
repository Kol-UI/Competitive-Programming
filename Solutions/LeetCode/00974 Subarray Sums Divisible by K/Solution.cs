using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SubarraySumsDivisiblebyK
{
	public class Solution
	{
        //Given an integer array nums and an integer k, return the number of non-empty subarrays that have a sum divisible by k.

        //A subarray is a contiguous part of an array.

        //Example 1:

        //Input: nums = [4, 5, 0, -2, -3, 1], k = 5
        //Output: 7
        //Explanation: There are 7 subarrays with a sum divisible by k = 5:
        //[4, 5, 0, -2, -3, 1], [5], [5, 0], [5, 0, -2, -3], [0], [0, -2, -3], [-2, -3]

        //Example 2:

        //Input: nums = [5], k = 9
        //Output: 0

        public static int SubarraysDivByK(int[] nums, int k)
        {
            int prefixSum = 0, count = 0;
            Dictionary<int, int> myDictionary = new Dictionary<int, int>();
            myDictionary.Add(0, 1);
            foreach (int num in nums)
            {
                prefixSum += num;
                int rem = prefixSum % k;
                if (rem < 0)
                {
                    rem += k;
                }

                if (myDictionary.ContainsKey(rem))
                {
                    count += myDictionary[rem];
                    ++myDictionary[rem];
                }
                else
                {
                    myDictionary.Add(rem, 1);
                }
            }

            return count;
        }


    }

    public class Test
    {
        public static bool[] TestSubarraySumsDivisiblebyK()
        {
            int[] nums1 = new int[] {4, 5, 0, -2, -3, 1};
            int k1 = 5;
            int output1 = 7;

            int[] nums2 = new int[] {5};
            int k2 = 9;
            int output2 = 0;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.SubarraysDivByK(nums1, k1), output1),
                ResultTester.CheckResult<int>(Solution.SubarraysDivByK(nums2, k2), output2)
            };

            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Subarray Sums Divisible by K");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestSubarraySumsDivisiblebyK());
        }
    }
}