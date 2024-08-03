// Delete and Earn

/*
You are given an integer array nums. You want to maximize the number of points you get by performing the following operation any number of times:

Pick any nums[i] and delete it to earn nums[i] points. Afterwards, you must delete every element equal to nums[i] - 1 and every element equal to nums[i] + 1.
Return the maximum number of points you can earn by applying the above operation some number of times.

 

Example 1:

Input: nums = [3,4,2]
Output: 6
Explanation: You can perform the following operations:
- Delete 4 to earn 4 points. Consequently, 3 is also deleted. nums = [2].
- Delete 2 to earn 2 points. nums = [].
You earn a total of 6 points.

Example 2:

Input: nums = [2,2,3,3,3,4]
Output: 9
Explanation: You can perform the following operations:
- Delete a 3 to earn 3 points. All 2's and 4's are also deleted. nums = [3,3].
- Delete a 3 again to earn 3 points. nums = [3].
- Delete a 3 once more to earn 3 points. nums = [].
You earn a total of 9 points.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DeleteandEarn
{
    public class Solution
    {
        public static int DeleteAndEarn(int[] nums)
        {
            
            int maxNumber = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach(int num in nums)
            {
                if(dict.ContainsKey(num)) dict[num] += num;
                else
                {
                    dict.Add(num, num);
                    maxNumber = Math.Max(maxNumber, num);
                }
            }
            
            int twoBack = 0; 
            int oneBack = dict.ContainsKey(1) ? dict[1] : 0;
            int temp = 0;

            for(int i = 2; i <= maxNumber; i++)
            {
                temp = oneBack;
                oneBack = Math.Max(oneBack, twoBack + (dict.ContainsKey(i) ? dict[i] : 0));
                twoBack = temp;
            }
            
            return oneBack;
        }
    }

    public class Test
    {
        public static bool[] TestDeleteandEarn()
        {
            int[] nums1 = {3,4,2};
            int[] nums2 = {2,2,3,3,3,4};

            int result1 = Solution.DeleteAndEarn(nums1);
            int result2 = Solution.DeleteAndEarn(nums2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 6),
                ResultTester.CheckResult<int>(result2, 9)
            };

            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Delete and Earn");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestDeleteandEarn());
        }
    }
}