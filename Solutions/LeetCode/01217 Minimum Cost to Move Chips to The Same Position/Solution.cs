// Minimum Cost to Move Chips to The Same Position

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumCosttoMoveChipstoTheSamePosition
{
    public class Solution
    {
        public int MinCostToMoveChips(int[] position)
        {
            int oddPositionCount = 0;

            foreach (int positionValue in position)
            {
                if (positionValue % 2 != 0)
                {
                    oddPositionCount++;
                }
            }

            int evenPositionCount = position.Length - oddPositionCount;

            return Math.Min(oddPositionCount, evenPositionCount);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Cost to Move Chips to The Same Position");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}