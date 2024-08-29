// Most Stones Removed with Same Row or Column

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MostStonesRemovedwithSameRoworColumn
{
    public class Solution
    {
        public static int RemoveStones(int[][] stones)
        {
            HashSet<int[]> visited = new HashSet<int[]>();
            int countRemoved = 0;

            for (int i = 0; i < stones.Length; i++)
            {
                int[] stone = stones[i];
                if(!visited.Contains(stone))
                {
                    RemoveConnectedStones(stone, stones, visited);
                    countRemoved++;
                }
            }

            return stones.Length - countRemoved;
        }

        public static void RemoveConnectedStones(int[] startStone, int[][] allStones, HashSet<int[]> visitedStones)
        {
            Queue<int[]> stonesToVisit = new Queue<int[]>();
            stonesToVisit.Enqueue(startStone);
            visitedStones.Add(startStone);

            while (stonesToVisit.Count > 0)
            {
                int[] currentStone = stonesToVisit.Dequeue();
                EnqueueConnectedStones(currentStone, allStones, visitedStones, stonesToVisit);
            }
        }

        private static void EnqueueConnectedStones(int[] stone, int[][] allStones, HashSet<int[]> visitedStones, Queue<int[]> stonesToVisit)
        {
            for (int i = 0; i < allStones.Length; i++)
            {
                int[] currentStone = allStones[i];
                if (IsStoneConnected(stone, currentStone) && !visitedStones.Contains(currentStone))
                {
                    stonesToVisit.Enqueue(currentStone);
                    visitedStones.Add(currentStone);
                }
            }
        }

        private static bool IsStoneConnected(int[] stone1, int[] stone2)
        {
            return stone1[0] == stone2[0] || stone1[1] == stone2[1];
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] stones1 = new int[][]
            {
                new int[] { 0, 0 },
                new int[] { 0, 1 },
                new int[] { 1, 0 },
                new int[] { 1, 2 },
                new int[] { 2, 1 },
                new int[] { 2, 2 }
            };

            int[][] stones2 = new int[][]
            {
                new int[] { 0, 0 },
                new int[] { 0, 2 },
                new int[] { 1, 1 },
                new int[] { 2, 0 },
                new int[] { 2, 2 }
            };

            int[][] stones3 = new int[][]
            {
                new int[] { 0, 0 }
            };
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.RemoveStones(stones1), 5),
                ResultTester.CheckResult<int>(Solution.RemoveStones(stones2), 3),
                ResultTester.CheckResult<int>(Solution.RemoveStones(stones3), 0)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Most Stones Removed with Same Row or Column");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}