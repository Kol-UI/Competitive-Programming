// Binary Subarrays With Sum


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BinarySubarraysWithSum
{
    public class Solution
    {
        public static int NumSubarraysWithSum(int[] nums, int goal)
        {
            int Helper(int num)
            {
                if(num < 0)
                {
                    return 0;
                }

                int l = 0, currSum = 0, res = 0;

                for(int r = 0; r < nums.Length; r++)
                {
                    currSum += nums[r];
                    while(currSum > num)
                    {
                        currSum -= nums[l];
                        l++;
                    }
                    res += (r-l+1);
                }
                return res;
            }

            return Helper(goal) - Helper(goal - 1);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.NumSubarraysWithSum(new int[]{1,0,1,0,1}, 2), 4),
                ResultTester.CheckResult<int>(Solution.NumSubarraysWithSum(new int[]{0,0,0,0,0}, 0), 15),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Subarrays With Sum");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}