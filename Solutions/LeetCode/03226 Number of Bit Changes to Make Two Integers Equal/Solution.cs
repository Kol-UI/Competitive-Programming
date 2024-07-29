// Number of Bit Changes to Make Two Integers Equal

using System.Numerics;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofBitChangestoMakeTwoIntegersEqual
{
    public class Solution
    {
        public int MinChanges(int n, int k)
        {
            int changesToZero = CountSetBits(k & ~n);
            int changesToOne = CountSetBits(n & ~k);

            return changesToZero == 0 ? changesToOne : -1;
        }

        private int CountSetBits(int value)
        {
            return BitOperations.PopCount((uint)value);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Bit Changes to Make Two Integers Equal");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}