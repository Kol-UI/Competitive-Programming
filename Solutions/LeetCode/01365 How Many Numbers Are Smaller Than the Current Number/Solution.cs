// How Many Numbers Are Smaller Than the Current Number

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.HowManyNumbersAreSmallerThantheCurrentNumber
{
    public class Solution
    {
        public static int[] SmallerNumbersThanCurrent(int[] nums) 
        {
            int[] smallerCounts = new int[nums.Length];
            
            for(int i = 0; i < nums.Length; i++)
            { 
                int count = 0;
                for(int j = 0; j < nums.Length; j++)
                { 
                    if(nums[i] > nums[j])
                    { 
                        count++;
                    }
                }
                smallerCounts[i] = count;
            }
            
            return smallerCounts;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.SmallerNumbersThanCurrent(new int[]{8,1,2,2,3}), new int[]{4,0,1,1,3}),
                ResultTester.CheckResult<int[]>(Solution.SmallerNumbersThanCurrent(new int[]{6,5,4,8}), new int[]{2,1,0,3}),
                ResultTester.CheckResult<int[]>(Solution.SmallerNumbersThanCurrent(new int[]{7,7,7,7}), new int[]{0,0,0,0}),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("How Many Numbers Are Smaller Than the Current Number");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}