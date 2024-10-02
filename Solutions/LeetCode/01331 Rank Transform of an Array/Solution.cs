// Rank Transform of an Array

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RankTransformofanArray
{
    public class Solution
    {
        public int[] ArrayRankTransform(int[] arr)
        {
            var rank = new Dictionary<int, int>();

            foreach (var a in arr.Order())
                rank.TryAdd(a, rank.Count + 1);

            return Array.ConvertAll(arr, a => rank[a]);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Rank Transform of an Array");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}