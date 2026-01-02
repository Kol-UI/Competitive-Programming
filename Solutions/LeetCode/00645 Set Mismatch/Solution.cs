// Set Mismatch


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.SetMismatch
{
    public class Test
    {
        public class Solution
        {
            public static int[] FindErrorNums(int[] nums)
            {
                int first = nums.GroupBy(x => x).Where(g => g.Count() == 2).Select(x => x.Key).First();
                int second = Enumerable.Range(1, nums.Length).Except(nums).First();

                return new int[] { first, second }; 
            }
        }

        public class Solution2
        {
            public int[] FindErrorNums(int[] nums)
            {
                int n = nums.Length;
                HashSet<int> seen = new HashSet<int>();
                int duplicate = 0;
                int missing = 0;

                foreach (int num in nums)
                {
                    if (!seen.Add(num))
                    {
                        duplicate = num;
                    }
                }

                for (int i = 1; i <= n; i++)
                {
                    if (!seen.Contains(i))
                    {
                        missing = i;
                        break;
                    }
                }

                return new int[] { duplicate, missing };
            }
        }

        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.FindErrorNums(new int[]{1,2,2,4}), new int[]{2,3}),
                ResultTester.CheckResult<int[]>(Solution.FindErrorNums(new int[]{1,1}), new int[]{1,2}),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Set Mismatch");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}