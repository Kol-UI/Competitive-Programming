// Find Players With Zero or One Losses



using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindPlayersWithZeroorOneLosses
{
    public class Solution
    {
        public static IList<IList<int>> FindWinners(int[][] matches)
        {
        
            Dictionary<int,int> loss=new Dictionary<int,int>();

            for(int i = 0; i < matches.Length; i++)
            {
                if(!loss.ContainsKey(matches[i][0]))
                loss[matches[i][0]]=0;

                if(!loss.ContainsKey(matches[i][1]))
                loss[matches[i][1]]=0;
                loss[matches[i][1]]++;
            }
            return new List<IList<int>>()
            {
                loss.Where(x => x.Value == 0).Select(y => y.Key).OrderBy(i=>i).ToList(),
                loss.Where(x => x.Value == 1).Select(y => y.Key).OrderBy(i=>i).ToList()
            };

        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] matches1 = 
            {
                new[] {1, 3}, 
                new[] {2, 3}, 
                new[] {3, 6}, 
                new[] {5, 6}, 
                new[] {5, 7}, 
                new[] {4, 5}, 
                new[] {4, 8}, 
                new[] {4, 9}, 
                new[] {10, 4}, 
                new[] {10, 9}
            };

            int[][] matches2 = 
            {
                new[] {2, 3}, 
                new[] {1, 3}, 
                new[] {5, 4}, 
                new[] {6, 4}
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<IList<int>>>(Solution.FindWinners(matches1), new List<IList<int>> { new List<int> { 1, 2, 10 }, new List<int> { 4, 5, 7, 8 } }),
                ResultTester.CheckResult<IList<IList<int>>>(Solution.FindWinners(matches2), new List<IList<int>> { new List<int> { 1, 2, 5, 6 }, new List<int>() }),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Find Players With Zero or One Losses");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}