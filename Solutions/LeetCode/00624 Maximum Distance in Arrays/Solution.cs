// Maximum Distance in Arrays

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumDistanceinArrays
{
    public class Solution
    {
        public int MaxDistance(IList<IList<int>> arrays) {
            int n = arrays.Count;

            int minGlobal = int.MaxValue;
            int maxGlobal = int.MinValue;

            int result = 0;

            for (int i = 0; i < n; i++) {
                int currentMin = arrays[i][0];
                int currentMax = arrays[i][arrays[i].Count - 1];

                if (i > 0) {
                    result = Math.Max(result, Math.Abs(currentMax - minGlobal));
                    result = Math.Max(result, Math.Abs(maxGlobal - currentMin));
                }

                minGlobal = Math.Min(minGlobal, currentMin);
                maxGlobal = Math.Max(maxGlobal, currentMax);
            }

            return result;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Distance in Arrays");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}