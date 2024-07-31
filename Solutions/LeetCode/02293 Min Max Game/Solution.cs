// Min Max Game

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinMaxGame
{
    public class Solution
    {
        public int MinMaxGame(int[] nums)
        {
            int length = nums.Length;
            
            if (length == 0)
            {
                return 0;
            }
            
            if (length == 1)
            {
                return nums[0];
            }

            while (nums.Length > 1)
            {
                nums = GenerateNextRound(nums);
            }

            return nums[0];
        }

        private int[] GenerateNextRound(int[] currentnums)
        {
            int newSize = currentnums.Length / 2;
            int[] nextRoundnums = new int[newSize];

            for (int i = 0; i < newSize; i++)
            {
                if (i % 2 == 0)
                {
                    nextRoundnums[i] = Math.Min(currentnums[2 * i], currentnums[2 * i + 1]);
                }
                else
                {
                    nextRoundnums[i] = Math.Max(currentnums[2 * i], currentnums[2 * i + 1]);
                }
            }

            return nextRoundnums;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Min Max Game");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}