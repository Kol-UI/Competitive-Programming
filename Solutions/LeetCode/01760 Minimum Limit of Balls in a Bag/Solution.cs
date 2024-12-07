// Minimum Limit of Balls in a Bag

/*
You are given an integer array nums where the ith bag contains nums[i] balls. You are also given an integer maxOperations.

You can perform the following operation at most maxOperations times:

Take any bag of balls and divide it into two new bags with a positive number of balls.
For example, a bag of 5 balls can become two new bags of 1 and 4 balls, or two new bags of 2 and 3 balls.
Your penalty is the maximum number of balls in a bag. You want to minimize your penalty after the operations.

Return the minimum possible penalty after performing the operations.

 

Example 1:

Input: nums = [9], maxOperations = 2
Output: 3
Explanation: 
- Divide the bag with 9 balls into two bags of sizes 6 and 3. [9] -> [6,3].
- Divide the bag with 6 balls into two bags of sizes 3 and 3. [6,3] -> [3,3,3].
The bag with the most number of balls has 3 balls, so your penalty is 3 and you should return 3.


Example 2:

Input: nums = [2,4,8,2], maxOperations = 4
Output: 2
Explanation:
- Divide the bag with 8 balls into two bags of sizes 4 and 4. [2,4,8,2] -> [2,4,4,4,2].
- Divide the bag with 4 balls into two bags of sizes 2 and 2. [2,4,4,4,2] -> [2,2,2,4,4,2].
- Divide the bag with 4 balls into two bags of sizes 2 and 2. [2,2,2,4,4,2] -> [2,2,2,2,2,4,2].
- Divide the bag with 4 balls into two bags of sizes 2 and 2. [2,2,2,2,2,4,2] -> [2,2,2,2,2,2,2,2].
The bag with the most number of balls has 2 balls, so your penalty is 2, and you should return 2.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumLimitofBallsinaBag
{
    public class Solution
    {
        public static int MinimumSize(int[] nums, int maxOperations)
        {
            int l = 1;
            int r = 1000000000;
            while (l < r)
            {
                int m = l + (r - l) / 2, numOps = 0;
                foreach (int num in nums) numOps += (num - 1) / m;

                if (numOps > maxOperations)
                {
                    l = m + 1;
                }
                else
                {
                    r = m;
                }
            }
            return l;
        }
    }

    public class Solution2
    {
        public int MinimumSize(int[] nums, int maxOperations)
        {
            int left = 1;
            int right = 1000000000;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                int numOps = 0;

                foreach (int num in nums)
                {
                    numOps += (num - 1) / mid;
                }

                if (numOps > maxOperations)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return left;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1 = {9};
            int maxOperations1 = 2;
            int[] nums2 = {2,4,8,2};
            int maxOperations2 = 4;

            int result1 = Solution.MinimumSize(nums1, maxOperations1);
            int result2 = Solution.MinimumSize(nums2, maxOperations2);

            Solution2 sol = new();

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 3),
                ResultTester.CheckResult<int>(result2, 2),
                ResultTester.CheckResult<int>(sol.MinimumSize(nums1, maxOperations1), 3),
                ResultTester.CheckResult<int>(sol.MinimumSize(nums2, maxOperations2), 2)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Minimum limit of Balls in a Bag");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}