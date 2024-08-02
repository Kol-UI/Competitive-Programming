// Reveal Cards In Increasing Order


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RevealCardsInIncreasingOrder
{
    public class Solution
    {
        public static int[] DeckRevealedIncreasing(int[] deck)
        {
            Array.Sort(deck);
            var n = deck.Length;
            var ans = new int[n];
            var q = new Queue<int>(Enumerable.Range(0, n));

            for (var i = 0; i < n; i++)
            {
                ans[q.Dequeue()] = deck[i];
                if (q.Count > 0)
                {
                    q.Enqueue(q.Dequeue());
                }
            }

            return ans;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.DeckRevealedIncreasing(new int[]{17,13,11,2,3,5,7}), new int[]{2,13,3,11,5,17,7}),
                ResultTester.CheckResult<int[]>(Solution.DeckRevealedIncreasing(new int[]{1,1000}), new int[]{1,1000}),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("950");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}