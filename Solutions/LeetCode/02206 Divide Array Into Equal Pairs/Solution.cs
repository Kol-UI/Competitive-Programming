// Divide Array Into Equal Pairs


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DivideArrayIntoEqualPairs
{
    public class Solution 
    {
        public static bool DivideArray(int[] nums) 
        {
            Dictionary<int,int> uniqCount = new Dictionary<int,int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                if (!uniqCount.ContainsKey(num)) { uniqCount.Add(num, 1); }
                else
                { 
                    int count = uniqCount[num];
                    uniqCount[num] = count + 1; 
                }
            }

            foreach(int n in uniqCount.Values)
            {
                if (n % 2 != 0) { return false; }
            }
            return true;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.DivideArray(new int[]{3,2,3,2,2,2}), true),
                ResultTester.CheckResult<bool>(Solution.DivideArray(new int[]{1,2,3,4}), false),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("2206");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}