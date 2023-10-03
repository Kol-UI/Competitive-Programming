// Number of Good Pairs

/*
Given an array of integers nums, return the number of good pairs.

A pair (i, j) is called good if nums[i] == nums[j] and i < j.

 

Example 1:

Input: nums = [1,2,3,1,1,3]
Output: 4
Explanation: There are 4 good pairs (0,3), (0,4), (3,4), (2,5) 0-indexed.

Example 2:

Input: nums = [1,1,1,1]
Output: 6
Explanation: Each pair in the array are good.

Example 3:

Input: nums = [1,2,3]
Output: 0
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofGoodPairs
{
    public class Solution
    {
        public static int NumIdenticalPairsOne(int[] A)
        {
            int answer = 0;
            Dictionary<int, int> count = new Dictionary<int, int>();
            foreach (int x in A)
            {
                if (count.ContainsKey(x))
                    answer += count[x]++;
                else
                    count[x] = 1;
            }
            return answer;
        }

        public static int NumIdenticalPairsTwo(int[] nums)
        {
            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
                for (int j = i+1; j < nums.Length; j++)
                    if (nums[i] == nums[j])
                    {
                        counter++;
                        continue;
                    }

            return counter;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] case1 = {1,2,3,1,1,3};
            int[] case2 = {1,1,1,1};
            int[] case3 = {1,2,3};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.NumIdenticalPairsOne(case1), 4),
                ResultTester.CheckResult<int>(Solution.NumIdenticalPairsOne(case2), 6),
                ResultTester.CheckResult<int>(Solution.NumIdenticalPairsOne(case3), 0),
                ResultTester.CheckResult<int>(Solution.NumIdenticalPairsTwo(case1), 4),
                ResultTester.CheckResult<int>(Solution.NumIdenticalPairsTwo(case2), 6),
                ResultTester.CheckResult<int>(Solution.NumIdenticalPairsTwo(case3), 0),
            };

            return results;
        }
    }
}