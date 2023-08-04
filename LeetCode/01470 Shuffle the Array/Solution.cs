using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ShuffletheArray
{
    public class Solution
	{
        // Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
        // Return the array in the form [x1,y1,x2,y2,...,xn,yn].

        // Example 1:
        // Input: nums = [2,5,1,3,4,7], n = 3
        // Output: [2,3,5,4,1,7] 
        // Explanation: Since x1=2, x2=5, x3=1, y1=3, y2=4, y3=7 then the answer is [2,3,5,4,1,7].
        
        // Example 2:
        // Input: nums = [1,2,3,4,4,3,2,1], n = 4
        // Output: [1,4,2,3,3,2,4,1]

        // Example 3:
        // Input: nums = [1,1,2,2], n = 2
        // Output: [1,2,1,2]
        public static int[] Shuffle(int[] nums, int n)
        {
            IEnumerable<int> res = new List<int>();

            for(int i = 0; i < n;i++)
            {
                res = res.Append(nums[i]);
                res = res.Append(nums[i + n]);
            }

            return res.ToArray();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Case 1
            int[] arrayCase1_1470 = { 2, 5, 1, 3, 4, 7 };
            int nCase1_1470 = 3;
            int[] Case1_1470_Result = Solution.Shuffle(arrayCase1_1470, nCase1_1470);

            // Case 2
            int[] arrayCase2_1470 = { 1, 2, 3, 4, 4, 3, 2, 1 };
            int nCase2_1470 = 4;
            int[] Case2_1470_Result = Solution.Shuffle(arrayCase2_1470, nCase2_1470);
            
            // Case 3
            int[] arrayCase3_1470 = { 1, 1, 2, 2 };
            int nCase3_1470 = 2;
            int[] Case3_1470_Result = Solution.Shuffle(arrayCase3_1470, nCase3_1470);

            int[] expected1 = {2,3,5,4,1,7};
            int[] expected2 = {1,4,2,3,3,2,4,1};
            int[] expected3 = {1,2,1,2};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Case1_1470_Result, expected1),
                ResultTester.CheckResult<int[]>(Case2_1470_Result, expected2),
                ResultTester.CheckResult<int[]>(Case3_1470_Result, expected3)
            };
            return results;
        }
    }
}