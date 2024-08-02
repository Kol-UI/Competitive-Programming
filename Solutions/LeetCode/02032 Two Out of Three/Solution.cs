// Two Out of Three


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.TwoOutofThree
{
    public class Solution
    {
        public static IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
        {
            Dictionary<int, int> numCount = new Dictionary<int, int>();
            List<int> res = new List<int>();

            CheckArray(nums1, numCount);
            CheckArray(nums2, numCount);
            CheckArray(nums3, numCount);
        
            foreach(var i in numCount)
            {
                if(i.Value >= 2) res.Add(i.Key);
            }

            return res;
        }

        public static void CheckArray(int[] nums, Dictionary<int, int> numCount)
        {
            HashSet<int> numSet = new HashSet<int>();
            foreach(int i in nums)
            {
                if(!numCount.ContainsKey(i))
                {
                    numCount.Add(i, 1);
                    numSet.Add(i);
                }
                else if(!numSet.Contains(i)) numCount[i]++; 
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("2032");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}