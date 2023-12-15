using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SubarraySumEqualsK
{
	public class Solution
	{
        //Given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k.
        //A subarray is a contiguous non-empty sequence of elements within an array.

        //Example 1:

        //Input: nums = [1,1,1], k = 2
        //Output: 2

        //Example 2:

        //Input: nums = [1,2,3], k = 3
        //Output: 2

        public static int SubarraySum(int[] nums, int k)
        {
            int count = 0;
            int sum = 0;
            Dictionary<int, int> myDictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum == k)
                {
                    count++;
                }
                if (myDictionary.Count != 0 && myDictionary.ContainsKey(sum - k))
                {
                    count += myDictionary[sum - k];
                }

                if (!myDictionary.ContainsKey(sum))
                {
                    myDictionary.Add(sum, 1);
                }
                else
                {
                    myDictionary[sum]++;
                }
            }

            return count;
        }

    }

    public class Test
    {
        public static bool[] TestSubarraySumEqualsK()
        {
            // Case 1
            int[] numsCase1_560 = { 1, 1, 1 };
            int kCase1 = 2;
            int Case1_560_Result = Solution.SubarraySum(numsCase1_560, kCase1);

            // Case 2
            int[] numsCase2_560 = { 1, 2, 3 };
            int kCase2 = 3;
            int Case2_560_Result = Solution.SubarraySum(numsCase2_560, kCase2);
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_560_Result, 2),
                ResultTester.CheckResult<int>(Case2_560_Result, 2)
            };
            return results;
        }
    }
}

