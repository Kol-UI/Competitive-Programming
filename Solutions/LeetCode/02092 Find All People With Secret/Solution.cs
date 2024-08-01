// Find All People With Secret


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindAllPeopleWithSecret
{
    public class Solution
    {
        public static void DFS(int i, int time, Dictionary<int, List<(int, int)>> graph, int[] visitedAt)
        {
            foreach(var neigh in graph[i])
            {
                if(time <= neigh.Item2 && neigh.Item2 < visitedAt[neigh.Item1])
                {
                    visitedAt[neigh.Item1] = neigh.Item2;
                    DFS(neigh.Item1, neigh.Item2, graph, visitedAt);
                }
            }
        }

        public static IList<int> FindAllPeople(int n, int[][] meetings, int firstPerson)
        {
            Dictionary<int, List<(int, int)>> graph = new Dictionary<int, List<(int, int)>>();
            for(int i = 0; i < n; i++)
                graph[i] = new List<(int, int)>();

            foreach(int[] meet in meetings)
            {
                graph[meet[0]].Add((meet[1], meet[2]));
                graph[meet[1]].Add((meet[0], meet[2]));
            }

            List<int> result = new List<int>();
            int[] visitedAt = new int[n];

            Array.Fill(visitedAt, int.MaxValue);
            visitedAt[0] = 0;
            visitedAt[firstPerson] = 0;

            DFS(firstPerson, 0, graph, visitedAt);
            DFS(0, 0, graph, visitedAt);

            for(int i = 0; i < n; i++)
            {
                if(visitedAt[i] != int.MaxValue)
                    result.Add(i);
            }

            return result;
        }
    }

    public class Test
    {

        public static bool[] TestCases()
        {
            IList<int> output1 = new List<int> {0,1,2,3,5};
            IList<int> output2 = new List<int> {0,1,3};

            int[][] meetings1 =
            {
                new int[] {1, 2, 5},
                new int[] {2, 3, 8},
                new int[] {1, 5, 10}
            };

            int[][] meetings2 =
            {
                new int[] {3, 1, 3},
                new int[] {1, 2, 2},
                new int[] {0, 3, 3}
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<int>>(Solution.FindAllPeople(6, meetings1, 1), output1),
                ResultTester.CheckResult<IList<int>>(Solution.FindAllPeople(4, meetings2, 3), output2),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("2092");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}