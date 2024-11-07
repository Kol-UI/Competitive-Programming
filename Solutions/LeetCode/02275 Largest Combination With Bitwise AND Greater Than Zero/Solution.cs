// Largest Combination With Bitwise AND Greater Than Zero
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LargestCombinationWithBitwiseANDGreaterThanZero
{
    public class Solution
    {
        public int LargestCombination(int[] candidates)
        {
            int[] counter = new int[32];

            for (int i = 0; i < candidates.Length; i++)
            {
                int j = 0;  
                while (candidates[i] != 0)
                {
                    counter[j] += candidates[i] & 1;
                    candidates[i] >>= 1;
                    j++;
                }
            }

            int result = 0;
            foreach (int i in counter)
            {
                if (i > result) result = i;
            }

            return result;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Largest Combination With Bitwise AND Greater Than Zero");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}