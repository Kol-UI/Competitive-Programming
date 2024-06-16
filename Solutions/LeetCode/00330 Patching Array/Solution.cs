// Patching Array

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.PatchingArray
{
    public class Solution
    {
        public static int MinPatches(int[] nums, int n)
        {
            int patches = 0, i = 0;
            long miss = 1;
            while (miss <= n)
            {
                if (i < nums.Length && nums[i] <= miss)
                    miss += nums[i++];
                else
                {
                    miss += miss;
                    patches++;
                }
            }
            return patches;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinPatches(new int[]{1,3}, 6), 1),
                ResultTester.CheckResult<int>(Solution.MinPatches(new int[]{1,5,10}, 20), 2),
                ResultTester.CheckResult<int>(Solution.MinPatches(new int[]{1,2,2}, 5), 0),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Patching Array");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}