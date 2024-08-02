// Next Greater Element I

/*
The next greater element of some element x in an array is the first greater element that is to the right of x in the same array.

You are given two distinct 0-indexed integer arrays nums1 and nums2, where nums1 is a subset of nums2.

For each 0 <= i < nums1.length, find the index j such that nums1[i] == nums2[j] and determine the next greater element of nums2[j] in nums2. If there is no next greater element, then the answer for this query is -1.

Return an array ans of length nums1.length such that ans[i] is the next greater element as described above.

 

Example 1:

Input: nums1 = [4,1,2], nums2 = [1,3,4,2]
Output: [-1,3,-1]
Explanation: The next greater element for each value of nums1 is as follows:
- 4 is underlined in nums2 = [1,3,4,2]. There is no next greater element, so the answer is -1.
- 1 is underlined in nums2 = [1,3,4,2]. The next greater element is 3.
- 2 is underlined in nums2 = [1,3,4,2]. There is no next greater element, so the answer is -1.

Example 2:

Input: nums1 = [2,4], nums2 = [1,2,3,4]
Output: [3,-1]
Explanation: The next greater element for each value of nums1 is as follows:
- 2 is underlined in nums2 = [1,2,3,4]. The next greater element is 3.
- 4 is underlined in nums2 = [1,2,3,4]. There is no next greater element, so the answer is -1.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NextGreaterElementI
{
    public class Solution
    {
        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            int[] ans = new int[nums1.Length];
            int o = 0;

            foreach (int num1 in nums1)
            {
                int greaterElement = -1;
                for(int i = 0; i < nums2.Length-1; i++)
                {
                    if (nums2[i] == num1)
                    {
                        while(++i < nums2.Length)
                        {
                            if(nums2[i] > num1)
                            {
                                greaterElement = nums2[i];
                                break;
                            }
                                
                        }
                    }
                        
                }
                ans[o++] = greaterElement;
            }
            return ans;
        }
    }

    public class Test
    {
        public static bool[] TestNextGreaterElementI()
        {
            int[] case1nums1 = {4,1,2};
            int[] case1nums2 = {1,3,4,2};
            int[] case2nums1 = {2,4};
            int[] case2nums2 = {1,2,3,4};

            int[] output1_496 = {-1,3,-1};
            int[] output2_496 = {3,-1};

            int[] result1 = Solution.NextGreaterElement(case1nums1, case1nums2);
            int[] result2 = Solution.NextGreaterElement(case2nums1, case2nums2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result1, output1_496),
                ResultTester.CheckResult<int[]>(result2, output2_496)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Next Greater Element I");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestNextGreaterElementI());
        }
    }
}