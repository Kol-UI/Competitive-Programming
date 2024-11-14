// Minimized Maximum of Products Distributed to Any Store

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimizedMaximumofProductsDistributedtoAnyStore
{
    public class Solution
    {
        public int MinimizedMaximum(int n, int[] quantities)
        {
            var i = 1;
            var j = quantities.Max() + 1;

            while (i < j)
            {
                var m = i + (j - i) / 2;

                if (Solve(m, n, quantities))
                {
                    j = m;
                }
                else
                {
                    i = m + 1;
                }
            }

            return j;
        }

        private bool Solve(int max, int n, int[] quantities)
        {
            for (var i = 0; i < quantities.Length && n >= 0; ++i)
            {
                n -= quantities[i] / max + Math.Min(1, quantities[i] % max);
            }

            return n >= 0;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimized Maximum of Products Distributed to Any Store");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}