// Minimum Increment to Make Array Unique

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumIncrementtoMakeArrayUnique
{
    public class Solution
    {
        public static int MinIncrementForUnique(int[] nums)
        {
            Array.Sort(nums);
            int moves = 0;
            for(int i = 1; i < nums.Length; i++)
            {
                if(nums[i] <= nums[i-1])
                {
                    moves += (nums[i-1] - nums[i] + 1);
                    nums[i] = nums[i-1] + 1;
                }
            }
            return moves;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinIncrementForUnique(new int[]{1,2,2}), 1),
                ResultTester.CheckResult<int>(Solution.MinIncrementForUnique(new int[]{3,2,1,2,1,7}), 6)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Increment to Make Array Unique");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}