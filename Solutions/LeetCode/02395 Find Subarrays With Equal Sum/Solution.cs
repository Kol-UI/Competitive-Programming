// Find Subarrays With Equal Sum



using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindSubarraysWithEqualSum
{
    public class Solution
    {
        public static bool FindSubarrays(int[] nums)
            => Enumerable
                .Range(0, nums.Length - 1)
                .GroupBy(i => nums[i..(i+2)].Sum())
                .Any(g => g.Count() >= 2);
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Subarrays With Equal Sum");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}