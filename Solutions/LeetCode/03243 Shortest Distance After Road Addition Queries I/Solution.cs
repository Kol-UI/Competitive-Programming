// Shortest Distance After Road Addition Queries I
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ShortestDistanceAfterRoadAdditionQueriesI
{
    public class Solution
    {
        public int[] ShortestDistanceAfterQueries(int n, int[][] queries)
        {
            var dic = GetAllRoads(n);
            var result = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                dic[queries[i][0]].Add(queries[i][1]);
                result[i] = ShortestDistanceAfterQueries(n - 1, dic);
            }
            return result;
        }

        private int ShortestDistanceAfterQueries(int to, Dictionary<int, List<int>> dic)
        {
            var border = new HashSet<int> { 0 };
            var result = 0;
            while (true)
            {
                var border2 = new HashSet<int>();
                foreach (var item in border)
                {
                    foreach (var item2 in dic[item])
                    {
                        border2.Add(item2);
                    }
                }
                result++;
                if (border2.Contains(to)) return result;
                border = border2;
            }
        }

        private Dictionary<int, List<int>> GetAllRoads(int n)
        {
            var result = new Dictionary<int, List<int>>();
            for (int i = 0; i < n - 1; i++)
            {
                result.Add(i, new List<int> { i + 1});
            }
            return result;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shortest Distance After Road Addition Queries I");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}