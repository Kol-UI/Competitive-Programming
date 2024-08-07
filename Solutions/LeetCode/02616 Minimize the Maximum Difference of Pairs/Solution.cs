// Minimize the Maximum Difference of Pairs

/*
You are given a 0-indexed integer array nums and an integer p. Find p pairs of indices of nums such that the maximum difference amongst all the pairs is minimized. Also, ensure no index appears more than once amongst the p pairs.

Note that for a pair of elements at the index i and j, the difference of this pair is |nums[i] - nums[j]|, where |x| represents the absolute value of x.

Return the minimum maximum difference among all p pairs. We define the maximum of an empty set to be zero.

 

Example 1:

Input: nums = [10,1,2,7,1,3], p = 2
Output: 1
Explanation: The first pair is formed from the indices 1 and 4, and the second pair is formed from the indices 2 and 5. 
The maximum difference is max(|nums[1] - nums[4]|, |nums[2] - nums[5]|) = max(0, 1) = 1. Therefore, we return 1.


Example 2:

Input: nums = [4,2,1,2], p = 1
Output: 0
Explanation: Let the indices 1 and 3 form a pair. The difference of that pair is |2 - 2| = 0, which is the minimum we can attain.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimizetheMaximumDifferenceofPairs
{
    public class Solution
    {
        // Binary Search
        public static int MinimizeMax(int[] nums, int p)
        {
            Array.Sort(nums);
            int n = nums.Length;
            int left = 0;
            int right = nums[n-1] - nums[0];

            while(left < right)
            {
                int mid = (left + right) / 2, k = 0;

                for(int i = 1; i < n && k < p; i++)
                {
                    if(nums[i] - nums[i-1] <= mid)
                    {
                        k++;
                        i++;
                    }
                }

                if(k >= p)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }
    }

    public class Test
    {
        public static bool[] TestCase()
        {
            int[] nums1 = {10,1,2,7,1,3};
            int p1 = 2;
            int[] nums2 = {4,2,1,2};
            int p2 = 1;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinimizeMax(nums1, p1), 1),
                ResultTester.CheckResult<int>(Solution.MinimizeMax(nums2, p2), 0)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Minimize the Maximum Difference of Pairs");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCase());
        }
    }
}