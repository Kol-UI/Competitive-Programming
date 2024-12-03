// Find Champion II

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindChampionII
{
    public class Solution
    {
        public int FindChampion(int n, int[][] edges)
        {
            var hashSet = new HashSet<int>(Enumerable.Range(0, n));

            for(int i = 0; i < edges.Length; i++)
            {
                hashSet.Remove(edges[i][1]);
            }

            if(hashSet.Count == 1)
            {
                return hashSet.First();
            }

            return -1;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();

            int[][] firstArray = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1, 2 }
            };

            int[][] secondArray = new int[][]
            {
                new int[] { 0, 2 },
                new int[] { 1, 3 },
                new int[] { 1, 2 }
            };


            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.FindChampion(3, firstArray), 0),
                ResultTester.CheckResult<int>(solution.FindChampion(4, secondArray), -1),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Champion II");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}