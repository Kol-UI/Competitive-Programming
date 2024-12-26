// Reverse First K elements of Queue

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.GeeksForGeeks.Easy.ReverseFirstKelementsofQueue
{
    class Solution
    {
        public static Queue<int>? ModifyQueue(Queue<int> q, int k)
        {
            if (q == null || k <= 0 || k > q.Count)
            {
                return q;
            }

            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < k; i++)
            {
                stack.Push(q.Dequeue());
            }

            while (stack.Count > 0)
            {
                q.Enqueue(stack.Pop());
            }

            for (int i = 0; i < q.Count - k; i++)
            {
                q.Enqueue(q.Dequeue());
            }

            return q;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse First K elements of Queue");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks, ProblemCategory.EasyGFG);
        }
    }
}