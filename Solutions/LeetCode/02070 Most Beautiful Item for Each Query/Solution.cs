// Most Beautiful Item for Each Query
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MostBeautifulItemforEachQuery
{    
    public class Solution
    {
        public int[] MaximumBeauty(int[][] items, int[] queries) {
            Array.Sort(items, (a, b) => a[0].CompareTo(b[0]));
            var sorted = new List<int[]>();
            int maxBeauty = 0;
            foreach (var item in items) {
                if (item[1] > maxBeauty) {
                    maxBeauty = item[1];
                    sorted.Add(new[] { item[0], maxBeauty });
                }
            }

            var indexedQueries = queries
                .Select((q, i) => (Query: q, Index: i))
                .OrderBy(x => x.Query)
                .ToArray();

            int cur = 0;
            int[] result = new int[queries.Length];
            foreach (var (query, index) in indexedQueries) {
                while (cur < sorted.Count && sorted[cur][0] <= query) cur++;
                result[index] = cur > 0 ? sorted[cur - 1][1] : 0;
            }

            return result;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Most Beautiful Item for Each Query");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}