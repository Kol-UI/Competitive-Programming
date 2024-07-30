// Number of Equivalent Domino Pairs

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofEquivalentDominoPairs
{
    public class Solution
    {
        public int NumEquivDominoPairs(int[][] dominoes)
        {
            var matches = new Dictionary<(int, int), int>();
            int finalCount = 0;

            foreach (var domino in dominoes)
            {
                int val1 = domino[0];
                int val2 = domino[1];
                var key = (Math.Min(val1, val2), Math.Max(val1, val2));

                if (matches.ContainsKey(key))
                {
                    finalCount += matches[key];
                }

                matches[key] = matches.GetValueOrDefault(key, 0) + 1;
            }

            return finalCount;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Equivalent Domino Pairs");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}